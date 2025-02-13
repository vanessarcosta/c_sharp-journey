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
    public partial class FormMoverFicheiros : Form
    {
        FormPrincipal novoPrincipal;
        public FormMoverFicheiros(FormPrincipal principal)
        {
            InitializeComponent();
            novoPrincipal = principal;
        }

        private void btnMoverFicheiros_Click(object sender, EventArgs e)
        {
            novoPrincipal.ArquivoService.Destino = $"{textBoxDestinoMover.Text}\\";
            novoPrincipal.ArquivoService.NovoCaminho = $"{textBoxMoverrFicheiros.Text}\\";
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
