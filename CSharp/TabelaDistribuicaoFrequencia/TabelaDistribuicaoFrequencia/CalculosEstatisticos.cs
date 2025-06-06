using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDistribuicaoFrequencia
{
    class CalculosEstatisticos
    {
        List<string> grauInstrucao;
        List<string> sorteioGrauInstrucao;
        List<string> nFilhos;
        List<string> sorteioNumeroFilhos;
        List<double> sMinimos;

        public CalculosEstatisticos()
        {
            nFilhos = new List<string>();
            sMinimos = new List<double>();
            GeradorDeTestes gt = new GeradorDeTestes();
            gt.GeraGrauInstrucao();
            gt.GeraNumeroFilhos();
            gt.GeraSalariosMinimos();
            grauInstrucao = gt.GetGrauInstrucao();
            sorteioGrauInstrucao = gt.GetSorteioGrauInstrucao();
            nFilhos = gt.GetNumeroFilhos();
            sorteioNumeroFilhos = gt.getSorteioNumeroFilhos();
            sMinimos = gt.GetSalariosMinimos();
        }

        public List<string> GetGinstrucao()
        {
            return grauInstrucao;
        }

        public List<string> GetSorteioGrauInstrucao()
        {
            return sorteioGrauInstrucao;
        }

        public List<string> GetNfilhos()
        {
            return nFilhos;
        }

        public List<string> GetSorteioNumeroFilhos()
        {
            return sorteioNumeroFilhos;
        }

        public List<double> GetSMinimos()
        {
            return sMinimos;
        }

        public List<GeradorTabelas> FazTabelaGrauInstrucao()
        {
            int[] freqGrauInstrucao = new int[sorteioGrauInstrucao.Count];
            double[] porcGrauInstrucao = new double[5];
            List<GeradorTabelas> listaGrauInstrucao = new List<GeradorTabelas>();

            for (int i = 0; i < sorteioGrauInstrucao.Count; i++)
            {
                if (sorteioGrauInstrucao[i].Equals(grauInstrucao[0])) { freqGrauInstrucao[0]++; }
                else if (sorteioGrauInstrucao[i].Equals(grauInstrucao[1])) { freqGrauInstrucao[1]++; }
                else if (sorteioGrauInstrucao[i].Equals(grauInstrucao[2])) { freqGrauInstrucao[2]++; }
                else if (sorteioGrauInstrucao[i].Equals(grauInstrucao[3])) { freqGrauInstrucao[3]++; }
                else if (sorteioGrauInstrucao[i].Equals(grauInstrucao[4])) { freqGrauInstrucao[4]++; }
            }

            for (int i = 0; i < 5; i++)
            {
                porcGrauInstrucao[i] = (Convert.ToDouble(freqGrauInstrucao[i]) / sorteioGrauInstrucao.Count * 100);
                GeradorTabelas gt = new GeradorTabelas(grauInstrucao[i], freqGrauInstrucao[i], porcGrauInstrucao[i]);
                listaGrauInstrucao.Add(gt);
            }

            return listaGrauInstrucao;
        }

        public List<GeradorTabelas> FazTabelaNumeroFilhos()
        {
            int[] freqNumeroFilhos = new int[sorteioNumeroFilhos.Count];
            double[] porcNumeroFilhos = new double[5];
            List<GeradorTabelas> listaNumeroFilhos = new List<GeradorTabelas>();

            for (int i = 0; i < sorteioNumeroFilhos.Count; i++)
            {
                if (sorteioNumeroFilhos[i].Equals("0")) { freqNumeroFilhos[0]++; }
                else if (sorteioNumeroFilhos[i].Equals("1")) { freqNumeroFilhos[1]++; }
                else if (sorteioNumeroFilhos[i].Equals("2")) { freqNumeroFilhos[2]++; }
                else if (sorteioNumeroFilhos[i].Equals("3")) { freqNumeroFilhos[3]++; }
                else if (sorteioNumeroFilhos[i].Equals("4")) { freqNumeroFilhos[4]++; }
            }

            for (int i = 0; i < 5; i++)
            {
                porcNumeroFilhos[i] = (Convert.ToDouble(freqNumeroFilhos[i]) / sorteioNumeroFilhos.Count * 100);
                GeradorTabelas gt = new GeradorTabelas(nFilhos[i], freqNumeroFilhos[i], porcNumeroFilhos[i]);
                listaNumeroFilhos.Add(gt);
            }

            return listaNumeroFilhos;
        }

        public List<GeradorTabelas> FazTabelaSalariosMininos()
        {
            double menor = sMinimos.Min();
            double maior = sMinimos.Max();
            double amplitudeTotal = maior - menor;
            int classes = 5;
            int amplitudeClasse = (int)(amplitudeTotal / classes)+1;
            int menorInteiro = (int)(menor);
            int maiorInteiro = (int)Math.Ceiling(maior);
            int[] freqSalariosMinimos = new int[classes];
            double[] porcSalariosMinimos = new double[5];
            List<GeradorTabelas> listaSalariosMinimos = new List<GeradorTabelas>();
            string[] amplitudeClasseStr = new string[5];

            for (int i = 0; i < sMinimos.Count; i++)
            {
                if (sMinimos[i] >= menorInteiro + 0 * amplitudeClasse && sMinimos[i] < menorInteiro + 1 * amplitudeClasse)
                {
                    freqSalariosMinimos[0]++;
                    amplitudeClasseStr[0] = (menorInteiro + 0 * amplitudeClasse).ToString() + " ├ " + (menorInteiro + 1 * amplitudeClasse).ToString();
                }
                else if (sMinimos[i] >= menorInteiro + 1 * amplitudeClasse && sMinimos[i] < menorInteiro + 2 *amplitudeClasse)
                {
                    freqSalariosMinimos[1]++;
                    amplitudeClasseStr[1] = (menorInteiro + 1 * amplitudeClasse).ToString() + " ├ " + (menorInteiro + 2 * amplitudeClasse).ToString();
                }                    
                else if (sMinimos[i] >= menorInteiro + 2 * amplitudeClasse && sMinimos[i] < menorInteiro + 3 * amplitudeClasse)
                {
                    freqSalariosMinimos[2]++;
                    amplitudeClasseStr[2] = (menorInteiro + 2 * amplitudeClasse).ToString() + " ├ " + (menorInteiro + 3 * amplitudeClasse).ToString();
                }
                else if (sMinimos[i] >= menorInteiro + 3 * amplitudeClasse && sMinimos[i] < menorInteiro + 4 * amplitudeClasse)
                {
                    freqSalariosMinimos[3]++;
                    amplitudeClasseStr[3] = (menorInteiro + 3 * amplitudeClasse).ToString() + " ├ " + (menorInteiro + 4 * amplitudeClasse).ToString();
                }                    
                else if (sMinimos[i] >= menorInteiro + 4 * amplitudeClasse && sMinimos[i] < menorInteiro + 5 * amplitudeClasse)
                {
                    freqSalariosMinimos[4]++;
                    amplitudeClasseStr[4] = (menorInteiro + 4 * amplitudeClasse).ToString() + " ├ " + (menorInteiro + 5 * amplitudeClasse).ToString();
                }
            }

            for (int i = 0; i < classes; i++)
            {
                //Console.WriteLine("{0,3} ├ {1,3} {2}", menorInteiro+i*amplitudeClasse, menorInteiro+(i+1)*amplitudeClasse, freqSalariosMinimos[i]);
                porcSalariosMinimos[i] = Convert.ToDouble(freqSalariosMinimos[i]) / sMinimos.Count() * 100;
                GeradorTabelas gt = new GeradorTabelas(amplitudeClasseStr[i], freqSalariosMinimos[i], porcSalariosMinimos[i]);
                listaSalariosMinimos.Add(gt);
            }

            return listaSalariosMinimos;
        }
    }
}
