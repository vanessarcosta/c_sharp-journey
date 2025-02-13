using System.Windows.Forms;
using System;
using FileService;
using MenuForm;


namespace MenuForm
{
    public partial class FormPrincipal : Form
    {
        public ArquivoService ArquivoService { get; set; }

        public FormPrincipal()
        {
            InitializeComponent();
            ArquivoService = new ArquivoService();
        }

        public void todasAsSubpastasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sub-pastas:\n" + string.Join("\n", ArquivoService.ListarSubPastas(ArquivoService.Caminho)),
                  "Lista de Subpastas",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void bTNCaminho_Click(object sender, EventArgs e)
        {
            ArquivoService.Caminho = textBoxCaminho.Text;
            menuStripPrincipal.Enabled = true;
        }

        private void somenteONomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ficheiros:\n" + string.Join("\n", ArquivoService.ListarFicheirosNomes(ArquivoService.Caminho)),
               "Lista de todos os ficheiros",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        private void extensãoETamanhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ficheiros:\n" + string.Join("\n", ArquivoService.ListarFicheirosCompleto(ArquivoService.Caminho)),
              "Lista de todos os ficheiros com o tamanho e extensões",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information);
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExtensao formExtensao = new FormExtensao(this);

            if (formExtensao.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Ficheiros com extensão {ArquivoService.Extensao}:\n"
                + string.Join("\n", ArquivoService.ListarFicheirosEspecificos(ArquivoService.Caminho, ArquivoService.Extensao)),
                "Lista de todos os ficheiros: ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        public void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCriarPasta formCriarPasta = new frmCriarPasta(this);

            if (formCriarPasta.ShowDialog() == DialogResult.OK)
            {
                string resultado = ArquivoService.CriarPasta(ArquivoService.NovoCaminho);

                MessageBox.Show(resultado, "Pasta criada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void copiarFicheiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCopiarFicheiro formCopiarFicheiro = new FormCopiarFicheiro(this);

            if (formCopiarFicheiro.ShowDialog() == DialogResult.OK)
            {
                string[] resultado = ArquivoService.CopiarFicheiros(ArquivoService.Caminho, ArquivoService.Destino);

                MessageBox.Show("Ficheiros copiados: \n" + string.Join("\n", resultado),
                 "Lista de ficheiros",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
        }

        private void moverFicheiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMoverFicheiros formMoverFicheiro = new FormMoverFicheiros(this);

            if (formMoverFicheiro.ShowDialog() == DialogResult.OK)
            {
                string[] resultado = ArquivoService.MoverFicheiros(ArquivoService.NovoCaminho, ArquivoService.Destino);

                MessageBox.Show("Ficheiros movidos: \n" + string.Join("\n", resultado),
                 "Lista de ficheiros",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormExtensao formExtensao = new FormExtensao(this);

            if (formExtensao.ShowDialog() == DialogResult.OK)
            {
                string[] resultado = ArquivoService.ApagarFicheirosPorExtensao(ArquivoService.Caminho, ArquivoService.Extensao);

                MessageBox.Show($"Ficheiros apagados: \n"
                + string.Join("\n", resultado),
                "Lista de ficheiros: ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormExtensao formExtensao = new FormExtensao(this);

            formExtensao.AtualizarLabel();

            if (formExtensao.ShowDialog() == DialogResult.OK)
            {
                string[] resultado = ArquivoService.ApagarFicheirosPorCaracteresDoNome(ArquivoService.Caminho, ArquivoService.Extensao);

                MessageBox.Show($"Ficheiros apagados: \n"
                + string.Join("\n", resultado),
                "Lista de ficheiros: ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void sobreAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSobreAbout formSobreAbout = new FormSobreAbout(this);

            formSobreAbout.ShowDialog();
    
        }
    }
}
