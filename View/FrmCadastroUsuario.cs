using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkillMap;
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
              
            };
            _usuarioController.Salvar(usuario);
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            this.Hide();
            FrmTelaInicial frmTelaInicial = new FrmTelaInicial();
            frmTelaInicial.Show();
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
