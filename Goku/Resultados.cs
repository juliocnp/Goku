using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            this.radioButtonForcaBruta.Checked = true;
        }

        private void Resultados_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int melhorKi = 0;
            this.textBoxResultados.Text = "";
            // metodo
            // FB = Força Brutta
            // GL = Guloso
            // DN = Dinamico
            for (int i = 0; i < Estruturas.Casos.Count; i++)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                if (this.radioButtonForcaBruta.Checked)
                    this.Djikstra(Estruturas.Casos[i], out melhorKi, "FB");
                else if (this.radioButtonGuloso.Checked)
                    this.Djikstra(Estruturas.Casos[i], out melhorKi, "GL");
                else
                    this.Djikstra(Estruturas.Casos[i], out melhorKi, "DN");

                if (melhorKi == int.MaxValue)
                    this.textBoxResultados.Text += "-1" + Environment.NewLine;
                else
                    this.textBoxResultados.Text += melhorKi.ToString() + Environment.NewLine;

                sw.Stop();
                //this.textBoxResultados.Text += "Timer: " + (sw.ElapsedMilliseconds).ToString() + Environment.NewLine;
            }
        }

        private void Djikstra (CasoDeTeste teste, out int melhorKi, string metodo)
        {
            Salao origem = teste.Saloes[0];
            List<List<Salao>> caminho = new List<List<Salao>>();
            List<int> gastoKi = new List<int>();
            melhorKi = 0;
            int[,] tabelaDinamica = new int[0, 0];
            if (metodo == "DN")
                tabelaDinamica = Estruturas.PreencherTabelaDinamica(teste);

            for (int i = 0; i < teste.Saloes.Count; i++)
            {
                gastoKi.Add(int.MaxValue);
                caminho.Add(new List<Salao>());
            }

            gastoKi[0] = 0;

            while (true)
            {
                Salao selecionado = null;
                int menorGastoKi = int.MaxValue;
                for (int i = 0; i < gastoKi.Count; i++)
                {
                    if (menorGastoKi >= gastoKi[i] && !teste.Saloes[i].visitado)
                    {
                        menorGastoKi = gastoKi[i];
                        selecionado = teste.Saloes[i];
                    }
                }
                if (selecionado == null)
                    break;
                selecionado.visitado = true;
                selecionado.Galeria.ForEach(galeria =>
                {
                    Salao vizinho;
                    if (galeria.Salao1 == selecionado)
                        vizinho = galeria.Salao2;
                    else
                        vizinho = galeria.Salao1;
                    if (!vizinho.visitado)
                    {
                        int indexVizinho = teste.Saloes.IndexOf(vizinho);
                        int indexSelecionado = teste.Saloes.IndexOf(selecionado);
                        if (gastoKi[indexSelecionado] + teste.Saloes[indexSelecionado].Combate(teste.Goku, tabelaDinamica,  metodo) < gastoKi[indexVizinho])
                        {
                            gastoKi[indexVizinho] = gastoKi[indexSelecionado] + teste.Saloes[indexSelecionado].Combate(teste.Goku, tabelaDinamica, metodo);
                            caminho[indexVizinho] = caminho[indexSelecionado];
                            caminho[indexVizinho].Add(teste.Saloes[indexVizinho]);
                            teste.Saloes[indexSelecionado].visitado = true;
                        }
                    }
                });
                
                bool verticesNaoVisitados = false;
                for (int i = 0; i < teste.Saloes.Count; i++)
                    if (!teste.Saloes[i].visitado)
                        verticesNaoVisitados = true;

                if (!verticesNaoVisitados)
                    break;

                selecionado = null;
            }

            melhorKi = gastoKi[teste.Saloes.Count - 1];
        }
    }
}
