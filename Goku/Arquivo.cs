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
                bool validado = false;
                try
                {
                    Estruturas.LerArquivo(caminho);
                    validado = true;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Não foi possível ler o arquivo, insira novamente.");
                }
                if (validado)
                {
                    this.Hide();
                    Resultados resultados = new Resultados();
                    resultados.Show();
                }
            }
        }
    }
}
