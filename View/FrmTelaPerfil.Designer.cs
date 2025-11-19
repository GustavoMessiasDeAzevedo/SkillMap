namespace SkillMap.View
{
    partial class FrmTelaPerfil
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
            gpbPerfilUsuario = new GroupBox();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            txtObservacaoUsuario = new TextBox();
            lblObservacao = new Label();
            txtEstado = new TextBox();
            lblEstado = new Label();
            txtEmailUsuario = new TextBox();
            lblEmail = new Label();
            txtNomeUsuario = new TextBox();
            lblNome = new Label();
            gpbPerfilUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // gpbPerfilUsuario
            // 
            gpbPerfilUsuario.Controls.Add(btnExcluir);
            gpbPerfilUsuario.Controls.Add(btnCancelar);
            gpbPerfilUsuario.Controls.Add(btnEditar);
            gpbPerfilUsuario.Controls.Add(btnSalvar);
            gpbPerfilUsuario.Controls.Add(txtObservacaoUsuario);
            gpbPerfilUsuario.Controls.Add(lblObservacao);
            gpbPerfilUsuario.Controls.Add(txtEstado);
            gpbPerfilUsuario.Controls.Add(lblEstado);
            gpbPerfilUsuario.Controls.Add(txtEmailUsuario);
            gpbPerfilUsuario.Controls.Add(lblEmail);
            gpbPerfilUsuario.Controls.Add(txtNomeUsuario);
            gpbPerfilUsuario.Controls.Add(lblNome);
            gpbPerfilUsuario.Location = new Point(8, 8);
            gpbPerfilUsuario.Name = "gpbPerfilUsuario";
            gpbPerfilUsuario.Size = new Size(552, 368);
            gpbPerfilUsuario.TabIndex = 0;
            gpbPerfilUsuario.TabStop = false;
            gpbPerfilUsuario.Text = "Perfil";
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Location = new Point(408, 312);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(120, 39);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(280, 312);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 39);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(152, 312);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 39);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Location = new Point(16, 312);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 39);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtObservacaoUsuario
            // 
            txtObservacaoUsuario.Enabled = false;
            txtObservacaoUsuario.Location = new Point(16, 192);
            txtObservacaoUsuario.Multiline = true;
            txtObservacaoUsuario.Name = "txtObservacaoUsuario";
            txtObservacaoUsuario.ReadOnly = true;
            txtObservacaoUsuario.Size = new Size(512, 104);
            txtObservacaoUsuario.TabIndex = 7;
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(16, 176);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(69, 15);
            lblObservacao.TabIndex = 6;
            lblObservacao.Text = "Observação";
            // 
            // txtEstado
            // 
            txtEstado.Enabled = false;
            txtEstado.Location = new Point(16, 144);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(108, 23);
            txtEstado.TabIndex = 5;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(16, 128);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Estado";
            // 
            // txtEmailUsuario
            // 
            txtEmailUsuario.Enabled = false;
            txtEmailUsuario.Location = new Point(16, 96);
            txtEmailUsuario.Name = "txtEmailUsuario";
            txtEmailUsuario.ReadOnly = true;
            txtEmailUsuario.Size = new Size(512, 23);
            txtEmailUsuario.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(16, 80);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Enabled = false;
            txtNomeUsuario.Location = new Point(16, 48);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.ReadOnly = true;
            txtNomeUsuario.Size = new Size(512, 23);
            txtNomeUsuario.TabIndex = 1;
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
            // FrmTelaPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 450);
            Controls.Add(gpbPerfilUsuario);
            Name = "FrmTelaPerfil";
            Text = "Perfil do Usuário";
            gpbPerfilUsuario.ResumeLayout(false);
            gpbPerfilUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbPerfilUsuario;
        private TextBox txtEstado;
        private Label lblEstado;
        private TextBox txtEmailUsuario;
        private Label lblEmail;
        private TextBox txtNomeUsuario;
        private Label lblNome;
        private TextBox txtObservacaoUsuario;
        private Label lblObservacao;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnSalvar;
    }
}