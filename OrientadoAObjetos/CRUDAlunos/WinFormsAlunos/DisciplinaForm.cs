using Biblioteca;
using WinFormsDisciplinas;
namespace WinFormsAlunos
{
    public partial class DisciplinaForm : Form
    {
        private const string caminhoDisciplinas = "disciplinas.xml";

        List<Disciplina> listaDisciplinas;
        int contaDisciplinas = 1;
        public DisciplinaForm()
        {
            InitializeComponent();
            listaDisciplinas = new List<Disciplina>();
            txtIdDisciplina.Text = contaDisciplinas.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Disciplina novaDisciplina;

            if (ValidaForm())
            {
                //construi o objeto
                novaDisciplina = new Disciplina
                {
                    Id = contaDisciplinas,
                    Nome = txtNomeDisciplina.Text,
                };

                listaDisciplinas.Add(novaDisciplina);
                contaDisciplinas++;

                InitLista();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtNomeDisciplina.Text = string.Empty;
            txtIdDisciplina.Text = contaDisciplinas.ToString();
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

        public void InitLista()
        {
            DisciplinaListBox.DataSource = null;        //limpa o interface 
            DisciplinaListBox.DataSource = listaDisciplinas;  // associar lista ao DataSource da ListBox
            DisciplinaListBox.DisplayMember = "Nome";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeDisciplina.Text = string.Empty;
        }

        private void btnApagarDisciplina_Click(object sender, EventArgs e)
        {
            Disciplina disciplinaAApagar = (Disciplina)DisciplinaListBox.SelectedItem;

            Disciplina apagada = null;

            if (disciplinaAApagar != null)
            {
                foreach (Disciplina disciplina in listaDisciplinas)
                {
                    if (disciplinaAApagar.Id == disciplina.Id)
                    {
                        apagada = disciplina;
                    }
                }
            }

            if (apagada != null)
            {
                DialogResult resposta;
                resposta = MessageBox.Show($"Tem certeza que pretende apagar a disciplina: {apagada.Nome}",
                    "Apagar",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult.OK == resposta)
                {
                    listaDisciplinas.Remove(apagada);
                    InitLista();
                }
            }
        }

        private void EditarDisciplina_Click(object sender, EventArgs e)
        {
            Disciplina disciplinaAEditar = (Disciplina)DisciplinaListBox.SelectedItem;
            Disciplina editada = null;

            if (disciplinaAEditar != null)
            {
                foreach (Disciplina disciplina in listaDisciplinas)
                {
                    if (disciplinaAEditar.Id == disciplina.Id)
                    {
                        editada = disciplina;
                    }
                }
            }
            //abrir form Editar
            EditarDisciplinaForm editarDisciplinaForm = new EditarDisciplinaForm(this, editada);
            editarDisciplinaForm.Show();
        }

        private void DisciplinaForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(caminhoDisciplinas))
            {
                listaDisciplinas = GestaoDeArquivos.LerInfoDasDisciplinas(caminhoDisciplinas);
                foreach (Disciplina disciplina in listaDisciplinas)
                {
                    InitLista();
                }
            }
            if (listaDisciplinas.Count > 1)
            {
                int proximoId = listaDisciplinas.Max(a => a.Id) + 1;
                txtIdDisciplina.Text = proximoId.ToString();
                contaDisciplinas = proximoId;
            }
            else
            {
                txtIdDisciplina.Text = "1";
                contaDisciplinas = 1;
            }
        }

        private void DisciplinaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listaDisciplinas != null)
                GestaoDeArquivos.GravarInfoDasDisciplinas(listaDisciplinas, caminhoDisciplinas);
        }
    }
}
