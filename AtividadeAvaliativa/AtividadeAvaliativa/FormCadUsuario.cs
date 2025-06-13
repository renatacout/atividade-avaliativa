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
    public partial class FormCadUsuario : Form
    {
        public FormCadUsuario()
        {
            InitializeComponent();
        }
    
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            string caminho = "C:/Users/rrena/Downloads/cadUsuario.txt";

            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho, "Usuario;Senha\r\n");
            }

            string linha = $"{usuario};{senha}";
            File.AppendAllText(caminho, linha + "\r\n");

            MessageBox.Show("Usuário cadastrado com sucesso!");
            txtUsuario.Clear();
            txtSenha.Clear();
        }
    }
}
