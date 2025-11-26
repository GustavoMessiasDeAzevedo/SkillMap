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
    public partial class FrmTelaPrincipal : Form
    {
        private UsuarioController _usuarioController;
        public FrmTelaPrincipal()
        {
            InitializeComponent();
        }

        public void ExibirUsuario(List<Usuario> usuario)
        {
            dgvPesquisaHabilidade.DataSource = usuario;
        }

        private void FrmTelaPrincipal_Load(object sender, EventArgs e)
        {
            _usuarioController.ListarUsuarios();
        }
    }
}
