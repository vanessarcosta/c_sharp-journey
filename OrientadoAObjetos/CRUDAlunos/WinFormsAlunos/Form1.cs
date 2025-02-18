using Biblioteca;

namespace WinFormsAlunos
{
    public partial class Form1 : Form
    {
        //Defini o atributo não cria o objeto , depois tem que instanciar no construtor
        //Não esquecer de qdo criar a lista add a referencia da Biblio -- fazer manual ou ctrl + .
        List<Aluno> Alunos;
        int contaAlunos = 1;

        public Form1()
        {
            Alunos = new List<Aluno>();  //instancializa uma lista vazia
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Aluno novoAluno;

            if (ValidaForm())
            {
                novoAluno = new Aluno
                {
                    Id = contaAlunos,
                    Nome = txtNomeAluno.Text,
                    Apelido = txtApelidoAluno.Text,
                };

                Alunos.Add(novoAluno);
                contaAlunos++;

                InitLista();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void InitLista()
        {
            AlunosListBox.DataSource = Alunos;
        }

        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(txtNomeAluno.Text))
            {
                MessageBox.Show("Insira o nome do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtApelidoAluno.Text))
            {
                MessageBox.Show("Insira o apelido do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }
    }
}
