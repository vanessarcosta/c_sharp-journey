using Biblioteca;

namespace WinFormsAppFinanciamento
{
    public partial class Form1 : Form
    {
        double montante;
        int prazoPagamento;
        double jurosAnual;
        public string nomeFiador;
        public string moradaFiador;
        public int telefoneFiador;
        public int nifFiador;
        public double rendimentoFiador;
        public Form1()
        {
            InitializeComponent();
            nomeFiador = string.Empty;
            moradaFiador = string.Empty;
            telefoneFiador = 0;
            nifFiador = 0;
            rendimentoFiador = 0.0;
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                if (comboBoxTipo.Text == "Carro")
                {
                    if (prazoPagamento > 60)
                    {
                        MessageBox.Show("Insira quantidade de meses válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FinanciamentoDeCarro novofinanciamentoDeCarro = new FinanciamentoDeCarro(montante, prazoPagamento, jurosAnual);
                        novofinanciamentoDeCarro.ValorPrestacao();
                        lblInformacao.Text = novofinanciamentoDeCarro.ToString();
                    }
                }

                if (comboBoxTipo.Text == "Casa")
                {
                    FinanciamentoDeCasa novofinanciamentoDeCasa = new FinanciamentoDeCasa(montante, prazoPagamento, jurosAnual, nomeFiador, moradaFiador, telefoneFiador, nifFiador, rendimentoFiador);
                    novofinanciamentoDeCasa.ValorPrestacao();
                    lblInformacao.Text = novofinanciamentoDeCasa.ToString();
                }

                if (comboBoxTipo.Text == "Outros")
                {
                    FinanciamentoOutros novoFinanciamentoOutros = new FinanciamentoOutros(montante, prazoPagamento, jurosAnual);
                    novoFinanciamentoOutros.ValorPrestacao();
                    lblInformacao.Text = novoFinanciamentoOutros.ToString();
                }
            }
        }

        private bool ValidarForm()
        {
            bool output = true;
            if (string.IsNullOrEmpty(txtMontante.Text) || !double.TryParse(txtMontante.Text, out montante))
            {
                MessageBox.Show("Insira um valor válido para o montante.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtPrazo.Text) || !int.TryParse(txtPrazo.Text, out prazoPagamento))
            {
                MessageBox.Show("Insira quantidade de meses válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (prazoPagamento <= 0)
            {
                MessageBox.Show("Insira quantidade de meses válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(comboBoxTipo.Text))
            {
                MessageBox.Show("Selecione um tipo de financiamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtJuros.Text) || !double.TryParse(txtJuros.Text, out jurosAnual))
            {
                MessageBox.Show("Insira um valor válido para juros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedItem.ToString() == "Carro")
            {
                lblInformacao.Text = "Prazo máximo do financiamento é de 60 meses.";
            }
            else
            {
                lblInformacao.Text = string.Empty;
            }

            if (comboBoxTipo.SelectedItem.ToString() == "Casa")
            {
                FrmFiador frmFiador = new FrmFiador(this);
                frmFiador.ShowDialog();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtJuros.Clear();
            txtMontante.Clear();
            txtPrazo.Clear();
            lblInformacao.Text = string.Empty;
        }
    }
}
