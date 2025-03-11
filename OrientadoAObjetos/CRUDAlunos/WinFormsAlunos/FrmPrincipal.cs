using Biblioteca;

namespace WinFormsAlunos
{
    public partial class FrmPrincipal : Form
    {
        List<Aluno> alunos = new List<Aluno>();
        List<Disciplina> disciplinas = new List<Disciplina>();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemAluno_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(disciplinas);
            form1.Show();
        }

        private void toolStripMenuItemDisciplina_Click(object sender, EventArgs e)
        {
            DisciplinaForm disciplinaForm = new DisciplinaForm(disciplinas);
            disciplinaForm.Show();
        }
    }
}
