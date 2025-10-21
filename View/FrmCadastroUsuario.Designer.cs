namespace SkilMaps.View
{
    partial class FrmCadastroUsuario
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
            grbDadosUsuario = new GroupBox();
            txtDescricao = new TextBox();
            pnlTipoUsuario = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblTipoUsuario = new Label();
            txtConfirmarSenha = new TextBox();
            lblDescricao = new Label();
            lblConfirmarSenha = new Label();
            txtEmail = new TextBox();
            lblEnail = new Label();
            cbxPerfil = new ComboBox();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            lblEstado = new Label();
            lblSenha = new Label();
            lblNome = new Label();
            lblCodigo = new Label();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            grbDadosUsuario.SuspendLayout();
            pnlTipoUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // grbDadosUsuario
            // 
            grbDadosUsuario.Controls.Add(txtDescricao);
            grbDadosUsuario.Controls.Add(pnlTipoUsuario);
            grbDadosUsuario.Controls.Add(lblTipoUsuario);
            grbDadosUsuario.Controls.Add(txtConfirmarSenha);
            grbDadosUsuario.Controls.Add(lblDescricao);
            grbDadosUsuario.Controls.Add(lblConfirmarSenha);
            grbDadosUsuario.Controls.Add(txtEmail);
            grbDadosUsuario.Controls.Add(lblEnail);
            grbDadosUsuario.Controls.Add(cbxPerfil);
            grbDadosUsuario.Controls.Add(txtSenha);
            grbDadosUsuario.Controls.Add(txtNome);
            grbDadosUsuario.Controls.Add(txtCodigo);
            grbDadosUsuario.Controls.Add(lblEstado);
            grbDadosUsuario.Controls.Add(lblSenha);
            grbDadosUsuario.Controls.Add(lblNome);
            grbDadosUsuario.Controls.Add(lblCodigo);
            grbDadosUsuario.Location = new Point(9, 9);
            grbDadosUsuario.Margin = new Padding(4, 3, 4, 3);
            grbDadosUsuario.Name = "grbDadosUsuario";
            grbDadosUsuario.Padding = new Padding(4, 3, 4, 3);
            grbDadosUsuario.Size = new Size(728, 277);
            grbDadosUsuario.TabIndex = 0;
            grbDadosUsuario.TabStop = false;
            grbDadosUsuario.Text = "Dados do Usuário";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(19, 157);
            txtDescricao.Margin = new Padding(4, 3, 4, 3);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Conte as habilidades que possui, use a virgula para separar cada uma delas";
            txtDescricao.Size = new Size(475, 110);
            txtDescricao.TabIndex = 6;
            // 
            // pnlTipoUsuario
            // 
            pnlTipoUsuario.Controls.Add(rdbInativo);
            pnlTipoUsuario.Controls.Add(rdbAtivo);
            pnlTipoUsuario.Enabled = false;
            pnlTipoUsuario.Location = new Point(532, 175);
            pnlTipoUsuario.Margin = new Padding(4, 3, 4, 3);
            pnlTipoUsuario.Name = "pnlTipoUsuario";
            pnlTipoUsuario.Size = new Size(149, 37);
            pnlTipoUsuario.TabIndex = 13;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(75, 9);
            rdbInativo.Margin = new Padding(4, 3, 4, 3);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 12;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Checked = true;
            rdbAtivo.Location = new Point(9, 9);
            rdbAtivo.Margin = new Padding(4, 3, 4, 3);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 11;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Enabled = false;
            lblTipoUsuario.Location = new Point(532, 157);
            lblTipoUsuario.Margin = new Padding(4, 0, 4, 0);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(89, 15);
            lblTipoUsuario.TabIndex = 10;
            lblTipoUsuario.Text = "Tipo de Usuário";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(289, 102);
            txtConfirmarSenha.Margin = new Padding(4, 3, 4, 3);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(251, 23);
            txtConfirmarSenha.TabIndex = 4;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(19, 138);
            lblDescricao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 14;
            lblDescricao.Text = "Descrição";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(289, 83);
            lblConfirmarSenha.Margin = new Padding(4, 0, 4, 0);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(96, 15);
            lblConfirmarSenha.TabIndex = 14;
            lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(429, 46);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(298, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblEnail
            // 
            lblEnail.AutoSize = true;
            lblEnail.Location = new Point(429, 28);
            lblEnail.Margin = new Padding(4, 0, 4, 0);
            lblEnail.Name = "lblEnail";
            lblEnail.Size = new Size(41, 15);
            lblEnail.TabIndex = 8;
            lblEnail.Text = "E-mail";
            // 
            // cbxPerfil
            // 
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espirito Santo", "Goiás", "Maranhão", "Mato Grosso do Sul", "Mato Grosso", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" });
            cbxPerfil.Location = new Point(551, 102);
            cbxPerfil.Margin = new Padding(4, 3, 4, 3);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(140, 23);
            cbxPerfil.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(19, 102);
            txtSenha.Margin = new Padding(4, 3, 4, 3);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(251, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(121, 46);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(298, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(19, 46);
            txtCodigo.Margin = new Padding(4, 3, 4, 3);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(65, 23);
            txtCodigo.TabIndex = 4;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(551, 83);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(19, 83);
            lblSenha.Margin = new Padding(4, 0, 4, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(121, 28);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(19, 28);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(233, 295);
            btnCadastrar.Margin = new Padding(4, 3, 4, 3);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(271, 65);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(233, 378);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(271, 65);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 452);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(grbDadosUsuario);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmCadastroUsuario";
            Text = "Cadastro de Usuários";
            Load += FrmCadastroUsuario_Load;
            grbDadosUsuario.ResumeLayout(false);
            grbDadosUsuario.PerformLayout();
            pnlTipoUsuario.ResumeLayout(false);
            pnlTipoUsuario.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDadosUsuario;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbxPerfil;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEnail;
        private System.Windows.Forms.Panel pnlTipoUsuario;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Button btnCancelar;
    }
}