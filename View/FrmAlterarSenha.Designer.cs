namespace SkillMap.View
{
    partial class FrmAlterarSenha
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
            txtEmailAlterarSenha = new TextBox();
            label2 = new Label();
            txtNovaSenha = new TextBox();
            btnValidarEmail = new Button();
            btnAlterarSenha = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(104, 24);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 0;
            label1.Text = "Digite seu E-mail";
            // 
            // txtEmailAlterarSenha
            // 
            txtEmailAlterarSenha.Location = new Point(24, 56);
            txtEmailAlterarSenha.Name = "txtEmailAlterarSenha";
            txtEmailAlterarSenha.Size = new Size(296, 23);
            txtEmailAlterarSenha.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(120, 96);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 2;
            label2.Text = "Nova senha";
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Enabled = false;
            txtNovaSenha.Location = new Point(24, 128);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(296, 23);
            txtNovaSenha.TabIndex = 3;
            // 
            // btnValidarEmail
            // 
            btnValidarEmail.Location = new Point(96, 168);
            btnValidarEmail.Name = "btnValidarEmail";
            btnValidarEmail.Size = new Size(144, 32);
            btnValidarEmail.TabIndex = 4;
            btnValidarEmail.Text = "Validar E-mail";
            btnValidarEmail.UseVisualStyleBackColor = true;
            btnValidarEmail.Click += btnValidarEmail_Click;
            // 
            // btnAlterarSenha
            // 
            btnAlterarSenha.Enabled = false;
            btnAlterarSenha.Location = new Point(96, 208);
            btnAlterarSenha.Name = "btnAlterarSenha";
            btnAlterarSenha.Size = new Size(144, 32);
            btnAlterarSenha.TabIndex = 5;
            btnAlterarSenha.Text = "Alterar a senha";
            btnAlterarSenha.UseVisualStyleBackColor = true;
            btnAlterarSenha.Click += btnAlterarSenha_Click;
            // 
            // FrmAlterarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 251);
            Controls.Add(btnAlterarSenha);
            Controls.Add(btnValidarEmail);
            Controls.Add(txtNovaSenha);
            Controls.Add(label2);
            Controls.Add(txtEmailAlterarSenha);
            Controls.Add(label1);
            Name = "FrmAlterarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAlterarSenha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmailAlterarSenha;
        private Label label2;
        private TextBox txtNovaSenha;
        private Button btnValidarEmail;
        private Button btnAlterarSenha;
    }
}