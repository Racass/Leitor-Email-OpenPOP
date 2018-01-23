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
    public partial class ConfigAutomaticMail : Form
    {
        Dictionary<string, string> stdMails = new Dictionary<string, string>();

        public ConfigAutomaticMail()
        {
            InitializeComponent();
        }

        private void ConfigAutomaticMail_Load(object sender, EventArgs e)
        {
            carregaListas();
            CarregaComboBox();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void init_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = stdMails[combo.SelectedItem.ToString()];
            using (StreamReader leitor = new StreamReader(path))
            {
                while (leitor.EndOfStream == false)
                {
                    foreach (string texto in leitor.ReadLine().Split(';'))
                    {
                        carregados.Text += texto;
                    }
                    carregados.Text += "\n";
                }
            }
        }


        #region processors
        private void carregaListas()
        {
            foreach (string path in Directory.GetFiles(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory) + @"\Resources\StdSenders"))
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
                combo.Items.Add(key);
            }
            combo.SelectedIndex = 0;
        }

        #endregion
    }
}
