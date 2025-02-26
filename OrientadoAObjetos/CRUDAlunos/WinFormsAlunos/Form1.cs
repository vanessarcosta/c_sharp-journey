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
            txtIdAluno.Text = contaAlunos.ToString();   
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

            txtNomeAluno.Text = string.Empty;
            txtApelidoAluno.Text = string.Empty;
            txtIdAluno.Text = contaAlunos.ToString();
        }

        public void InitLista()
        {
            AlunosListBox.DataSource = null;
            AlunosListBox.DataSource = Alunos;
            AlunosListBox.DisplayMember = "NomeCompleto";
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeAluno.Text = string.Empty;
            txtApelidoAluno.Text = string.Empty;
        }

        private void btnApagarAluno_Click(object sender, EventArgs e)
        {
            Aluno alunoAApagar = (Aluno)AlunosListBox.SelectedItem;

            Aluno apagado = null;

            if (alunoAApagar != null)
            {
                foreach (Aluno aluno in Alunos)
                {
                    if (alunoAApagar.Id == aluno.Id)
                    {
                        apagado = aluno;
                    }
                }

                if (apagado != null)
                {
                    DialogResult resposta;
                    resposta = MessageBox.Show($"Tem a certeza que pretende apagar o {apagado.NomeCompleto}",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        Alunos.Remove(apagado);
                        InitLista();
                    }
                }
            }
        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            Aluno alunoAEditar = (Aluno)AlunosListBox.SelectedItem;
            Aluno editado = null;

            if (alunoAEditar != null)
            {
                foreach (Aluno aluno in Alunos)
                {
                    if (alunoAEditar.Id == aluno.Id)
                    {
                        editado = aluno;
                    }
                }

                //abrir a nova form para editar
                EditarAlunoForm editarAlunoForm = new EditarAlunoForm(this, editado);
                editarAlunoForm.Show();
            }
        }
    }
}
