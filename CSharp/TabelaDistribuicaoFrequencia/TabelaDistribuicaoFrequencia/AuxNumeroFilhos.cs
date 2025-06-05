using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDistribuicaoFrequencia
{
    class AuxNumeroFilhos
    {
        public string variavel { get; set; }
        public int frequencia { get; set; }
        public double porcentagem { get; set; }

        public AuxNumeroFilhos(string v, int f, double p)
        {
            variavel = v;
            frequencia = f;
            porcentagem = p;
        }
    }
}
