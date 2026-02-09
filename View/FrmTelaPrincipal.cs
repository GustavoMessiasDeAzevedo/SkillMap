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
    public partial class FrmTelaPrincipal : Form
    {
        private UsuarioController _usuarioController;


        public FrmTelaPrincipal()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController(this);
        }

        public void ExibirUsuario(List<ListagemUsuario> usuarios)
        {
            dgvPesquisaHabilidade.DataSource = usuarios;
        }

        private void FrmTelaPrincipal_Load(object sender, EventArgs e)
        {
            _usuarioController.ListarUsuarios();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.Trim();
            _usuarioController.ListarUsuarios(termo);
        }

        private void btnMeuPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmTelaPerfil frmTelaPerfil = new FrmTelaPerfil())
            {
                frmTelaPerfil.Show();
            }
            this.Hide();
            FrmTelaPerfil frmTelaPerfil = new FrmTelaPerfil();
            frmTelaPerfil.Show();
           
        }

        }



        private void dgvPesquisaHabilidade_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = (int)dgvPesquisaHabilidade.Rows[e.RowIndex].Cells["Id"].Value;
                FrmPerfilUsuario frmPerfilUsuario = new FrmPerfilUsuario();

                this.Hide();
                frmPerfilUsuario.Show();
                this.Close();

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            this.Close();
            Application.Restart();

        }

        private void FrmTelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
