using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goku
{
    public partial class Resultados : Form
    {
        public Resultados()
        {
            InitializeComponent();
            for (int i = 0; i < Estruturas.Casos.Count; i++)
            {
                this.textBoxTestes.Text += "Caso " + (i + 1).ToString() + Environment.NewLine;
                this.textBoxTestes.Text += Estruturas.Casos[i].Imprimir();
                this.textBoxTestes.Text += Environment.NewLine;
            }
        }

        private void Resultados_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
