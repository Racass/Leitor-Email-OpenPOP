using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Net.Sockets;
using System.Net.Mail;
using System.Net;
using Leitor_E_mail.Ler;
using Leitor_E_mail.Utilidade;
using Leitor_E_mail.Forms;
using Leitor_E_mail.Utilidade.Listas;

namespace Leitor_E_mail
{
    public partial class Principal : Form
    {
        List<E_mail> _emails = new List<E_mail>();
        List<arqCSV> servers = new List<arqCSV>();
        bool con = false;
        int cnt = 0;

        #region Constructors
        public Principal()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Referencia.refPrin = this;
            string linha;
            using (StreamReader leitor = new StreamReader(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory) + @"\Resources\server.csv"))
            {
                string[] linhaSep;
                while (leitor.EndOfStream == false && (linha = leitor.ReadLine()).Length > 4)
                {
                    linhaSep = delimit(linha);
                    servers.Add(new arqCSV());
                    servers[cnt].server = linhaSep[0];
                    servers[cnt].serverSMTP = linhaSep[1];
                    servers[cnt].portaSMTP = linhaSep[2];
                    servers[cnt].serverPOP = linhaSep[3];
                    servers[cnt].portaPOP = linhaSep[4];

                    if (linhaSep[5] == "Y")
                        servers[cnt].ssl = true;
                    else
                        servers[cnt].ssl = false;

                    cnt++;
                }
            }
            email.Text = Properties.Settings.Default.StdMail;
            senha.Text = Properties.Settings.Default.StdPass;
        }

        #region ConsProcessor
        private string[] delimit(string text)
        {
            return text.Split(';');
        }

        #endregion
        #endregion
        #region ProcessamentoPublic
        public void ControlButtons(bool Enabled)
        {
            Ler.Enabled = Enabled;
        }
        public void AtualizarDataBindings()
        {
            // Limpando os bindings.
            //deTextBox.DataBindings.Clear();
            //paraTextBox.DataBindings.Clear();
            //dataDateTimePicker.DataBindings.Clear();
            //conteudoTextBox.DataBindings.Clear();
            emailsListBox.DataSource = null;
            emailsBindingSource.DataSource = null;

            // Re-configurando os bindings.
            emailsBindingSource.DataSource = _emails;
            emailsListBox.DataSource = emailsBindingSource;
            emailsListBox.DisplayMember = "Assunto";
            //deTextBox.DataBindings.Add(new Binding("Text", emailsBindingSource, "De"));
            //paraTextBox.DataBindings.Add(new Binding("Text", emailsBindingSource, "Para"));
            //dataDateTimePicker.DataBindings.Add(new Binding("Value", emailsBindingSource, "Data"));
            //conteudoTextBox.DataBindings.Add(new Binding("Text", emailsBindingSource, "ConteudoTexto"));
        }
        #endregion
        #region Processamento interno

        private void connect(bool consegui, string status)
        {
            email.Enabled = consegui;
            senha.Enabled = consegui;
            Connect.Text = status;
            Ler.Enabled = !consegui;
            NEmail.Enabled = !consegui;
        }
        #endregion
        #region FormEvents

        private void NEmail_Click(object sender, EventArgs e)
        {
            EnviarEmail enviar = new EnviarEmail();
            enviar.ShowDialog(this);
        }
        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Ler_Click(object sender, EventArgs e)
        {
            LerEmails leitura = new LerEmails(infoCon.serverPOP, infoCon.portaPOP, infoCon.ssl, email.Text, senha.Text, _emails, Convert.ToInt32(Qtd.Text));
            progresso.Value = 0;
            ControlButtons(false);
            leitura.iniciaThread();

            try
            {
                //for (int i = messageCount; i > 2400; i--)
                AtualizarDataBindings();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            if (Connect.Text != "Desconectar")
            {
                int linha = -1;
                for (int i = 0; i < servers.Count; i++)
                {
                    if (email.Text.Contains(servers[i].server))
                    {
                        linha = i;
                        break;
                    }
                }

                if (linha == -1)
                {
                    MessageBox.Show("Servidor não encontrado.");
                    con = false;
                    return;
                }
                else
                {
                    infoCon.server = servers[linha].server;
                    infoCon.serverSMTP = servers[linha].serverSMTP;
                    infoCon.portaSMTP = servers[linha].portaSMTP;
                    infoCon.serverPOP = servers[linha].serverPOP;
                    infoCon.portaPOP = servers[linha].portaPOP;
                    infoCon.ssl = servers[linha].ssl;
                    con = true;
                }
            }
            if (con)
            {
                connect(false, "Desconectar");
                con = false;
            }

            else
                connect(true, "Conectar");
        }
        private void emailsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (emailsListBox.SelectedItem != null)
            {
                Email abrirEmail = new Email((E_mail)emailsBindingSource.Current);
                abrirEmail.ShowDialog(this);
                emailsListBox.SelectedItem = null;
            }

        }
        private void Remind_CheckedChanged(object sender, EventArgs e)
        {
            if (Remind.Checked)
            {
                Properties.Settings.Default.StdMail = email.Text;
                Properties.Settings.Default.StdPass = senha.Text;
            }
            else
            {
                Properties.Settings.Default.StdMail = "";
                Properties.Settings.Default.StdPass = "";
            }
        }
        #endregion

    }
}

