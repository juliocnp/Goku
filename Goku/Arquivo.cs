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
                Estruturas.LerArquivo(caminho);
                this.Hide();
                Resultados resultados = new Resultados();
                resultados.Show();
            }
        }
    }
}
