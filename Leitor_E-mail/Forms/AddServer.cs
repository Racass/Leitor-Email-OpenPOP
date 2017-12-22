using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Leitor_E_mail.Utilidade;

namespace Leitor_E_mail.Forms
{
    public partial class AddServer : Form
    {
        public AddServer()
        {
            InitializeComponent();
        }
        #region FormEvents
        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            string[] msg;
            WriteCSV escritor = new WriteCSV();
            if(ssl.Checked == true)
                msg = new string[] {Server.Text + ";" +  lSMTP.Text + ";" + pSMTP.Text + ";" + lPOP.Text + ";" + pPOP.Text + ";Y;"};
            else
                msg = new string[] { Server.Text + ";" + lSMTP.Text + ";" + pSMTP.Text + ";" + lPOP.Text + ";" + pPOP.Text + ";N;" };

            escritor.WriteToCSV(msg);

        }
        private void pSMTP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(pSMTP.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir apenas números");
                pSMTP.Text = "";
            }
        }
        private void pPOP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(pPOP.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir apenas números");
                pPOP.Text = "";
            }
        }
        #endregion


       
        
    }
}
