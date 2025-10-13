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

namespace SkilMaps.View
{
    public partial class FrmCadastroUsuario : Form
    {
        private UsuarioController _usuarioController;
        public FrmCadastroUsuario()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController(this);
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario()
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Descricao = txtDescricao.Text,
                Senha = txtSenha.Text,
                Localizacao = cbxPerfil.Text,
                tipo_usuario = rdbAtivo.Checked
            };
            _usuarioController.Salvar(usuario);
        }

        public string SenhaConfirmacao
        {
            get { return txtConfirmarSenha.Text; }
        }

        public string habilidadeNome
        {
            get { return txtDescricao.Text; }
        }

    }
}
