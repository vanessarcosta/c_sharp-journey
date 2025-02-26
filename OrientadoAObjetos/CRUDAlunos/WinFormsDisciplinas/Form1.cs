using Biblioteca;

namespace WinFormsDisciplinas
{
    public partial class Form1 : Form
    {
        List<Disciplina> Disciplinas;
        int contaDisciplina = 1;

        public Form1()
        {
            Disciplinas = new List<Disciplina>();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Disciplina novaDisciplina;

            if (ValidaForm())
            {
                //construi o objeto
                novaDisciplina = new Disciplina
                {
                    Id = contaDisciplina,
                    Nome = txtNomeDisciplina.Text,
                };

                Disciplinas.Add(novaDisciplina);
                contaDisciplina++;

                InitLista();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void InitLista()
        {
           DisciplinaListBox.DataSource = null;        //limpa o interface 
           DisciplinaListBox.DataSource = Disciplinas;  // associar lista ao DataSource da ListBox
           DisciplinaListBox.DisplayMember = "Nome";
        }
        private bool ValidaForm()
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
