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
    public partial class SetaEnvioAutomatico : Form
    {
        int tempo = 0;
        Dictionary<string, string> stdMails = new Dictionary<string, string>();

        public SetaEnvioAutomatico()
        {
            InitializeComponent();
        }

        private void SetaEnvioAutomatico_Load(object sender, EventArgs e)
        {
            carregaListas();
            CarregaComboBox();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tempo = Convert.ToInt32(TxtTempo.Text);
                if (tempo > 60000)
                {
                    throw new Exception("O tempo deve ser menor que 60000 segundos ou 16 horas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TxtTempo.Text = "";
            }
        }



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

        private void SetMail()
        {
            if (!Directory.Exists(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory) + @"\Resources\StdSenders"))
                Directory.CreateDirectory(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory) + @"\Resources\StdSenders");

            using (StreamWriter escritor = new StreamWriter(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory) + @"\Resources\StdSenders\" + nome.Text + ".scfg"))
            {
                escritor.WriteLine("Padrão: " + nome.Text);
                escritor.Write("path;");
                foreach (string key in stdMails.Keys)
                {
                    escritor.Write(stdMails[key] + ";");
                }
                escritor.WriteLine("tempo;" + tempo.ToString());
            }
        }

        #endregion

        private void carregar_Click(object sender, EventArgs e)
        {
            SetMail();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
