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
            CriarObjetos(linhas);
        }

        private static void CriarObjetos(string[] linhas)
        {
            int linhaCont = 0;
            do
            {
                string[] linha = linhas[linhaCont].Split(' ');
                CasoDeTeste _teste = new CasoDeTeste(int.Parse(linha[0]), int.Parse(linha[1]), int.Parse(linha[2]), int.Parse(linha[3]));
                if (_teste.NumeroGaleria == 0 && _teste.NumeroMagia == 0 && _teste.NumeroMonstro == 0 && _teste.NumeroSalao == 0)
                    break;
                LerMagias(linhas, ref linhaCont, _teste);
                LerSaloes(_teste);
                LerGalerias(linhas, ref linhaCont, _teste);
                LerMonstros(linhas, ref linhaCont, _teste);
                Estruturas.Casos.Add(_teste);
            } while (linhaCont < linhas.Length);
        }

        private static void LerMonstros(string[] linhas, ref int linhaCont, CasoDeTeste _teste)
        {
            for (int i = 0; i < _teste.NumeroMonstro; i++)
            {
                string[] linha = linhas[++linhaCont].Split(' ');
                Salao _salao = null;
                _teste.Saloes.ForEach(s =>
                {
                    if (s.NumeroSalao == int.Parse(linha[0]))
                        _salao = s;
                });
                Monstro _monstro = new Monstro(_salao, int.Parse(linha[1]));
                _salao.Monstros.Add(_monstro);
            }
        }

        private static void LerGalerias(string[] linhas, ref int linhaCont, CasoDeTeste _teste)
        {
            for (int i = 0; i < _teste.NumeroGaleria; i++)
            {
                string[] linha = linhas[++linhaCont].Split(' ');
                Salao _salao1 = null, _salao2 = null;
                _teste.Saloes.ForEach(s =>
                {
                    if (s.NumeroSalao == int.Parse(linha[0]))
                    {
                        _salao1 = s;
                    }
                    else if (s.NumeroSalao == int.Parse(linha[1]))
                    {
                        _salao2 = s;
                    }
                });
                Galeria _galeria = new Galeria(_salao1, _salao2);
                _salao1.Galeria.Add(_galeria);
                _salao2.Galeria.Add(_galeria);
                _teste.Galerias.Add(_galeria);
            }
        }

        private static void LerSaloes(CasoDeTeste _teste)
        {
            for (int i = 1; i <= _teste.NumeroSalao; i++)
            {
                _teste.Saloes.Add(new Salao(i));
            }
        }

        private static void LerMagias(string[] linhas, ref int linhaCont, CasoDeTeste _teste)
        {
            for (int i = 0; i < _teste.NumeroMagia; i++)
            {
                string[] linha = linhas[++linhaCont].Split(' ');
                Magia _magia = new Magia(int.Parse(linha[0]), int.Parse(linha[1]));
                _teste.Goku.Magias.Add(_magia);
            }
        }
    }
}
