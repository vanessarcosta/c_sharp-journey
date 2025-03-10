using Biblioteca;

namespace WinFormsAlunos
{
    public partial class EditarAlunoForm : Form
    {

        Aluno _editado;

        Form1 _form;

        List<Disciplina> Disciplinas;
        
        public EditarAlunoForm(Form1 form, Aluno editado, List<Disciplina> disciplinas)
        {
            InitializeComponent();
            _editado = editado;
            _form = form;
            Disciplinas = disciplinas;
          
            txtIdAluno.Text = editado.Id.ToString();
            txtNomeAluno.Text = editado.Nome;
            txtApelido.Text = editado.Apelido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                _editado.Nome = txtNomeAluno.Text;
                _editado.Apelido = txtApelido.Text;
                _form.InitLista();
                this.Close();
            }
        }

        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(txtNomeAluno.Text))
            {
                MessageBox.Show("Insira o nome do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtApelido.Text))
            {
                MessageBox.Show("Insira o apelido do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }

        private void btnIncricao_Click(object sender, EventArgs e)
        {
            FrmInscricao frmInscricao = new FrmInscricao(_form, _editado, Disciplinas);
            frmInscricao.Show();
        }
    }
}
