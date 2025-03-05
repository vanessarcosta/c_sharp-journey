using Biblioteca;
using WinFormsAlunos;

namespace WinFormsDisciplinas
{
    public partial class EditarDisciplinaForm : Form
    {
        Disciplina _editada;

        DisciplinaForm _form;

        public EditarDisciplinaForm(DisciplinaForm form, Disciplina editada)
        {
            InitializeComponent();

            _editada = editada;
            _form = form;

            txtIdDisciplina.Text = editada.Id.ToString();
            txtNomeDisciplina.Text = editada.Nome;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                _editada.Nome = txtNomeDisciplina.Text;
                _form.InitLista();
                this.Close();
            }
        }

        private bool ValidarForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(txtNomeDisciplina.Text))
            {
                MessageBox.Show("Insira o nome da disciplina ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }
    }
}
