namespace Aula_Classes_e_objetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            if (login == "admin" && senha == "admin")
            {
                MessageBox.Show("Acesso Liberado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Hand);



            }
        }


        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            Cadastro tela = new Cadastro();
            tela.ShowDialog();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {

        }
    }
}
