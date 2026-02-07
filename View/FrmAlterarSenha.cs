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

                if (usuario == null)
                {
                    MessageBox.Show("Email não encontrado");
                    return;
                }

                var codigoController = new CodigoVerificacaoController(null);
                codigoController.EnviarCodigo(usuario.Id.Value, usuario.Email);

                txtCodigo.Enabled = true;

                MessageBox.Show("Código enviado para o email cadastrado. Por favor, verifique sua caixa de entrada.");

                txtNovaSenha.Enabled = true;
                btnAlterarSenha.Enabled = true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o código: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {

            try
            {
                Usuario? usuario = _usuarioController.BuscarPorEmail(ValidarEmail);

                if (usuario == null)
                {
                    MessageBox.Show("Usuario não encontrado");
                    return;
                }

                var codigoController = new CodigoVerificacaoController(null);

                bool codigoValido = codigoController.ValidarCodigo(usuario.Id.Value, txtCodigo.Text);

                if (!codigoValido)
                {
                    MessageBox.Show("Código de verificação inválido ou expirado. Por favor, tente novamente.");
                    return;
                }

                if (string.IsNullOrEmpty(txtNovaSenha.Text))
                {
                    MessageBox.Show("A nova senha não pode ser vazia. Por favor, insira uma nova senha.");
                    return;
                }

                _usuarioController.AlterarSenha(ValidarEmail, txtNovaSenha.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar a senha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
