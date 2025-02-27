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
            txtIdDisciplina.Text = contaDisciplina.ToString();
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
            txtNomeDisciplina.Text = string.Empty;
            txtIdDisciplina.Text = contaDisciplina.ToString();

        }

        public void InitLista()
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
                foreach (Disciplina disciplina in Disciplinas)
                {
                    if(disciplinaAApagar.Id == disciplina.Id)
                    {
                        apagada = disciplina;                    }
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
                    Disciplinas.Remove(apagada);
                    InitLista();
                }
            }
        }

        private void btnEditarDisciplina_Click(object sender, EventArgs e)
        {
            Disciplina disciplinaAEditar = (Disciplina)DisciplinaListBox.SelectedItem;
            Disciplina editada = null;

            if(disciplinaAEditar != null)
            {
                foreach(Disciplina disciplina in Disciplinas)
                {
                   if(disciplinaAEditar.Id == disciplina.Id)
                    {
                        editada = disciplina;
                    }
                }
            }

            //abrir form Editar
            EditarDisciplinaForm editarDisciplinaForm = new EditarDisciplinaForm(this, editada);
            editarDisciplinaForm.Show();
        }
    }
}
