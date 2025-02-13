namespace MenuForm
{
    public partial class FormSobreAbout : Form
    {
        FormPrincipal novoPrincipal;
        public FormSobreAbout(FormPrincipal principal)
        {

            InitializeComponent();
            novoPrincipal = principal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
