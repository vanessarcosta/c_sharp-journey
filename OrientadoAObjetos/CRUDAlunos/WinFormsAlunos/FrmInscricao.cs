using Biblioteca;
namespace WinFormsAlunos
{
    public partial class FrmInscricao : Form
    {
        Aluno _inscrito;

        private List<Disciplina> DisciplinasDisponiveis;

        public FrmInscricao(Aluno inscrito, List<Disciplina> listaDisciplinas)
        {
            InitializeComponent();
            _inscrito = inscrito;

            DisciplinasDisponiveis = new List<Disciplina>(listaDisciplinas);
            _inscrito.DisciplinasInscritas = new List<Disciplina>();

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
            DisciplinasIncritasListBox.DataSource = _inscrito.DisciplinasInscritas;
            DisciplinasIncritasListBox.DisplayMember = "Nome";
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            Disciplina disciplinaSelecionada = (Disciplina)DisciplinasListBox.SelectedItem;

            if (disciplinaSelecionada != null)
            {
                DisciplinasDisponiveis.Remove(disciplinaSelecionada);
                _inscrito.DisciplinasInscritas.Add(disciplinaSelecionada);
                AtualizarListas();
            }
        }

        private void CancelarMatricula_Click(object sender, EventArgs e)
        {
            Disciplina disciplinaSelecionada = (Disciplina)DisciplinasIncritasListBox.SelectedItem;

            if (disciplinaSelecionada != null)
            {
                _inscrito.DisciplinasInscritas.Remove(disciplinaSelecionada);
                DisciplinasDisponiveis.Add(disciplinaSelecionada);
                AtualizarListas();
            }
        }
    }
}