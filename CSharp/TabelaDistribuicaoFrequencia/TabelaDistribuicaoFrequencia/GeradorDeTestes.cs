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
        List<string> numeroFilhos = new List<string>()
        {
            "0",
            "1",
            "2",
            "3",
            "4"
        };
        List<string> sorteioNumeroFilhos = new List<string>();
        List<double> salarioMinimos = new List<double>(); // Números sorteados

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
                    case 0: sorteioNumeroFilhos.Add("0"); break;
                    case 1: sorteioNumeroFilhos.Add("1"); break;
                    case 2: sorteioNumeroFilhos.Add("2"); break;
                    case 3: sorteioNumeroFilhos.Add("3"); break;
                    case 4: sorteioNumeroFilhos.Add("4"); break;
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

        //public void GeraSorteio

        public List<string> GetGrauInstrucao()
        {
            return grauInstrucao;
        }

        public List<string> GetSorteioGrauInstrucao()
        {
            return sorteioGrauInstrucao;
        }

        public List<string> GetNumeroFilhos()
        {
            return numeroFilhos;
        }

        public List<string> getSorteioNumeroFilhos()
        {
            return sorteioNumeroFilhos;
        }

        public List<double> GetSalariosMinimos()
        {
            return salarioMinimos;
        }
    }
}
