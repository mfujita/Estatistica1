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
        List<int> nFilhos;
        List<double> sMinimos;

        public CalculosEstatisticos()
        {
            nFilhos = new List<int>();
            sMinimos = new List<double>();
            GeradorDeTestes gt = new GeradorDeTestes();
            gt.GeraGrauInstrucao();
            gt.GeraNumeroFilhos();
            gt.GeraSalariosMinimos();
            grauInstrucao = gt.GetGrauInstrucao();
            sorteioGrauInstrucao = gt.GetSorteioGrauInstrucao();
            nFilhos = gt.GetNumeroFilhos();
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

        public List<int> GetNfilhos()
        {
            return nFilhos;
        }

        public List<double> GetSMinimos()
        {
            return sMinimos;
        }

        public List<AuxGrauInstrucao> FazTabelaGrauInstrucao()
        {
            int[] freqGrauInstrucao = new int[sorteioGrauInstrucao.Count];
            Dictionary<string, int> DicEstadoCivil = new Dictionary<string, int>();
            double[] porcGrauInstrucao = new double[5];
            List<AuxGrauInstrucao> listaGrauInstrucao = new List<AuxGrauInstrucao>();

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
            }

            for (int i = 0; i < 5; i++)
            {
                AuxGrauInstrucao agi = new AuxGrauInstrucao(grauInstrucao[i], freqGrauInstrucao[i], porcGrauInstrucao[i]);
                listaGrauInstrucao.Add(agi);
            }

            return listaGrauInstrucao;
        }

        public Dictionary<int, int> FazTabelaNumeroFilhos()
        {
            int[] freqNumeroFilhos = new int[nFilhos.Count];
            Dictionary<int, int> DicNumeroFilhos = new Dictionary<int, int>();
            double[] porcGrauInstrucao = new double[5];
            List<AuxNumeroFilhos> listaNumeroFilhso = new List<AuxNumeroFilhos>();

            for (int i = 0; i < nFilhos.Count; i++)
            {
                if (nFilhos[i] == 0) { freqNumeroFilhos[0]++; }
                else if (nFilhos[i] == 1) { freqNumeroFilhos[1]++; }
                else if (nFilhos[i] == 2) { freqNumeroFilhos[2]++; }
                else if (nFilhos[i] == 3) { freqNumeroFilhos[3]++; }
                else if (nFilhos[i] == 4) { freqNumeroFilhos[4]++; }
            }

            for (int i = 0; i < 5; i++)
            {
                porcGrauInstrucao[i] = (Convert.ToDouble(freqNumeroFilhos[i]) / sorteioGrauInstrucao.Count * 100);
            }

            DicNumeroFilhos.Add(0, freqNumeroFilhos[0]);
            DicNumeroFilhos.Add(1, freqNumeroFilhos[1]);
            DicNumeroFilhos.Add(2, freqNumeroFilhos[2]);
            DicNumeroFilhos.Add(3, freqNumeroFilhos[3]);
            DicNumeroFilhos.Add(4, freqNumeroFilhos[4]);

            return DicNumeroFilhos;
        }

        public void FazTabelaSalariosMininos()
        {
            double menor = sMinimos.Min();
            double maior = sMinimos.Max();
            double amplitudeTotal = maior - menor;
            int classes = 5;
            int amplitudeClasse = (int)(amplitudeTotal / classes)+1;
            int menorInteiro = (int)(menor);
            int maiorInteiro = (int)Math.Ceiling(maior);
            int[] freqSalariosMinimos = new int[classes];

            for (int i = 0; i < sMinimos.Count; i++)
            {
                if (sMinimos[i] >= menorInteiro + 0 * amplitudeClasse  && sMinimos[i] < menorInteiro + 1 * amplitudeClasse)
                    freqSalariosMinimos[0]++;
                else if (sMinimos[i] >= menorInteiro + 1 * amplitudeClasse && sMinimos[i] < menorInteiro + 2 *amplitudeClasse)
                    freqSalariosMinimos[1]++;
                else if (sMinimos[i] >= menorInteiro + 2 * amplitudeClasse && sMinimos[i] < menorInteiro + 3 * amplitudeClasse)
                    freqSalariosMinimos[2]++;
                else if (sMinimos[i] >= menorInteiro + 3 * amplitudeClasse && sMinimos[i] < menorInteiro + 4 * amplitudeClasse)
                    freqSalariosMinimos[3]++;
                else if (sMinimos[i] >= menorInteiro + 4 * amplitudeClasse && sMinimos[i] < menorInteiro + 5 * amplitudeClasse)
                    freqSalariosMinimos[4]++;
            }

            for (int i = 0; i < classes; i++)
            {
                Console.WriteLine("{0,3} ├ {1,3} {2}", menorInteiro+i*amplitudeClasse, menorInteiro+(i+1)*amplitudeClasse, freqSalariosMinimos[i]);
            }
        }
    }
}
