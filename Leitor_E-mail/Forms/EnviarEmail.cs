using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Net.Sockets;
using System.Net.Mail;
using System.Net;
using Leitor_E_mail.Ler;
using Leitor_E_mail.Utilidade;
using System.Threading;

namespace Leitor_E_mail.Forms
{
    public partial class EnviarEmail : Form
    {
        #region Constructors
        #region vars
        List<string> files = new List<string>();
        SmtpClient st = new SmtpClient();
        MailMessage email = new MailMessage();
        Dictionary<string, string> stdMails = new Dictionary<string, string>();
        #endregion

        public EnviarEmail()
        {
            InitializeComponent();
        }
        private void EnviarEmail_Load(object sender, EventArgs e)
        {
            De.Text = Referencia.refPrin.email.Text;
            //para.Text = Referencia.refPrin.deTextBox.Text;
            carregaListas();
            CarregaComboBox();
        }
        #endregion

        #region FormEvents
        private void carregar_Click(object sender, EventArgs e)
        {
            string path = stdMails[StdsChar.SelectedItem.ToString()];
            setMailStds(path);
        }

        private void Anexo_Click(object sender, EventArgs e)
        {
            DialogResult result = Arquivo.ShowDialog();
            if (result == DialogResult.OK)
            {
                files.Add(Arquivo.InitialDirectory + Arquivo.FileName);
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            Enviar_Email();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region EnviaEmail
        void Enviar_Email()
        {
            email.From = new MailAddress(De.Text); // carrega o e-mail do recebedor ####### WINDOWS FORM TEXT ##########
            email.To.Add(new MailAddress(para.Text)); // carrega o email do enviador ####### WINDOWS FORM TEXT ##########
            email.IsBodyHtml = false; //determina que o corpo nao e html
            email.Subject = Assunto.Text; //Assunto
            email.Body = texto.Text; // Corpo do e-mail ### máximo (?) ###
            for (int i = 0; i < files.Count; i++)
            {
                email.Attachments.Add(new System.Net.Mail.Attachment(files[i]));
            }

            st.EnableSsl = true; //Ativa o modo SSL (criptografia do servidor OUTLOOK)
            st.UseDefaultCredentials = false; // Desativa o uso de credenciais padroes
            st.Credentials = new NetworkCredential(De.Text, Referencia.refPrin.senha.Text); // Define as credenciais do smtp ####### WINDOWS FORM TEXT ##########
            st.Host = infoCon.serverSMTP;
            st.Port = Convert.ToInt32(infoCon.portaSMTP);
            Thread td = new System.Threading.Thread(new System.Threading.ThreadStart(EnviaEmail));
            td.SetApartmentState(System.Threading.ApartmentState.STA);
            td.IsBackground = true;
            td.Start(); // Envia o email

            this.Close();
        }

        [STAThread]
        private void EnviaEmail()
        {
            try
            {
                st.Send(email); // Envia o e-mail #### PARA TESTES: Comentar o comando para nao enviar e-mails desnecessarios ####
                st.Dispose();
                email.Dispose();
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao enviar email: " + ex.Message);
            }
        }
        #endregion

        #region Processors
        private void carregaListas()
        {
            foreach (string path in Directory.GetFiles(System.AppDomain.CurrentDomain.BaseDirectory + @"\Resources\StdMails\"))
            {
                if (path.Contains(".sem"))
                {
                    stdMails.Add(path.Replace(System.AppDomain.CurrentDomain.BaseDirectory + @"\Resources\StdMails\", "").Replace(".sem", "")
                                , path);
                }
            }
        }
        private void CarregaComboBox()
        {
            foreach (string key in stdMails.Keys)
            {
                StdsChar.Items.Add(key);
            }
            StdsChar.SelectedIndex = 0;
        }
        private void setMailStds(string path)
        {
            using (StreamReader leitor = new StreamReader(path))
            {
                texto.Text = "";
                Assunto.Text = "";
                files.Clear();
                while (leitor.EndOfStream == false)
                {
                    string[] data = leitor.ReadLine().Split(';');
                    if (data[0] == "anexo")
                    {
                        for (int i = 1; i < data.Length; i++)
                        {
                            files.Add(data[i]);
                        }
                    }
                    if (data[0] == "assunto")
                        Assunto.Text = data[1];

                    if (data[0] == "conteudo")
                    {
                        for (int i = 1; i < data.Length; i++)
                        {
                            texto.Text += data[i] + "\n";
                        }
                    }
                }
            }
        }

        #endregion

    }
}
