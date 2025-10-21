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
            btnLogin.Location = new Point(96, 168);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(96, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCadastrase
            // 
            btnCadastrase.Location = new Point(72, 216);
            btnCadastrase.Name = "btnCadastrase";
            btnCadastrase.Size = new Size(136, 23);
            btnCadastrase.TabIndex = 5;
            btnCadastrase.Text = "Cadastre-se";
            btnCadastrase.UseVisualStyleBackColor = true;
            btnCadastrase.Click += btnCadastrase_Click;
            // 
            // FrmTelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 286);
            Controls.Add(btnCadastrase);
            Controls.Add(btnLogin);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Name = "FrmTelaLogin";
            Text = "Tela de Login";
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
    }
}