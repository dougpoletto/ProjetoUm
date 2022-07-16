namespace ProjetoUm.Telas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var estado = new FormCadastroEstados();
            estado.ShowDialog();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pessoa = new FormlCadastroPessoasLista();
            pessoa.ShowDialog();
        }
    }
}
