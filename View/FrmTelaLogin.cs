using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SkillMap.Controller;
using SkillMap.Model;
using SkilMaps.View;

namespace SkillMap.View
{
    public partial class FrmTelaLogin : Form
    {
        private Form _frmTelaInicial;
        private UsuarioController _usuarioController;
        public FrmTelaLogin(Form frmTelaInicial)
        {
            InitializeComponent();
            _frmTelaInicial = frmTelaInicial;
            _usuarioController = new UsuarioController(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha e-mail e senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _usuarioController.Login(email, senha);
        }

        private void btnCadastrase_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario frmCadastro = new FrmCadastroUsuario(_frmTelaInicial);
            frmCadastro.Show();
            this.Close();
        }

        private void FrmTelaLogin_Load(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAlterarSenha frmAlterarSenha = new FrmAlterarSenha();
            frmAlterarSenha.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmTelaInicial.Show();
        }
    }
}

