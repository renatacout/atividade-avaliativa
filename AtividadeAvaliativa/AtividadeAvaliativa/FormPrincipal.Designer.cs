﻿namespace AtividadeAvaliativa
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(299, 129);
            button1.Name = "button1";
            button1.Size = new Size(179, 34);
            button1.TabIndex = 0;
            button1.Text = "Cadastro de Clientes";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(299, 167);
            button2.Name = "button2";
            button2.Size = new Size(179, 34);
            button2.TabIndex = 1;
            button2.Text = "Cadastro de Produtos ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(299, 206);
            button3.Name = "button3";
            button3.Size = new Size(179, 34);
            button3.TabIndex = 2;
            button3.Text = "Cadastro de Pedidos ";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(299, 244);
            button4.Name = "button4";
            button4.Size = new Size(179, 34);
            button4.TabIndex = 3;
            button4.Text = "Cadastro de Usuários";
            button4.UseVisualStyleBackColor = true;
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
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}