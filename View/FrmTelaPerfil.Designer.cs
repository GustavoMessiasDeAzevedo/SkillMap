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
            lblCodigoUsuario = new Label();
            txtId = new TextBox();
            cbxEstado = new ComboBox();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            txtObservacaoUsuario = new TextBox();
            lblObservacao = new Label();
            lblEstado = new Label();
            txtEmailUsuario = new TextBox();
            lblEmail = new Label();
            txtNomeUsuario = new TextBox();
            lblNome = new Label();
            btnVoltar = new Button();
            gpbPerfilUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // gpbPerfilUsuario
            // 
            gpbPerfilUsuario.Controls.Add(lblCodigoUsuario);
            gpbPerfilUsuario.Controls.Add(txtId);
            gpbPerfilUsuario.Controls.Add(cbxEstado);
            gpbPerfilUsuario.Controls.Add(btnExcluir);
            gpbPerfilUsuario.Controls.Add(btnCancelar);
            gpbPerfilUsuario.Controls.Add(btnEditar);
            gpbPerfilUsuario.Controls.Add(btnSalvar);
            gpbPerfilUsuario.Controls.Add(txtObservacaoUsuario);
            gpbPerfilUsuario.Controls.Add(lblObservacao);
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
            // lblCodigoUsuario
            // 
            lblCodigoUsuario.AutoSize = true;
            lblCodigoUsuario.Location = new Point(144, 128);
            lblCodigoUsuario.Name = "lblCodigoUsuario";
            lblCodigoUsuario.Size = new Size(89, 15);
            lblCodigoUsuario.TabIndex = 13;
            lblCodigoUsuario.Text = "Código Usuário";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(144, 144);
            txtId.Name = "txtId";
            txtId.Size = new Size(88, 23);
            txtId.TabIndex = 12;
            // 
            // cbxEstado
            // 
            cbxEstado.Enabled = false;
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espirito Santo", "Goiás", "Maranhão", "Mato Grosso do Sul", "Mato Grosso", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" });
            cbxEstado.Location = new Point(16, 144);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(112, 23);
            cbxEstado.TabIndex = 11;
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
            btnExcluir.Click += btnExcluir_Click;
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
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(152, 312);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 39);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
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
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtObservacaoUsuario
            // 
            txtObservacaoUsuario.Enabled = false;
            txtObservacaoUsuario.Location = new Point(16, 192);
            txtObservacaoUsuario.Multiline = true;
            txtObservacaoUsuario.Name = "txtObservacaoUsuario";
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
            // btnVoltar
            // 
            btnVoltar.Location = new Point(416, 392);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 40);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmTelaPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 450);
            Controls.Add(btnVoltar);
            Controls.Add(gpbPerfilUsuario);
            Name = "FrmTelaPerfil";
            Text = "Meu Perfil";
            Load += FrmTelaPerfil_Load;
            gpbPerfilUsuario.ResumeLayout(false);
            gpbPerfilUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbPerfilUsuario;
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
        private ComboBox cbxEstado;
        private TextBox txtId;
        private Label lblCodigoUsuario;
        private Button btnVoltar;
    }
}