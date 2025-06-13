using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativa
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCadCliente formCadCliente = new FormCadCliente();
            formCadCliente.Show();
            this.Hide();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FormCadProduto formCadProduto = new FormCadProduto();
            formCadProduto.Show();
            this.Hide();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FormCadPedido formCadPedido = new FormCadPedido();
            formCadPedido.Show();
            this.Hide();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormCadUsuario formCadUsuario = new FormCadUsuario();
            formCadUsuario.Show();
            this.Hide();
        }
    }
}
