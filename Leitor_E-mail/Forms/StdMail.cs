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

namespace Leitor_E_mail.Forms
{
    public partial class StdMail : Form
    {
        List<string> fileCam = new List<string>();

        public StdMail()
        {
            InitializeComponent();
        }

        private void Anexo_Click(object sender, EventArgs e)
        {
            DialogResult result = Arquivo.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileCam.Add(Arquivo.InitialDirectory + Arquivo.FileName);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            using(StreamWriter escritor = new StreamWriter(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory) + @"\Resources\StdMails\" + assunto.Text + ".eml"))
            {
                for(int i = 0; i < fileCam.Count; i++)
                {
                    escritor.WriteLine("anexo;" + fileCam[i] + ";");
                }
                escritor.WriteLine("assunto;" + assunto.Text);
                escritor.WriteLine("conteudo;" + conteudo.Text);
            }
        }
    }
}
