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
        string fileCam = String.Empty;
        SmtpClient st = new SmtpClient();
        MailMessage email = new MailMessage();

        #region Constructors
        public EnviarEmail()
        {
            InitializeComponent();
        }
        private void EnviarEmail_Load(object sender, EventArgs e)
        {
            De.Text = Referencia.refPrin.email.Text;
            //para.Text = Referencia.refPrin.deTextBox.Text;
        }
        #endregion
        #region FormEvents
        private void Anexo_Click(object sender, EventArgs e)
        {
            DialogResult result = Arquivo.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileCam = Arquivo.InitialDirectory + Arquivo.FileName;
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
            if (fileCam != String.Empty)
            {
                email.Attachments.Add(new System.Net.Mail.Attachment(fileCam));
                fileCam = String.Empty;
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

            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao enviar email: " + ex.Message);
            }
        }
        #endregion
    }
}
