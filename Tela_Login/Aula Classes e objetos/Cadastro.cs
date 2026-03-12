using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_Classes_e_objetos
{
    public partial class Cadastro : Form
    {
        //Criando a Lista que será preenchida com usuários
        List<Usuario> usuarios = new List<Usuario>();
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomecadastro = txtNome.Text;
            int idadecadastro = int.Parse(txtIdade.Text);
            string genero = listGenero.SelectedItem.ToString();
            string cidade = txtCidade.Text;
            string formacao = listFormacao.SelectedItem.ToString();
            string estadocivil = listEstado.SelectedItem.ToString();
            string insiraUsuario = txtLogin.Text;
            string insiraSenha = txtSenha.Text;
            string confirmaSenha = txtCSenha.Text;

            //Criando um objeto (instanciando uma classe)
            Usuario usuario = new Usuario();

            usuario.Nome = nomecadastro;
            usuario.Idade = idadecadastro;
            usuario.Genero = genero;
            usuario.Cidade = cidade;
            usuario.Formacao = formacao;
            usuario.EstadoCivil = estadocivil;
            usuario.Senha = insiraSenha;

            usuarios.Add(usuario);
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            listGenero.Items.AddRange(new string[]
               {
                   "Masculino",
                   "Feminino",
                   "Prefiro não me identificar"
               });
            listFormacao.Items.AddRange(new string[]
{
                    "Ensino Fundamental",
                    "Ensino Médio",
                    "Ensino Completo"
});

            listEstado.Items.AddRange(new string[]
            {
                     "Solteiro(a)",
                     "Casado(a)",
                     "Viúvo(a)"
            });
        }


        private void btnLista_Click(object sender, EventArgs e)
        {
            ListaUsuario tela = new ListaUsuario(usuarios);
            tela.ShowDialog(); //Abre a janela
        }
    }
}
