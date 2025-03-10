using Biblioteca;
namespace WinFormsAlunos
{
    public partial class FrmInscricao : Form
    {
        Form1 _form;
        Aluno _inscrito;

        List<Disciplina> Disciplinas;
        List<Disciplina> DisciplinasDisponiveis;
        List<Disciplina> DisciplinasInscritas;

        public FrmInscricao(Form1 form, Aluno inscrito, List<Disciplina> disciplinas)
        {
            InitializeComponent();
            _inscrito = inscrito;
            _form = form;
            //recebe no parametro e faço uma cópia abaixo
            Disciplinas = disciplinas;
            DisciplinasDisponiveis = new List<Disciplina>(Disciplinas);

            DisciplinasInscritas = new List<Disciplina>();

            txtIdAluno.Text = inscrito.Id.ToString();
            txtNomeAluno.Text = inscrito.Nome;
            txtApelido.Text = inscrito.Apelido;

            AtualizarListas();
        }

        private void AtualizarListas()
        {
            DisciplinasListBox.DataSource = null;
            DisciplinasListBox.DataSource = DisciplinasDisponiveis;
            DisciplinasListBox.DisplayMember = "Nome";

            DisciplinasIncritasListBox.DataSource = null;
            DisciplinasIncritasListBox.DataSource = DisciplinasInscritas;
            DisciplinasIncritasListBox.DisplayMember = "Nome";

        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            Disciplina disciplinaSelecionada = (Disciplina)DisciplinasListBox.SelectedItem;

            if (disciplinaSelecionada != null)
            {
                DisciplinasDisponiveis.Remove(disciplinaSelecionada);
                DisciplinasInscritas.Add(disciplinaSelecionada);
                AtualizarListas();
            }
        }

        private void CancelarMatricula_Click(object sender, EventArgs e)
        {
            Disciplina disciplinaSelecionada = (Disciplina)DisciplinasIncritasListBox.SelectedItem;

            if (disciplinaSelecionada != null)
            {
                DisciplinasInscritas.Remove(disciplinaSelecionada);
                DisciplinasDisponiveis.Add(disciplinaSelecionada);
                AtualizarListas();
            }
        }
    }
}
