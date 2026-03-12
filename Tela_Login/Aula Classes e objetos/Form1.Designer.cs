namespace Aula_Classes_e_objetos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnEntrar = new Button();
            btnEsqueci = new Button();
            btnCadastrar = new Button();
            btnLista = new Button();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(47, 143);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(271, 23);
            txtSenha.TabIndex = 0;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(47, 68);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(271, 23);
            txtLogin.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 50);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 125);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(47, 184);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(271, 23);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnEsqueci
            // 
            btnEsqueci.Location = new Point(47, 212);
            btnEsqueci.Name = "btnEsqueci";
            btnEsqueci.Size = new Size(125, 23);
            btnEsqueci.TabIndex = 5;
            btnEsqueci.Text = "Esqueci a senha";
            btnEsqueci.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(192, 212);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(126, 23);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // btnLista
            // 
            btnLista.Location = new Point(47, 253);
            btnLista.Name = "btnLista";
            btnLista.Size = new Size(271, 23);
            btnLista.TabIndex = 7;
            btnLista.Text = "Lista de Usuario";
            btnLista.UseVisualStyleBackColor = true;
            btnLista.Click += btnLista_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 294);
            Controls.Add(btnLista);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEsqueci);
            Controls.Add(btnEntrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLogin);
            Controls.Add(txtSenha);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label label1;
        private Label label2;
        private Button btnEntrar;
        private Button btnEsqueci;
        private Button btnCadastrar;
        private Button btnLista;
    }
}
