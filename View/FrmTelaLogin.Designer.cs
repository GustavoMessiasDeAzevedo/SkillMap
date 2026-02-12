namespace SkillMap.View
{
    partial class FrmTelaLogin
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
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            lblEmail = new Label();
            lblSenha = new Label();
            btnLogin = new Button();
            btnCadastrase = new Button();
            linkLabel1 = new LinkLabel();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(40, 72);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(40, 136);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(216, 23);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(128, 48);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(128, 112);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(41, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(96, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(96, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCadastrase
            // 
            btnCadastrase.Location = new Point(72, 240);
            btnCadastrase.Name = "btnCadastrase";
            btnCadastrase.Size = new Size(144, 23);
            btnCadastrase.TabIndex = 5;
            btnCadastrase.Text = "Cadastre-se";
            btnCadastrase.UseVisualStyleBackColor = true;
            btnCadastrase.Click += btnCadastrase_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(88, 176);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(118, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esqueci minha senha";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(72, 272);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(144, 23);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmTelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 305);
            Controls.Add(btnVoltar);
            Controls.Add(linkLabel1);
            Controls.Add(btnCadastrase);
            Controls.Add(btnLogin);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Name = "FrmTelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmTelaLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label lblEmail;
        private Label lblSenha;
        private Button btnLogin;
        private Button btnCadastrase;
        private LinkLabel linkLabel1;
        private Button btnVoltar;
    }
}