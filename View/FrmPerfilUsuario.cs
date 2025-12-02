using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkillMap.Model;
using SkillMap.Repositores;

namespace SkillMap.View
{
    public partial class FrmPerfilUsuario : Form
    {
        UsuarioRepository usuarioRepository = new UsuarioRepository();
        public FrmPerfilUsuario()
        {
            InitializeComponent();
        }

        private void FrmPerfilUsuario_Load(object sender, EventArgs e)
        {
            CarregarDadosDoUsuario();
            BloquearCampos();
        }

        private void CarregarDadosDoUsuario()
        {
            var usuario = SessaoUsuario.UsuarioLogado;

            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            cbxEstado.SelectedItem = usuario.Estado;
            txtObservacao.Text = usuario.Observacao;
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
    }
}
