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

namespace Leitor_E_mail
{
    public partial class Principal : Form
    {
        List<E_mail> _emails = new List<E_mail>();
        bool _useSsl = true;  

        #region Constructors
        public Principal()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Referencia.refPrin = this;
        }
        #endregion
        #region ProcessamentoPublic
        public void ControlButtons(bool Enabled)
        {
            Ler.Enabled = Enabled;
            dataDateTimePicker.Enabled = Enabled;
            Qtd.Enabled = Enabled;
            portaPP.Enabled = Enabled;
            portaSMTP.Enabled = Enabled;
            pop.Enabled = Enabled;
            smtp.Enabled = Enabled;
            senha.Enabled = Enabled;
            paraTextBox.Enabled = Enabled;
            deTextBox.Enabled = Enabled;
            assunto.Enabled = Enabled;
        }
        public void AtualizarDataBindings()
        {
            // Limpando os bindings.
            deTextBox.DataBindings.Clear();
            paraTextBox.DataBindings.Clear();
            dataDateTimePicker.DataBindings.Clear();
            conteudoTextBox.DataBindings.Clear();
            emailsListBox.DataSource = null;
            emailsBindingSource.DataSource = null;

            // Re-configurando os bindings.
            emailsBindingSource.DataSource = _emails;
            emailsListBox.DataSource = emailsBindingSource;
            emailsListBox.DisplayMember = "Assunto";
            deTextBox.DataBindings.Add(new Binding("Text", emailsBindingSource, "De"));
            paraTextBox.DataBindings.Add(new Binding("Text", emailsBindingSource, "Para"));
            dataDateTimePicker.DataBindings.Add(new Binding("Value", emailsBindingSource, "Data"));
            conteudoTextBox.DataBindings.Add(new Binding("Text", emailsBindingSource, "ConteudoTexto"));
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
        private void assunto_TextChanged(object sender, EventArgs e)
        {

        }
        private void Ler_Click(object sender, EventArgs e)
        {
            LerEmails leitura = new LerEmails(pop.Text, portaPP.Text, true, paraTextBox.Text, senha.Text, _emails, Convert.ToInt32(Qtd.Text));
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
        #endregion

    }
}

