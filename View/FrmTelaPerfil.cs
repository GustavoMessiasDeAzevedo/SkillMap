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
    public partial class FrmTelaPerfil : Form
    {
        private UsuarioController _usuarioController;
        public FrmTelaPerfil()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController(this);
        }

        public void FrmTelaPerfil_Load(object sender, EventArgs e)
        {

            var user = SessaoUsuario.UsuarioLogado;

            if (user == null)
            {
                MessageBox.Show("Nenhum usuário logado!");
                return;
            }

            // Preencha conforme seus campos da tela
            cbxEstado.Text = user.Localizacao;
            txtObservacaoUsuario.Text = user.Descricao;
            txtNomeUsuario.Text = user.Nome;
            txtEmailUsuario.Text = user.Email;
            txtId.Text = user.Id.ToString();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarCampos();
        }
        private void EditarCampos()
        {
            txtNomeUsuario.Enabled = true;
            txtEmailUsuario.Enabled = true;
            cbxEstado.Enabled = true;
            txtObservacaoUsuario.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void DesabilitarCampos()
        {
            txtNomeUsuario.Enabled = false;
            txtEmailUsuario.Enabled = false;
            cbxEstado.Enabled = false;
            txtObservacaoUsuario.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (SessaoUsuario.UsuarioLogado == null)
            {
                MessageBox.Show("Nenhum usuário logado para excluir.");
                return;
            }

            int id = (int)SessaoUsuario.UsuarioLogado.Id;

            var confirmar = MessageBox.Show(
                "Tem certeza que deseja excluir seu perfil? Esta ação não pode ser desfeita!",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmar == DialogResult.Yes)
            {
                UsuarioRepository repo = new UsuarioRepository();
                repo.Excluir(id);

                MessageBox.Show("Perfil excluído com sucesso!");

                SessaoUsuario.UsuarioLogado = null;

                // Fechar todas as telas e voltar para login
                FrmTelaLogin telaLogin = new FrmTelaLogin();
                telaLogin.Show();

                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario()
            {
                Nome = txtNomeUsuario.Text,
                Email = txtEmailUsuario.Text,
                Localizacao = cbxEstado.Text,
                Descricao = txtObservacaoUsuario.Text,
            };
            
            if(string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("ID do usuário não encontrado.");
                return;
            }else
            {
                usuario.Id = int.Parse(txtId.Text);
                _usuarioController.Atualizar(usuario);
                DesabilitarCampos();
            }

                
        }
    }



}
