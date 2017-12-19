using System;
using System.Collections.Generic;
using System.Linq;
using Leitor_E_mail.Utilidade;
using System.Threading;

namespace Leitor_E_mail.Ler
{
    class LerEmails
    {

        string server;
        string porta;
        bool Ssl;
        string user;
        string senha;
        List<E_mail> _emails;
        int Quantos;

        public LerEmails(string svr, string prt, bool _ussl, string _usr, string _pss, List<E_mail> mail, int qtd = 0)
        {
            server = svr;
            porta = prt;
            Ssl = _ussl;
            user = _usr;
            senha = _pss;
            _emails = mail;
            Quantos = qtd;
        }

        public void iniciaThread()
        {
            Thread td = new System.Threading.Thread(new System.Threading.ThreadStart(ler));
            td.SetApartmentState(System.Threading.ApartmentState.STA);
            td.IsBackground = true;
            td.Start();
        }


        [STAThread]
        private void ler()
        {
            try
            {
                using (var client = new OpenPop.Pop3.Pop3Client())
                {
                    int quantos = 0, index = 0;
                    int porc, cnt = 0;
                    client.Connect(server, Convert.ToInt32(porta), Ssl);
                    client.Authenticate(user, senha);
                    int messageCount = client.GetMessageCount();
                    _emails.Clear();

                    if (Quantos != 0)
                    {
                        quantos = Quantos;
                        index = messageCount - quantos;
                    }

                    if(quantos == 0)
                        quantos = messageCount;

                    porc = (0 * 100) / quantos;
                    #region Leitura
                    while (index != messageCount)
                    {
                        var popEmail = client.GetMessage(messageCount);
                        var popText = popEmail.FindFirstPlainTextVersion();
                        var popHtml = popEmail.FindFirstHtmlVersion();

                        string mailText = "";
                        string mailHtml = "";

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
                        cnt++;
                        porc = (cnt * 100) / quantos;
                        PrinAccess.qtd = porc;
                        PrinAccess.ControlaBar();
                        if (cnt % 20 == 0)
                            PrinAccess.AttBinding();
                    }
                    #endregion
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro: " + ex.Message);
            }

            finally
            {
                PrinAccess.AttBinding();
                PrinAccess.AttBtn();
            }
        }
    }
}
