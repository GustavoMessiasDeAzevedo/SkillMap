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
            btnGerarCodigo = new Button();
            btnAlterarSenha = new Button();
            txtCodigo = new TextBox();
            label3 = new Label();
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
            label2.Location = new Point(120, 224);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 2;
            label2.Text = "Nova senha";
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Enabled = false;
            txtNovaSenha.Location = new Point(24, 256);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.PasswordChar = '*';
            txtNovaSenha.Size = new Size(296, 23);
            txtNovaSenha.TabIndex = 3;
            // 
            // btnGerarCodigo
            // 
            btnGerarCodigo.Location = new Point(96, 104);
            btnGerarCodigo.Name = "btnGerarCodigo";
            btnGerarCodigo.Size = new Size(144, 32);
            btnGerarCodigo.TabIndex = 4;
            btnGerarCodigo.Text = "Gerar código";
            btnGerarCodigo.UseVisualStyleBackColor = true;
            btnGerarCodigo.Click += btnValidarEmail_Click;
            // 
            // btnAlterarSenha
            // 
            btnAlterarSenha.Enabled = false;
            btnAlterarSenha.Location = new Point(96, 288);
            btnAlterarSenha.Name = "btnAlterarSenha";
            btnAlterarSenha.Size = new Size(144, 32);
            btnAlterarSenha.TabIndex = 5;
            btnAlterarSenha.Text = "Alterar a senha";
            btnAlterarSenha.UseVisualStyleBackColor = true;
            btnAlterarSenha.Click += btnAlterarSenha_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(24, 184);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(296, 23);
            txtCodigo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(136, 152);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 6;
            label3.Text = "Código";
            // 
            // FrmAlterarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 332);
            Controls.Add(txtCodigo);
            Controls.Add(label3);
            Controls.Add(btnAlterarSenha);
            Controls.Add(btnGerarCodigo);
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
        private Button btnGerarCodigo;
        private Button btnAlterarSenha;
        private TextBox txtCodigo;
        private Label label3;
    }
}