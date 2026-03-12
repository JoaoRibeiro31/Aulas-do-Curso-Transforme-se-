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
    public partial class ListaUsuario : Form
    {
        List<Usuario> ListaUsuarios;
        public ListaUsuario(List<Usuario> usuarios)
        {
            InitializeComponent();
            ListaUsuarios = usuarios;
        }
        private void ListaUsuario_Load(object sender, EventArgs e)
        {
            dataGridViewUsuarios.DataSource = ListaUsuarios;
        }
    }
}
