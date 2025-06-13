namespace AtividadeAvaliativa
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuarioDigitado = txtUsuario.Text.Trim();
            string senhaDigitada = txtSenha.Text.Trim();
            string caminho = "C:/Users/rrena/Downloads/cadUsuario.txt";

            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho, "Usuario;Senha\r\n");
                File.AppendAllText(caminho, "admin;123\r\n");
            }

            bool loginValido = false;

            using (StreamReader leitor = new StreamReader(caminho))
            {
                string linha;
                bool primeiraLinha = true;

                while ((linha = leitor.ReadLine()) != null)
                {
                    if (primeiraLinha)
                    {
                        primeiraLinha = false;
                        continue; 
                    }

                    string[] partes = linha.Split(';');
                    if (partes.Length == 2)
                    {
                        string usuario = partes[0];
                        string senha = partes[1];

                        if (usuario == usuarioDigitado && senha == senhaDigitada)
                        {
                            loginValido = true;
                            break;
                        }
                    }
                }
            }


            if (loginValido)
            {
                MessageBox.Show("Login bem-sucedido!");
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
        }
    }
}
