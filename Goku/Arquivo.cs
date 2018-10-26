using System;
using System.IO;
using System.Windows.Forms;

namespace Goku
{
    public partial class Arquivo : Form
    {
        public Arquivo()
        {
            InitializeComponent();
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.ShowDialog();
                var caminho = opf.FileName;
                this.LerArquivo(caminho);
            }
        }

        private void LerArquivo(string caminho)
        {
            string arquivo;
            string[] linhas;
            using (StreamReader reader = new StreamReader(caminho))
            {
                arquivo = reader.ReadToEnd();
                reader.Close();
            }
            arquivo = arquivo.Replace("\n", null);
            linhas = arquivo.Split('\r');
            
            
        }
    }
}
