using Biblioteca;

namespace WinFormsAlunos
{
    public partial class Form1 : Form
    {
        //Defini o atributo n�o cria o objeto , depois tem que instanciar no construtor
        //N�o esquecer de qdo criar a lista add a referencia da Biblio -- fazer manual ou ctrl + .
        List<Aluno> Alunos;
        int contaAlunos = 1;

        public Form1()
        {
            Alunos = new List<Aluno>();  //instancializa uma lista vazia
            InitializeComponent();
        }
    }
}
