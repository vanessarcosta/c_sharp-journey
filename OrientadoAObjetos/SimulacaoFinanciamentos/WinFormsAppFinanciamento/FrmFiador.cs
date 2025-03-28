using Biblioteca;

namespace WinFormsAppFinanciamento
{
    public partial class FrmFiador : Form
    {
        public string nomeFiador = string.Empty;
        public string moradaFiador;
        public int telefoneFiador;
        public int nifFiador;
        public double rendimentoFiador;
        Fiador novoFiador;
        Form1 _form1;

        public FrmFiador(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void btnSalvarFiador_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                novoFiador = new Fiador();
                novoFiador.NomeFiador = txtNome.Text;
                novoFiador.MoradaFiador = txtMorada.Text;
                novoFiador.TelefoneFiador = telefoneFiador;
                novoFiador.NifFiador = nifFiador;
                novoFiador.RendimentoFiador = rendimentoFiador;
            }
            _form1._fiador = novoFiador;
            this.Close();
        }
        private bool ValidarForm()
        {
            bool output = true;
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Insira o nome do fiador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtMorada.Text))
            {
                MessageBox.Show("Insira a morada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txtTelefone.Text) || !int.TryParse(txtTelefone.Text, out telefoneFiador))
            {
                MessageBox.Show("Insira um valor válido para telefone.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txtNif.Text) || !int.TryParse(txtNif.Text, out nifFiador))
            {
                MessageBox.Show("Insira um valor válido de NIF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txtRendimentoAnual.Text) || !double.TryParse(txtRendimentoAnual.Text, out rendimentoFiador))
            {
                MessageBox.Show("Insira um valor válido de rendimento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }
    }
}
