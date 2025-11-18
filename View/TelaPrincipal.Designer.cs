namespace SkillMap.View
{
    partial class TelaPrincipal
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
            lblHabilidades = new Label();
            textBox1 = new TextBox();
            btnPesquisar = new Button();
            dgvPesquisaHabilidade = new DataGridView();
            btnMeuPerfil = new Button();
            btnSair = new Button();
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
            gpbTelaInicial.Controls.Add(textBox1);
            gpbTelaInicial.Controls.Add(lblHabilidades);
            gpbTelaInicial.Location = new Point(8, 8);
            gpbTelaInicial.Name = "gpbTelaInicial";
            gpbTelaInicial.Size = new Size(552, 352);
            gpbTelaInicial.TabIndex = 0;
            gpbTelaInicial.TabStop = false;
            gpbTelaInicial.Text = "Tela Inicial";
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
            // textBox1
            // 
            textBox1.Location = new Point(16, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 23);
            textBox1.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(400, 40);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(120, 23);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dgvPesquisaHabilidade
            // 
            dgvPesquisaHabilidade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesquisaHabilidade.Location = new Point(16, 80);
            dgvPesquisaHabilidade.Name = "dgvPesquisaHabilidade";
            dgvPesquisaHabilidade.Size = new Size(504, 208);
            dgvPesquisaHabilidade.TabIndex = 3;
            // 
            // btnMeuPerfil
            // 
            btnMeuPerfil.Location = new Point(16, 304);
            btnMeuPerfil.Name = "btnMeuPerfil";
            btnMeuPerfil.Size = new Size(120, 39);
            btnMeuPerfil.TabIndex = 4;
            btnMeuPerfil.Text = "Meu Perfil";
            btnMeuPerfil.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(152, 304);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(120, 39);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 411);
            Controls.Add(gpbTelaInicial);
            Name = "TelaPrincipal";
            Text = "FrmTelaPrincipal";
            gpbTelaInicial.ResumeLayout(false);
            gpbTelaInicial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisaHabilidade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbTelaInicial;
        private DataGridView dgvPesquisaHabilidade;
        private Button btnPesquisar;
        private TextBox textBox1;
        private Label lblHabilidades;
        private Button btnSair;
        private Button btnMeuPerfil;
    }
}