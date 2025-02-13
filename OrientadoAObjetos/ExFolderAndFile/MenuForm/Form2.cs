using FileService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MenuForm
{

    public partial class FormExtensao : Form
    {
        FormPrincipal novoPrincipal;

        public FormExtensao(FormPrincipal principal)
        {
            InitializeComponent();
            novoPrincipal = principal;
        }

        public void bTNExtensao_Click(object sender, EventArgs e)
        {

            novoPrincipal.ArquivoService.Extensao = textBoxExtensao.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
        public void AtualizarLabel()
        {
            label1.Text = "Insira parte do nome da pasta e pressione OK";
            label2.Text = string.Empty;
        }
    }
}
