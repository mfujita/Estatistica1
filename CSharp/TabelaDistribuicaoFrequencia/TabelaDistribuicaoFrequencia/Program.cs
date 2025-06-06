using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDistribuicaoFrequencia
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculosEstatisticos ce = new CalculosEstatisticos();
            List<string> gInstrucao = ce.GetGinstrucao();
            List<string> sorteioGrauInstrucao = ce.GetSorteioGrauInstrucao();
            List<string> nFilhos = ce.GetNfilhos();
            List<string> sorteioNumeroFilhos = ce.GetSorteioNumeroFilhos();
            List<double> sMinimos = ce.GetSMinimos();
            List<GeradorTabelas> lGrauInstrucao = ce.FazTabelaGrauInstrucao();
            List<GeradorTabelas> lNumeroFilhos = ce.FazTabelaNumeroFilhos();
            List<GeradorTabelas> lSalariosMinimos = ce.FazTabelaSalariosMininos();
            int totalFreq = 0;
            double totalPorc = 0;

            Console.WriteLine("{0,-20} {1,-16} {2,-16}","Grau de instrução", "Número de filhos", "Salários mínimos");
            for (int i = 0; i < sorteioGrauInstrucao.Count; i++)
            {
                Console.WriteLine("{0,-20} {1,16} {2,16}", sorteioGrauInstrucao[i], sorteioNumeroFilhos[i], sMinimos[i].ToString("0.00"));
            }

            Console.WriteLine("\nTabela de Distribuição de Frequência: Grau de instrução");
            Console.WriteLine("{0,-20} {1,12} {2,14}","Grau de instrução", "Frequência", "Porcentagem");
            foreach (var item in lGrauInstrucao)
            {
                Console.WriteLine("{0,-20} {1,12} {2,13}%",item.variavel, item.frequencia, item.porcentagem.ToString("0.00"));
                totalFreq += item.frequencia;
                totalPorc += Convert.ToDouble(item.porcentagem.ToString("0.00"));
            }
            Console.WriteLine("Total{0,-15} {1,12} {2,13}%","",totalFreq, totalPorc);

            totalFreq = 0;
            totalPorc = 0;

            Console.WriteLine("\nTabela de Distribuição de Frequência: Número de filhos");
            Console.WriteLine("{0,-20} {1,12} {2,14}", "Número de filhos", "Frequência", "Porcentagem");
            foreach (var item in lNumeroFilhos)
            {
                Console.WriteLine("{0,-20} {1,12} {2,13}%", item.variavel, item.frequencia, item.porcentagem.ToString("0.00"));
                totalFreq += item.frequencia;
                totalPorc += Convert.ToDouble(item.porcentagem.ToString("0.00"));
            }
            Console.WriteLine("Total{0,-15} {1,12} {2,13}%", "", totalFreq, totalPorc);

            totalFreq = 0;
            totalPorc = 0;

            Console.WriteLine("\nTabela de Distribuição de Frequência: Salários Mínimos");
            Console.WriteLine("{0,-20} {1,12} {2,14}", "Salários mínimos", "Frequência", "Porcentagem");
            foreach (var item in lSalariosMinimos)
            {
                Console.WriteLine("{0,-20} {1,12} {2,13}%", item.variavel, item.frequencia, item.porcentagem.ToString("0.00"));
                totalFreq += item.frequencia;
                totalPorc += Convert.ToDouble(item.porcentagem.ToString("0.00"));
            }
            Console.WriteLine("Total{0,-15} {1,12} {2,13}%", "", totalFreq, totalPorc);
        }
    }
}
