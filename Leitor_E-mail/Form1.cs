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

namespace Leitor_E_mail
{
    public partial class Form1 : Form
    {
        List<E_mail> _emails = new List<E_mail>();
        
        bool _useSsl = true; // Indicação se o servidor POP3 utiliza SSL para autenticação. Por exemplo, o servidor do Gmail utiliza SSL, então, "true".        
        static string fileCam = String.Empty;
        

        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Ler_Click(object sender, EventArgs e)
        {
            progresso.Value = 0;
             Cursor = Cursors.WaitCursor;

             try
             {
                 using (var client = new OpenPop.Pop3.Pop3Client())
                 {
                     int quantos = 0, index = 0;
                     double porc;
                     client.Connect(pop.Text, Convert.ToInt32(portaPP.Text), _useSsl);
                     client.Authenticate(paraTextBox.Text, senha.Text);
                     int messageCount = client.GetMessageCount();
                     _emails.Clear();
                     quantos = Convert.ToInt32(Qtd.Text);
                     index = messageCount - quantos;
                     porc = (Convert.ToDouble(quantos)) / quantos;
                     while(index != messageCount)
                     {
                         var popEmail = client.GetMessage(messageCount);
                         var popText = popEmail.FindFirstPlainTextVersion();
                         var popHtml = popEmail.FindFirstHtmlVersion();

                         string mailText = string.Empty;
                         string mailHtml = string.Empty;
                         if (popText != null)
                             mailText = popText.GetBodyAsText();
                         if (popHtml != null)
                             mailHtml = popHtml.GetBodyAsText();

                         _emails.Add(new E_mail()
                         {
                             Id = popEmail.Headers.MessageId,
                             Assunto = popEmail.Headers.Subject,
                             De = popEmail.Headers.From.Address,
                             Para = string.Join("; ", popEmail.Headers.To.Select(to => to.Address)),
                             Data = popEmail.Headers.DateSent,
                             ConteudoTexto = mailText,
                             ConteudoHtml = !string.IsNullOrWhiteSpace(mailHtml) ? mailHtml : mailText
                         });
                         messageCount--;
                         progresso.Maximum = quantos;
                         progresso.Value += Convert.ToInt32(porc);
                     }
                     //for (int i = messageCount; i > 2400; i--)
                     AtualizarDataBindings();
                 }
             }
             finally
             {
                 Cursor = Cursors.Default;
             }
        }

        private void AtualizarDataBindings()
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

        private void NEmail_Click(object sender, EventArgs e)
        {
            conteudoTextBox.Clear();
            progresso.Value = 0;
        }

        void Enviar_Email()
        {
            MailMessage email = new MailMessage();
            string name = "Cassiolato";

            email.From = new MailAddress(paraTextBox.Text, name); // carrega o e-mail do recebedor ####### WINDOWS FORM TEXT ##########
            email.To.Add(new MailAddress(deTextBox.Text, name)); // carrega o email do enviador ####### WINDOWS FORM TEXT ##########
            email.IsBodyHtml = false; //determina que o corpo nao e html
            email.Subject = assunto.Text; //Assunto
            email.Body = conteudoTextBox.Text; // Corpo do e-mail ### máximo (?) ###
            if(fileCam != String.Empty)
            {
                email.Attachments.Add(new System.Net.Mail.Attachment(fileCam));
                fileCam = String.Empty;
            }

            SmtpClient st = new SmtpClient(smtp.Text, Convert.ToInt32(portaSMTP.Text)); // ####### WINDOWS FORM TEXT ##########
            st.EnableSsl = true; //Ativa o modo SSL (criptografia do servidor OUTLOOK)
            st.UseDefaultCredentials = false; // Desativa o uso de credenciais padroes
            st.Credentials = new NetworkCredential(paraTextBox.Text, "rafael558471"); // Define as credenciais do smtp ####### WINDOWS FORM TEXT ##########
            st.Send(email); // Envia o e-mail #### PARA TESTES: Comentar o comando para nao enviar e-mails desnecessarios ####
            email.Dispose(); // Destrói a instancia "email" ### Limpeza de memória ### liberar arquivo para remove-lo do PC ###
            st.Dispose(); // Destrói a instancia "st" ### Limpeza de memória ### liberar arquivo para remove-lo do PC ###
            MessageBox.Show("Email Enviado");
        }

        private void enter_Click(object sender, EventArgs e)
        {
            progresso.Value = 0;
            Enviar_Email();
        }


        private void anexo_Click(object sender, EventArgs e)
        {
            DialogResult result = Arquivo.ShowDialog();
            if(result == DialogResult.OK)
            {
                fileCam = Arquivo.InitialDirectory + Arquivo.FileName;
            }
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}

