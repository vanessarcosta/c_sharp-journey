using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuForm
{
    public partial class frmCriarPasta : Form
    {
        FormPrincipal novoPrincipal;
        public frmCriarPasta(FormPrincipal principal)
        {
            InitializeComponent();
            novoPrincipal = principal;

        }

        private void btnCriarPasta_Click(object sender, EventArgs e)
        {
            novoPrincipal.ArquivoService.NovoCaminho = $"{novoPrincipal.ArquivoService.Caminho}\\{textBoxCriarPasta.Text}";
            DialogResult = DialogResult.OK;
            Close();

        }

    }
}
