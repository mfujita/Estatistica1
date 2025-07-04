using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidasResumo
{
    class OperacoesEstatisticas
    {
        private List<double> dados;

        public OperacoesEstatisticas(List<double> lista)
        {
            //dados = new List<double>();
            dados = lista;

        }

        public double CalculaMedia()
        {
            return dados.Average();
        }

        public double CalculaMediana()
        {
            double mediana = 0;
            dados.Sort();
            Dictionary<int, double> indiceNumero = new Dictionary<int, double>();

            for (int i = 0; i < dados.Count; i++)
            {
                indiceNumero.Add(i + 1, dados[i]);
            }

            if (dados.Count % 2 == 1)
            {
                int posicaoCentral = (indiceNumero.Count + 1) / 2;
            }
            else
            {
                int pos1 = indiceNumero.Count/2;
                int pos2 = pos1 + 1;
                double elementoPos1 = indiceNumero[pos1];
                double elementoPos2 = indiceNumero[pos2];
                mediana = (elementoPos1 + elementoPos2) / 2;
            }

            return mediana;
        }

        //public void CalculaModa()
        //{
        //    List<double> distintos = dados.Distinct().ToList();
        //    List<int> frequenciaDistintos = new List<int>();
        //    for (int i = 0; i < distintos.Count; i++)
        //    {
        //        frequenciaDistintos.Add(Convert.ToInt32(dados.Where(x => x.Equals(distintos[i]))));
        //    }
        //}

        public double CalculaVarianca()
        {
            double media = CalculaMedia();
            double numerador = 0;
            for (int i = 0; i < dados.Count; i++)
            {
                numerador += Math.Pow((dados[i] - media),2);
            }
            return numerador / dados.Count;
        }

        public double CalculaDesvioPadrao()
        {
            return Math.Sqrt(CalculaVarianca());
        }
    }
}
