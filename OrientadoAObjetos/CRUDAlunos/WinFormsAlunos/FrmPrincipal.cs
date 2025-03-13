using Biblioteca;

namespace WinFormsAlunos
{
    public partial class FrmPrincipal : Form
    {
        public List<Aluno> listaAlunos { get; private set; }
        public List<Disciplina> listaDisciplinas {  get; private set; }

        public FrmPrincipal()
        {
            InitializeComponent();
            listaAlunos = new List<Aluno>();
            listaDisciplinas = new List<Disciplina>();
        }

        private void toolStripMenuItemAluno_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(listaDisciplinas);
            form1.Show();
        }

        private void toolStripMenuItemDisciplina_Click(object sender, EventArgs e)
        {
            DisciplinaForm disciplinaForm = new DisciplinaForm(listaDisciplinas);
            disciplinaForm.Show();
        }
    }
}