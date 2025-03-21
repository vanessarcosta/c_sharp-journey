namespace WinFormsAppFinanciamento
{
    public partial class FrmFiador : Form
    {
        Form1 _form1;
        public FrmFiador(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void btnSalvarFiador_Click(object sender, EventArgs e)
        {
            ValidarForm();
            _form1.nomeFiador = txtNome.Text;
            _form1.moradaFiador = txtMorada.Text;
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

            if (string.IsNullOrEmpty(txtTelefone.Text) || !int.TryParse(txtTelefone.Text, out _form1.telefoneFiador))
            {
                MessageBox.Show("Insira um valor válido para telefone.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtNif.Text) || !int.TryParse(txtNif.Text, out _form1.nifFiador))
            {
                MessageBox.Show("Insira um valor válido de NIF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtRendimentoAnual.Text) || !double.TryParse(txtRendimentoAnual.Text, out _form1.rendimentoFiador))
            {
                MessageBox.Show("Insira um valor válido de rendimento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }
    }
}
