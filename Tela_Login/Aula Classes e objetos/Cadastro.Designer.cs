namespace Aula_Classes_e_objetos
{
    partial class Cadastro
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
            txtNome = new TextBox();
            Label = new Label();
            txtIdade = new TextBox();
            label3 = new Label();
            txtCidade = new TextBox();
            label2 = new Label();
            listGenero = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            listFormacao = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            txtCSenha = new TextBox();
            btnCadastrar = new Button();
            btnLista = new Button();
            listEstado = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 5);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome\r\n";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 23);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(276, 23);
            txtNome.TabIndex = 1;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(6, 49);
            Label.Name = "Label";
            Label.Size = new Size(36, 15);
            Label.TabIndex = 2;
            Label.Text = "Idade";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(6, 67);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(66, 23);
            txtIdade.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 49);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(192, 67);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(90, 23);
            txtCidade.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 49);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Genero";
            // 
            // listGenero
            // 
            listGenero.FormattingEnabled = true;
            listGenero.Location = new Point(78, 67);
            listGenero.Name = "listGenero";
            listGenero.Size = new Size(108, 23);
            listGenero.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 111);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 9;
            label4.Text = "Estado Civil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 111);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 10;
            label5.Text = "Formação";
            // 
            // listFormacao
            // 
            listFormacao.FormattingEnabled = true;
            listFormacao.Location = new Point(6, 129);
            listFormacao.Name = "listFormacao";
            listFormacao.Size = new Size(116, 23);
            listFormacao.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 167);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 12;
            label6.Text = "Insira um login";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 211);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 13;
            label7.Text = "Digite a senha";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 255);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 14;
            label8.Text = "Confirme a senha";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(6, 185);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(276, 23);
            txtLogin.TabIndex = 15;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(6, 229);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(276, 23);
            txtSenha.TabIndex = 16;
            // 
            // txtCSenha
            // 
            txtCSenha.Location = new Point(6, 273);
            txtCSenha.Name = "txtCSenha";
            txtCSenha.Size = new Size(276, 23);
            txtCSenha.TabIndex = 17;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(6, 315);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(276, 23);
            btnCadastrar.TabIndex = 18;
            btnCadastrar.Text = "Cadastrar Usuario";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnLista
            // 
            btnLista.Location = new Point(6, 355);
            btnLista.Name = "btnLista";
            btnLista.Size = new Size(276, 23);
            btnLista.TabIndex = 19;
            btnLista.Text = "Lista de Usuario";
            btnLista.UseVisualStyleBackColor = true;
            btnLista.Click += btnLista_Click;
            // 
            // listEstado
            // 
            listEstado.FormattingEnabled = true;
            listEstado.Location = new Point(166, 129);
            listEstado.Name = "listEstado";
            listEstado.Size = new Size(116, 23);
            listEstado.TabIndex = 20;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 457);
            Controls.Add(listEstado);
            Controls.Add(btnLista);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(listFormacao);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listGenero);
            Controls.Add(label2);
            Controls.Add(txtCidade);
            Controls.Add(label3);
            Controls.Add(txtIdade);
            Controls.Add(Label);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label Label;
        private TextBox txtIdade;
        private Label label3;
        private TextBox txtCidade;
        private Label label2;
        private ComboBox listGenero;
        private Label label4;
        private Label label5;
        private ComboBox listFormacao;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private TextBox txtCSenha;
        private Button btnCadastrar;
        private Button btnLista;
        private ComboBox listEstado;
    }
}