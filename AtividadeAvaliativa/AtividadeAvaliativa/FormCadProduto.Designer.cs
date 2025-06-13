namespace AtividadeAvaliativa
{
    partial class FormCadProduto
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
            label1 = new Label();
            txtNomeProduto = new TextBox();
            label2 = new Label();
            txtPreco = new TextBox();
            label3 = new Label();
            txtDescrição = new TextBox();
            btnSalvarProduto = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 108);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do produto:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(263, 126);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(256, 23);
            txtNomeProduto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 163);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Preço:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(263, 181);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(256, 23);
            txtPreco.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 225);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Descrição:";
            // 
            // txtDescrição
            // 
            txtDescrição.Location = new Point(263, 243);
            txtDescrição.Name = "txtDescrição";
            txtDescrição.Size = new Size(256, 23);
            txtDescrição.TabIndex = 5;
            // 
            // btnSalvarProduto
            // 
            btnSalvarProduto.Location = new Point(323, 297);
            btnSalvarProduto.Name = "btnSalvarProduto";
            btnSalvarProduto.Size = new Size(115, 32);
            btnSalvarProduto.TabIndex = 6;
            btnSalvarProduto.Text = "Salvar Produto";
            btnSalvarProduto.UseVisualStyleBackColor = true;
            // 
            // FormCadProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvarProduto);
            Controls.Add(txtDescrição);
            Controls.Add(label3);
            Controls.Add(txtPreco);
            Controls.Add(label2);
            Controls.Add(txtNomeProduto);
            Controls.Add(label1);
            Name = "FormCadProduto";
            Text = "FormCadProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeProduto;
        private Label label2;
        private TextBox txtPreco;
        private Label label3;
        private TextBox txtDescrição;
        private Button btnSalvarProduto;
    }
}