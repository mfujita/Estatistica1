using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDistribuicaoFrequencia
{
    class GeradorDeTestes
    {
        List<string> grauInstrucao = new List<string>()
        {
            "Ensino Fundamental",
            "Ensino Médio",
            "Superior incompleto",
            "Superior completo",
            "Pós-graduação"
        };
        List<string> sorteioGrauInstrucao;
        List<int> numeroFilhos = new List<int>();
        List<double> salarioMinimos = new List<double>();
        int qtdeDados = 19;
        Random rand = new Random();

        public void GeraGrauInstrucao()
        {
            sorteioGrauInstrucao = new List<string>();
            for (int i = 0; i < qtdeDados; i++)
            {
                switch(rand.Next(1, 6))
                {
                    case 1: sorteioGrauInstrucao.Add("Ensino Fundamental"); break;
                    case 2: sorteioGrauInstrucao.Add("Ensino Médio"); break;
                    case 3: sorteioGrauInstrucao.Add("Superior incompleto"); break;
                    case 4: sorteioGrauInstrucao.Add("Superior completo"); break;
                    case 5: sorteioGrauInstrucao.Add("Pós-graduação"); break;
                }
            }
        }

        public void GeraNumeroFilhos()
        {
            for (int i = 0; i < qtdeDados; i++)
            {
                switch (rand.Next(0, 5))
                {
                    case 0: numeroFilhos.Add(0); break;
                    case 1: numeroFilhos.Add(1); break;
                    case 2: numeroFilhos.Add(2); break;
                    case 3: numeroFilhos.Add(3); break;
                    case 4: numeroFilhos.Add(4); break;
                    default: numeroFilhos.Add(5); break;
                }
            }
        }

        public void GeraSalariosMinimos()
        {
            for (int i = 0; i < qtdeDados; i++)
            {
                double decimais = Convert.ToDouble((rand.NextDouble()).ToString("0.00"));
                salarioMinimos.Add(rand.Next(4, 25) + decimais);
            }
        }

        public List<string> GetGrauInstrucao()
        {
            return grauInstrucao;
        }

        public List<string> GetSorteioGrauInstrucao()
        {
            return sorteioGrauInstrucao;
        }

        public List<int> GetNumeroFilhos()
        {
            return numeroFilhos;
        }

        public List<double> GetSalariosMinimos()
        {
            return salarioMinimos;
        }
    }
}
