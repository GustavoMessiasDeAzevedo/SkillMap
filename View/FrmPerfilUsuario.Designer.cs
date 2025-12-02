namespace SkillMap.View
{
    partial class FrmPerfilUsuario
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
            grbPerfilUsuario = new GroupBox();
            lblObservacao = new Label();
            txtObservacao = new TextBox();
            lblEstado = new Label();
            lblEmail = new Label();
            cbxEstado = new ComboBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            lblNome = new Label();
            grbPerfilUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // grbPerfilUsuario
            // 
            grbPerfilUsuario.Controls.Add(lblObservacao);
            grbPerfilUsuario.Controls.Add(txtObservacao);
            grbPerfilUsuario.Controls.Add(lblEstado);
            grbPerfilUsuario.Controls.Add(lblEmail);
            grbPerfilUsuario.Controls.Add(cbxEstado);
            grbPerfilUsuario.Controls.Add(txtEmail);
            grbPerfilUsuario.Controls.Add(txtNome);
            grbPerfilUsuario.Controls.Add(lblNome);
            grbPerfilUsuario.Location = new Point(8, 16);
            grbPerfilUsuario.Name = "grbPerfilUsuario";
            grbPerfilUsuario.Size = new Size(496, 368);
            grbPerfilUsuario.TabIndex = 0;
            grbPerfilUsuario.TabStop = false;
            grbPerfilUsuario.Text = "Perfil do Usuário";
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(19, 210);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(69, 15);
            lblObservacao.TabIndex = 9;
            lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(19, 230);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(464, 122);
            txtObservacao.TabIndex = 8;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(18, 144);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "Estado";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(16, 80);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espirito Santo", "Goiás", "Maranhão", "Mato Grosso do Sul", "Mato Grosso", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" });
            cbxEstado.Location = new Point(21, 160);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(121, 23);
            cbxEstado.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(19, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(448, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(18, 48);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(448, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(16, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // FrmPerfilUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 403);
            Controls.Add(grbPerfilUsuario);
            Name = "FrmPerfilUsuario";
            Text = "FrmPerfilUsuario";
            Load += FrmPerfilUsuario_Load;
            grbPerfilUsuario.ResumeLayout(false);
            grbPerfilUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbPerfilUsuario;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblEmail;
        private ComboBox cbxEstado;
        private TextBox txtObservacao;
        private Label lblEstado;
        private Label lblObservacao;
    }
}