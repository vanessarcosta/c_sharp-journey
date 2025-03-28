using LivrariaLinq;

namespace LinqUI
{
    public partial class Form1 : Form
    {
        List<Aluno> Alunos = ListaDeAlunos.LoadAlunos();
        public Form1()
        {
            InitializeComponent();
            InitCombo();
        }

        private void InitCombo()
        {
            comboBoxTodosAlunos.DataSource = Alunos;
            comboBoxTodosAlunos.DisplayMember = "NomeCompleto";

            listBoxFiltro.DataSource = Alunos.Where(x => x.DisciplinasFeitas > 10).OrderBy(x => x.PrimeiroNome)
            .ThenBy(x => x.Apelido).ToList();

            listBoxFiltro.DisplayMember = "NomeCompleto";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Aluno alunoSelecionado = (Aluno)comboBoxTodosAlunos.SelectedItem;
            alunoSelecionado.DisciplinasFeitas = Convert.ToInt32(numericUpDownDisciplinasFeitas.Value);

            UpdateData();
        }

        private void comboBoxTodosAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aluno alunoSelecionado = (Aluno) comboBoxTodosAlunos.SelectedItem;

            numericUpDownDisciplinasFeitas.Value = alunoSelecionado.DisciplinasFeitas;
        }

        private void UpdateData()
        {
            listBoxFiltro.DataSource = Alunos.Where(x => x.DisciplinasFeitas > 10).OrderBy(x => x.PrimeiroNome)
           .ThenBy(x => x.Apelido).ToList();
        }
    }
}
