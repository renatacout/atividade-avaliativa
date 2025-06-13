namespace AtividadeAvaliativa
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCliente = new Button();
            btnProduto = new Button();
            btnPedido = new Button();
            btnUsuario = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(299, 129);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(179, 34);
            btnCliente.TabIndex = 0;
            btnCliente.Text = "Cadastro de Clientes";
            btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnProduto
            // 
            btnProduto.Location = new Point(299, 167);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(179, 34);
            btnProduto.TabIndex = 1;
            btnProduto.Text = "Cadastro de Produtos ";
            btnProduto.UseVisualStyleBackColor = true;
            // 
            // btnPedido
            // 
            btnPedido.Location = new Point(299, 206);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(179, 34);
            btnPedido.TabIndex = 2;
            btnPedido.Text = "Cadastro de Pedidos ";
            btnPedido.UseVisualStyleBackColor = true;
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(299, 244);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(179, 34);
            btnUsuario.TabIndex = 3;
            btnUsuario.Text = "Cadastro de Usuários";
            btnUsuario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 111);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 4;
            label1.Text = "Selecione uma das opções:";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnUsuario);
            Controls.Add(btnPedido);
            Controls.Add(btnProduto);
            Controls.Add(btnCliente);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCliente;
        private Button btnProduto;
        private Button btnPedido;
        private Button btnUsuario;
        private Label label1;
    }
}