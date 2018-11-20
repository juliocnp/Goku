using System;
using System.Collections.Generic;
using System.IO;

namespace Goku
{
    public static class Estruturas
    {
        static public List<CasoDeTeste> Casos;

        static Estruturas()
        {
            Casos = new List<CasoDeTeste>();
        }

        static public int[,] PreencherTabelaDinamica(CasoDeTeste casoDeTeste)
        {
            if (casoDeTeste == null || casoDeTeste.Goku == null || casoDeTeste.Goku.Magias == null || casoDeTeste.Goku.Magias.Count == 0)
                return null;

            int[,] tabela;
            List<Magia> magiasOrdenadas = QuickSort.MetodoQuickSort(casoDeTeste.Goku.Magias);
            int maiorVidaMonstro = int.MinValue;
            maiorVidaMonstro = casoDeTeste.getMaiorVidaMonstro();
            if (maiorVidaMonstro == int.MinValue)
            {
                maiorVidaMonstro = 0;
                tabela = new int[casoDeTeste.Goku.Magias.Count, maiorVidaMonstro + 1];
            }
            else
                tabela = new int[casoDeTeste.Goku.Magias.Count, maiorVidaMonstro + 1];

            for (int i = 0; i < tabela.GetLength(0); i++)
            {
                for (int j = 0; j < tabela.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        int dano = 0;
                        while (dano < j)
                        {
                            dano += magiasOrdenadas[i].Dano;
                            tabela[i, j] += magiasOrdenadas[i].Ki;
                        }
                    }
                    else if (j < magiasOrdenadas[i].Dano)
                        tabela[i, j] = tabela[i - 1, j];
                    else
                        tabela[i, j] = Math.Min(tabela[i - 1, j], tabela[i, j - magiasOrdenadas[i].Dano] + magiasOrdenadas[i].Ki);
                }
            }

            return tabela;
        }

        public static bool LerArquivo(string caminho)
        {
            try
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
                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }

        public static bool LerArquivo(string caminho, string texto)
        {
            try
            {
                string arquivo = texto;
                string[] linhas;
                arquivo = arquivo.Replace("\n", null);
                linhas = arquivo.Split('\r');
                CriarObjetos(linhas);
                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }

        private static void CriarObjetos(string[] linhas)
        {
            int linhaCont = -1;
            do
            {
                string[] linha = linhas[++linhaCont].Split(' ');
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
