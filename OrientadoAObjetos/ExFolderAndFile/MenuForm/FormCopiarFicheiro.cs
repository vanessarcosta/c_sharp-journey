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
    public partial class FormCopiarFicheiro : Form
    {
        FormPrincipal novoPrincipal;
        public FormCopiarFicheiro(FormPrincipal principal)
        {
            InitializeComponent();
            novoPrincipal = principal;
        }

        private void btnCopiarFicheiros_Click(object sender, EventArgs e)
        {
            novoPrincipal.ArquivoService.Destino = $"{novoPrincipal.ArquivoService.Caminho}\\{textBoxCopiarFicheiros.Text}\\";

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
