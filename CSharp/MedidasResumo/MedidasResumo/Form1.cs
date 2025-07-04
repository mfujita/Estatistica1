namespace MedidasResumo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtEntrada.Text = "Insira os dados separados por espaços.";
            txtEntrada.Text = "0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 2 2 2 3 4";
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string[] dadosTexto = txtEntrada.Text.Split(' ');
            List<double> dados = new List<double>();
            for (int i = 0; i < dadosTexto.Length; i++)
            {
                dados.Add(Convert.ToDouble(dadosTexto[i]));
            }

            OperacoesEstatisticas op = new OperacoesEstatisticas(dados);
            txtMedia.Text = op.CalculaMedia().ToString();
            txtMediana.Text = op.CalculaMediana().ToString();
            //op.CalculaModa();
            txtVarianca.Text = op.CalculaVarianca().ToString();
            txtDesvioPadrao.Text = op.CalculaDesvioPadrao().ToString();
        }
    }
}
