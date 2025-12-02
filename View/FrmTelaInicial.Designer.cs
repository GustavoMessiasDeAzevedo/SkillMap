namespace SkillMap
{
    partial class FrmTelaInicial
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
            btnLogin = new Button();
            btnCadastrar = new Button();
            lblSkillMapTI = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(40, 88);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(216, 48);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(40, 152);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(216, 48);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastre-se";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblSkillMapTI
            // 
            lblSkillMapTI.AutoSize = true;
            lblSkillMapTI.Font = new Font("Segoe UI", 20F);
            lblSkillMapTI.Location = new Point(88, 32);
            lblSkillMapTI.Name = "lblSkillMapTI";
            lblSkillMapTI.Size = new Size(119, 37);
            lblSkillMapTI.TabIndex = 3;
            lblSkillMapTI.Text = "SkillMap";
            // 
            // FrmTelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 271);
            Controls.Add(lblSkillMapTI);
            Controls.Add(btnCadastrar);
            Controls.Add(btnLogin);
            Name = "FrmTelaInicial";
            Text = "Tela Inicial";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private Button btnCadastrar;
        private Label lblSkillMapTI;
    }
}
