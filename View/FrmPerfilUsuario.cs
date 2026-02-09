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
using SkillMap.Repositores;

namespace SkillMap.View
{
    public partial class FrmPerfilUsuario : Form
    {
        private UsuarioController _usuarioController;

        private int? _usuarioId;
        public FrmPerfilUsuario()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController(this);
        }

        private void FrmPerfilUsuario_Load(object sender, EventArgs e)
        {
            CarregarDadosDoUsuario();
            BloquearCampos();

            if (_usuarioId.HasValue)
            {
                var usuario = _usuarioController.BuscarPerfilPorId(_usuarioId.Value);
            }


        }

        private void CarregarDadosDoUsuario()
        {
            var usuario = SessaoUsuario.UsuarioLogado;

            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            cbxEstado.SelectedItem = usuario.Localizacao;
            txtObservacao.Text = usuario.Descricao;
        }

        private void BloquearCampos()
        {
            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            cbxEstado.Enabled = false;
            txtObservacao.ReadOnly = true;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTelaPrincipal frmTelaPrincipal = new FrmTelaPrincipal();
            frmTelaPrincipal.Show();
        }

        private void FrmPerfilUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
