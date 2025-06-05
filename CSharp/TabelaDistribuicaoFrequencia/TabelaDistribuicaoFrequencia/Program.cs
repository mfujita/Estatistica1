using System;
using System.Collections.Generic;
using System.Linq;
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
            List<int> nFilhos = ce.GetNfilhos();
            List<double> sMinimos = ce.GetSMinimos();
            List<AuxGrauInstrucao> lGrauInstrucao = ce.FazTabelaGrauInstrucao();
            Dictionary<int, int> dicNf = ce.FazTabelaNumeroFilhos();

            int totalFreq = 0;
            double totalPorc = 0;
            for (int i = 0; i < sorteioGrauInstrucao.Count; i++)
            {
                Console.WriteLine("{0,-20} {1,4} {2,8}", sorteioGrauInstrucao[i], nFilhos[i], sMinimos[i].ToString("0.00"));
                
            }

            Console.WriteLine("\nTabela de Distribuição de Frequência Grau de instrução");
            foreach (var item in lGrauInstrucao)
            {
                Console.WriteLine("{0,-20} {1,4} {2,8}%",item.variavel, item.frequencia, item.porcGrauInstrucao.ToString("0.00"));
                totalFreq += item.frequencia;
                totalPorc += Convert.ToDouble(item.porcGrauInstrucao.ToString("0.00"));
            }
            Console.WriteLine("Total{0,-15} {1,4} {2,8}%","",totalFreq, totalPorc);


            Console.WriteLine("\nTabela de Distribuição de Frequência Número de filhos");
            foreach (var item in dicNf)
            {
                Console.WriteLine("{0,-20} {1,2}", item.Key, item.Value);
            }

            Console.WriteLine("\nTabela de Distribuição de Frequência Salários Mínimos");
            ce.FazTabelaSalariosMininos();
        }
    }
}
