using Biblioteca;

namespace WinFormsAlunos
{
    public partial class FrmPrincipal : Form
    {
        private const string caminhoAlunos = "alunos.txt";
        private const string caminhoDisciplinas = "disciplinas.txt";
        public List<Disciplina> disciplinasInscritas;
        public List<Aluno> listaAlunos { get; private set; }
        public List<Disciplina> listaDisciplinas { get; private set; }
        
        public FrmPrincipal()
        {
            InitializeComponent();

            listaAlunos = new List<Aluno>();
            listaDisciplinas = new List<Disciplina>();
            disciplinasInscritas = new List<Disciplina>();
        }

        private void toolStripMenuItemAluno_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(listaDisciplinas,this);
            form1.Show();
        }

        private void toolStripMenuItemDisciplina_Click(object sender, EventArgs e)
        {
            DisciplinaForm disciplinaForm = new DisciplinaForm();
            disciplinaForm.Show();
        }
        private void FrmPrincipal_Load_1(object sender, EventArgs e)
        {
            if (File.Exists(caminhoAlunos))
            {
                listaAlunos = GestaoDeArquivos.LerInfoDosAlunos(caminhoAlunos, caminhoDisciplinas);
            }
            else
            {
                MessageBox.Show("Não tem nenhum aluno cadastrado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (File.Exists(caminhoDisciplinas))
            {
                listaDisciplinas = GestaoDeArquivos.LerInfoDasDisciplinas(caminhoDisciplinas);
            }
            else
            {
                MessageBox.Show("Não tem nenhuma disciplina cadastrado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}