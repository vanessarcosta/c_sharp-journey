using Biblioteca;

namespace WinFormsAlunos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemAluno_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(new Aluno());
            form1.Show();
        }

        private void toolStripMenuItemDisciplina_Click(object sender, EventArgs e)
        {
            DisciplinaForm disciplinaForm = new DisciplinaForm();
            disciplinaForm.Show();
        }
    }
}
