using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkillMap.Controller;
using SkillMap.Model;

namespace SkillMap.View
{
    public partial class FrmAlterarSenha : Form
    {
        private UsuarioController _usuarioController;
        public FrmAlterarSenha()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController(this);
        }

        public string ValidarEmail
        {
            get { return txtEmailAlterarSenha.Text; }
        }

        private void btnValidarEmail_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario? usuario = _usuarioController.BuscarPorEmail(ValidarEmail);
                if (txtEmailAlterarSenha.Text == usuario.Email)
                {
                    btnAlterarSenha.Enabled = true;
                    txtNovaSenha.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar email: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            _usuarioController.AlterarSenha(ValidarEmail, txtNovaSenha.Text);
            
        }
    }
}
