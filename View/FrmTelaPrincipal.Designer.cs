namespace SkillMap.View
{
    partial class FrmTelaPrincipal
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
            gpbTelaInicial = new GroupBox();
            btnSair = new Button();
            btnMeuPerfil = new Button();
            dgvPesquisaHabilidade = new DataGridView();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            lblHabilidades = new Label();
            gpbTelaInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisaHabilidade).BeginInit();
            SuspendLayout();
            // 
            // gpbTelaInicial
            // 
            gpbTelaInicial.Controls.Add(btnSair);
            gpbTelaInicial.Controls.Add(btnMeuPerfil);
            gpbTelaInicial.Controls.Add(dgvPesquisaHabilidade);
            gpbTelaInicial.Controls.Add(btnPesquisar);
            gpbTelaInicial.Controls.Add(txtPesquisar);
            gpbTelaInicial.Controls.Add(lblHabilidades);
            gpbTelaInicial.Location = new Point(8, 8);
            gpbTelaInicial.Name = "gpbTelaInicial";
            gpbTelaInicial.Size = new Size(552, 352);
            gpbTelaInicial.TabIndex = 0;
            gpbTelaInicial.TabStop = false;
            gpbTelaInicial.Text = "Tela Inicial";
            // 
            // btnSair
            // 
            btnSair.Location = new Point(152, 304);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(120, 39);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnMeuPerfil
            // 
            btnMeuPerfil.Location = new Point(16, 304);
            btnMeuPerfil.Name = "btnMeuPerfil";
            btnMeuPerfil.Size = new Size(120, 39);
            btnMeuPerfil.TabIndex = 4;
            btnMeuPerfil.Text = "Meu Perfil";
            btnMeuPerfil.UseVisualStyleBackColor = true;
            btnMeuPerfil.Click += btnMeuPerfil_Click;
            // 
            // dgvPesquisaHabilidade
            // 
            dgvPesquisaHabilidade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesquisaHabilidade.Location = new Point(16, 80);
            dgvPesquisaHabilidade.MultiSelect = false;
            dgvPesquisaHabilidade.Name = "dgvPesquisaHabilidade";
            dgvPesquisaHabilidade.ReadOnly = true;
            dgvPesquisaHabilidade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPesquisaHabilidade.Size = new Size(504, 208);
            dgvPesquisaHabilidade.TabIndex = 0;
            dgvPesquisaHabilidade.CellDoubleClick += dgvPesquisaHabilidade_CellContentDoubleClick;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(400, 40);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(120, 23);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(16, 40);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(368, 23);
            txtPesquisar.TabIndex = 1;
            // 
            // lblHabilidades
            // 
            lblHabilidades.AutoSize = true;
            lblHabilidades.Location = new Point(16, 24);
            lblHabilidades.Name = "lblHabilidades";
            lblHabilidades.Size = new Size(69, 15);
            lblHabilidades.TabIndex = 0;
            lblHabilidades.Text = "Habilidades";
            // 
            // FrmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 411);
            Controls.Add(gpbTelaInicial);
            Name = "FrmTelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            FormClosed += FrmTelaPrincipal_FormClosed;
            Load += FrmTelaPrincipal_Load;
            gpbTelaInicial.ResumeLayout(false);
            gpbTelaInicial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisaHabilidade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbTelaInicial;
        private DataGridView dgvPesquisaHabilidade;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private Label lblHabilidades;
        private Button btnSair;
        private Button btnMeuPerfil;
    }
}