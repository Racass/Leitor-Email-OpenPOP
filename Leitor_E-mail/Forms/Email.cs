using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leitor_E_mail.Forms
{
    public partial class Email : Form
    {
        public Email(E_mail _mail)
        {
            InitializeComponent();
            try
            {
                deText.Text = _mail.De;
                assunto.Text = _mail.Assunto;
                conteudo.Text = _mail.ConteudoTexto;
            }
            catch (Exception)
            { 
            }
        }
        #region formEvents
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
