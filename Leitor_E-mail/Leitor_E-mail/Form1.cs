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
    public partial class Email : Form
    {
        List<E_mail> _emails = new List<E_mail>();
        bool _useSsl = true;       
        static string fileCam = String.Empty, lastEmail = String.Empty, lastAssunto = String.Empty, lastEmailHour = String.Empty;
        int cnt = 0;
        
        public Email()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Ler_Click(object sender, EventArgs e)
        {
            Verificar_Email();
            cnt = 0;
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
            enviarEmail.Visible = true;
            Cancelar.Visible = true;
            progresso.Value = 0;
        }

        void Enviar_Email()
        {
            MailMessage email = new MailMessage();
            string name = "Cassiolato";
            try
            {
                email.From = new MailAddress(paraTextBox.Text, name); // carrega o e-mail do recebedor ####### WINDOWS FORM TEXT ##########
                email.To.Add(new MailAddress(deTextBox.Text, name)); // carrega o email do enviador ####### WINDOWS FORM TEXT ##########
                email.IsBodyHtml = false; //determina que o corpo nao e html
                email.Subject = assunto.Text; //Assunto
                email.Body = enviarEmail.Text; // Corpo do e-mail ### máximo (?) ###
                if (fileCam != String.Empty)
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
                MessageBox.Show("Email Enviado", "Confirmação");
                enviarEmail.Visible = false;
                enviarEmail.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro ao enviar");
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (enviarEmail.Text != null)
            {
                progresso.Value = 0;
                Enviar_Email();
                Cancelar.Visible = false;
            }
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

        private void Verificar_Email()
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
                    while (index != messageCount)
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
                        lastEmail = popEmail.Headers.From.Address;
                        lastAssunto = popEmail.Headers.Subject;
                        lastEmailHour = popEmail.Headers.DateSent.ToString();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            cnt++;
            timer.Text = Convert.ToString(cnt);
            try
            {
                if (cnt > Convert.ToInt32(conte.Text))
                {
                    chamar_Email();
                    cnt = 0;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Erro, favor digitar novamente a contagem.", "Erro na contagem");
                conte.Text = "120";
            }
        }

        private void Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void chamar_Email()
        {
            Verificar_Email();
            NotifyIcon nEmail = new NotifyIcon();
            nEmail.Visible = true;
            nEmail.Icon = SystemIcons.Information;
            nEmail.BalloonTipText = "O seu último e-mail é de: " + lastEmail + "\nO E-mail foi enviado as: " + lastEmailHour + "\nA verificação foi concluída as: " + Convert.ToString(this.dataDateTimePicker.Value);
            nEmail.BalloonTipTitle = "Verificação de E-mail concluída";
            nEmail.ShowBalloonTip(7000);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            enviarEmail.Visible = false;
            enviarEmail.Clear();
            Cancelar.Visible = false;
        }

    }
}

