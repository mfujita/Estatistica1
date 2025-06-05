using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDistribuicaoFrequencia
{
    class AuxGrauInstrucao
    {
        public string variavel { get; set; }
        public int frequencia { get; set; }
        public double porcGrauInstrucao { get; set; }

        public AuxGrauInstrucao(string v, int f, double p)
        {
            variavel = v;
            frequencia = f;
            porcGrauInstrucao = p;
        }
    }
}
