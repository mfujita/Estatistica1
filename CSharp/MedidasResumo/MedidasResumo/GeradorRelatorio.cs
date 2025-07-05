using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidasResumo
{
    class GeradorRelatorio
    {
        private List<double> dados;
        private static FileStream fs;
        private StreamWriter sw;
        OperacoesEstatisticas op;

        public GeradorRelatorio(List<double> lista)
        {
            dados = lista;
            fs = new FileStream("solucao.html", FileMode.Create);
            sw = new StreamWriter(fs);
            op = new OperacoesEstatisticas(dados);
        }

        private double SolucionaMedia()
        {
            double media = 0;

            sw.WriteLine("<h3>Média</h3>");
            sw.Write("<p>Média = (");
            
            for (int i = 0; i < dados.Count; i++)
            {
                if (i < dados.Count - 1)
                    sw.Write(dados[i] + " +");
                else
                    sw.Write(dados[i] + ")");
                media += dados[i];
            }
            media /= dados.Count;
            sw.WriteLine(" /{0} = {1}</p>", dados.Count, dados.Sum() / dados.Count);

            return media;
        }

        private void SolucionaMediana()
        {
            int counter = 1;
            double mediana = 0;

            sw.WriteLine("<h3>Mediana</h3>");

            sw.WriteLine("<h4>Classificando em ordem crescente</h4>");
            sw.Write("<pre>");
            dados.Sort();
            for (int i = 0; i < dados.Count; i++)
            {
                if (counter % 20 == 0)
                    sw.WriteLine("{0}<br> ", dados[i]);
                else
                    sw.Write("{0} ", dados[i]);
                counter++;
            }
            sw.WriteLine("</pre>");

            Dictionary<int, double> indiceNumero = new Dictionary<int, double>();

            for (int i = 0; i < dados.Count; i++)
            {
                indiceNumero.Add(i + 1, dados[i]);
            }

            if (dados.Count % 2 == 1)
            {
                int posicaoCentral = (indiceNumero.Count + 1) / 2;
                sw.WriteLine("<p>Quantidade de elementos ímpar:</p>");
                sw.WriteLine("<p>{0}º elemento → {1}</p>", posicaoCentral, indiceNumero[posicaoCentral]);
            }
            else
            {
                int pos1 = indiceNumero.Count / 2;
                int pos2 = pos1 + 1;
                double elementoPos1 = indiceNumero[pos1];
                double elementoPos2 = indiceNumero[pos2];
                mediana = (elementoPos1 + elementoPos2) / 2;
                sw.WriteLine("<p>A quantidade de elementos é par. Cálculo da média entre os elementos que ocupam as posições {0} e {1}:</p>", pos1, pos2);
                sw.WriteLine("<p>{0}º elemento → {1}</p>", pos1, elementoPos1);
                sw.WriteLine("<p>{0}º elemento → {1}</p>", pos2, elementoPos2);
                sw.WriteLine("<p>Mediana = ({0}+{1})/2={2}</p>", elementoPos1, elementoPos2, mediana);
            }                                                        
        }

        public void SolucionaModa()
        {
            sw.WriteLine("<h3>Moda</h3>");
            string valoresModais = "";
            List<double> distintos = dados.Distinct().ToList();
            List<int> frequenciaDistintos = new List<int>();
            Dictionary<double, int> valorFrequencia = new Dictionary<double, int>();
            for (int i = 0; i < distintos.Count; i++)
            {
                frequenciaDistintos.Add(dados.Count(x => x.Equals(distintos[i])));
                valorFrequencia.Add(distintos[i], frequenciaDistintos[i]);
            }
                        
            int maiorFrequencia = frequenciaDistintos.Max();
            int quantidadeMaiorFrequencia = frequenciaDistintos.Count(x => x.Equals(maiorFrequencia));
            List<double> listaModa = valorFrequencia.Where(x => x.Value.Equals(maiorFrequencia)).Select(m => m.Key).ToList();
            sw.WriteLine("<table border=\"1\">");
            sw.WriteLine("  <tr><th>Valor</th> <th>Frequência</th></tr>");
            for (int i = 0; i < listaModa.Count; i++)
            {
                sw.WriteLine("  <tr><td>" + listaModa[i] +"</td> <td>"+maiorFrequencia+"</td></tr>");
                valoresModais += "    <li>" + listaModa[i] + "</li>";
            }
            sw.WriteLine("</table>");

            sw.WriteLine("<p>Valores modais: {0}</p>", listaModa.Count);
            sw.WriteLine("<ul>");
            sw.WriteLine(valoresModais);
            sw.WriteLine("</ul>");
        }

        public void SolucionaVarianca()
        {
            sw.WriteLine("<h3>Variança</h3>");
            double media = op.CalculaMedia();
            double numerador = 0;

            sw.Write("<p>Variança = (");
            for (int i = 0; i < dados.Count; i++)
            {
                if (i < dados.Count - 1)
                    sw.WriteLine("(" + dados[i] + "-" + media + ")² + ");
                else
                    sw.WriteLine("(" + dados[i] + "-" + media + ")² ) / ");
                numerador += Math.Pow((dados[i] - media), 2);
            }
            sw.WriteLine("{0} = {1}</p>", dados.Count, numerador / dados.Count);
        }

        public void SolucionaDesvioPadrao()
        {
            sw.WriteLine("<h3>Desvio Padrão</h3>");
            sw.WriteLine("<p>Desvio padrão = {0}</p>", Math.Sqrt(op.CalculaVarianca()));
        }

        public void ImprimeSolucao()
        {
            IniciaPagina();
            ApresentacaoDados();
            SolucionaMedia();
            SolucionaMediana();
            SolucionaModa();
            SolucionaVarianca();
            SolucionaDesvioPadrao();
            FinalizaPagina();
        }

        private void IniciaPagina()
        {
            sw.WriteLine("<html lang=\"pt-br\">");
            sw.WriteLine("<head>");
            sw.WriteLine("    <meta charset=\"UTF-8\">");
            sw.WriteLine("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
            sw.WriteLine("    <title>Medidas resumo</title>");
            sw.WriteLine("    <style>");
            sw.WriteLine("    p, pre { padding-left: 20px; }");
            sw.WriteLine("    </style>");
            sw.WriteLine("</head>");
            sw.WriteLine("<body>");
        }

        private void ApresentacaoDados()
        {
            sw.WriteLine("<h3>Apresentação dos dados</h3>");
            sw.Write("<pre>");
            int counter = 1;
            for (int i = 0; i < dados.Count; i++)
            {
                if (counter % 20 == 0)
                    sw.WriteLine(" {0}<br>", dados[i]);
                else
                    sw.Write(" {0} ", dados[i]);
                counter++;
            }
            sw.WriteLine("</pre>");
        }

        private void FinalizaPagina()
        {
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");
            sw.Close();
            fs.Close();
        }
    }
}
