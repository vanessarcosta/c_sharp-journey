using Biblioteca;

namespace WinFormsAlunos
{
    public partial class Form1 : Form
    {
        //Defini o atributo não cria o objeto , depois tem que instanciar no construtor
        //Não esquecer de qdo criar a lista add a referencia da Biblio -- fazer manual ou ctrl + .
        List<Aluno> listaAlunos;
        int contaAlunos;
        List<Disciplina> listaDisciplinas;
        private const string caminhoAlunos = "alunos.xml";


        public Form1(List<Disciplina> disciplinas)
        {
            InitializeComponent();
            txtIdAluno.Text = contaAlunos.ToString();
            listaAlunos = new List<Aluno>();
            listaDisciplinas = disciplinas;
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

                listaAlunos.Add(novoAluno);
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
            AlunosListBox.DataSource = listaAlunos;
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
                foreach (Aluno aluno in listaAlunos)
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
                        listaAlunos.Remove(apagado);
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
                foreach (Aluno aluno in listaAlunos)
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

        private void btnInscricao_Click(object sender, EventArgs e)
        {
            Aluno alunoAInscrever = (Aluno)AlunosListBox.SelectedItem;
            Aluno inscrito = null;

            if (alunoAInscrever != null)
            {
                foreach (Aluno aluno in listaAlunos)
                {
                    if (alunoAInscrever.Id == aluno.Id)
                    {
                        inscrito = aluno;
                    }
                }

                //abrir a nova form para editar
                FrmInscricao frmInscricao = new FrmInscricao(inscrito, listaDisciplinas);
                frmInscricao.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listaAlunos != null)
                GestaoDeArquivos.GravarInfoAluno(listaAlunos, caminhoAlunos);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(caminhoAlunos))
            {
                listaAlunos = GestaoDeArquivos.LerInfoDoAluno(caminhoAlunos);
                foreach (Aluno aluno in listaAlunos)
                {
                    InitLista();
                }
            }
            else
            {
                MessageBox.Show("Não tem nenhum aluno cadastrado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (listaAlunos.Count > 1)
            {
                int proximoId = listaAlunos.Max(a => a.Id) + 1;
                txtIdAluno.Text = proximoId.ToString();
                contaAlunos = proximoId;
            }
            else
            {
                txtIdAluno.Text = "1";
                contaAlunos = 1;
            }
        }
    }
}