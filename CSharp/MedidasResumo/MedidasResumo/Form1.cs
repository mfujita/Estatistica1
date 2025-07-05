namespace MedidasResumo
{
    public partial class Form1 : Form
    {
        List<double> dados;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Location = new Point(0, 0);
            txtEntrada.Text = "Insira os dados separados por espaços.";
            // Livro Estatística Básica, Wilton de O. Bussab e Pedro A. Morettin, 8ª edição. Página 42
            //txtEntrada.Text = "0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 2 2 2 3 4";
        }

        private List<double> CriaMassaDados()
        {
            string massaDados = txtEntrada.Text.Trim().Replace("  ", " ");
            string[] dadosTexto = massaDados.Split(' ');
            dados = new List<double>();
            for (int i = 0; i < dadosTexto.Length; i++)
            {
                dados.Add(Convert.ToDouble(dadosTexto[i].Trim()));
            }

            return dados;
        }

        private void CalculaSemFazerRelatorio()
        {
            CriaMassaDados();

            OperacoesEstatisticas op = new OperacoesEstatisticas(dados);
            txtMedia.Text = op.CalculaMedia().ToString();
            txtMediana.Text = op.CalculaMediana().ToString();
            List<double> listaModa = op.CalculaModa();

            txtModa.Text = "";
            for (int i = 0; i < listaModa.Count; i++)
            {
                txtModa.Text += listaModa[i] + " ";
            }
            txtVarianca.Text = op.CalculaVarianca().ToString();
            txtDesvioPadrao.Text = op.CalculaDesvioPadrao().ToString();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (!cbRelatorio.Checked)
            {
                CalculaSemFazerRelatorio();
            }
            else
            {
                CalculaSemFazerRelatorio();

                GeradorRelatorio gr = new GeradorRelatorio(dados);
                gr.ImprimeSolucao();
            }
        }
    }
}
