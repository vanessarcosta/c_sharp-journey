using Biblioteca;

namespace WinFormsAlunos
{
    public partial class FrmPrincipal : Form
    {
        private const string caminhoAlunos = "alunos.xml";
        private const string caminhoDisciplinas = "disciplinas.xml";

        public List<Aluno> listaAlunos { get; private set; }
        public List<Disciplina> listaDisciplinas { get; private set; }
        
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
            DisciplinaForm disciplinaForm = new DisciplinaForm();
            disciplinaForm.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listaAlunos != null)
                try
                {
                    GestaoDeArquivos.GravarInfoDosAlunos(listaAlunos, caminhoAlunos);
                    MessageBox.Show("Salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show($"Erro ao salvar o arquivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true; 
                }
        }

        private void FrmPrincipal_Load_1(object sender, EventArgs e)
        {
            if (File.Exists(caminhoAlunos))
            {
                listaAlunos = GestaoDeArquivos.LerInfoDosAlunos(caminhoAlunos);
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