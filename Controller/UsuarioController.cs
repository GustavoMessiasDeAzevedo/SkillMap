using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillMap.Model;
using SkillMap.Repositores;
using SkillMap.View;
using SkilMaps.View;

namespace SkillMap.Controller
{
    public class UsuarioController
    {
        private FrmCadastroUsuario _frmCadastroUsuario;
        private FrmTelaPrincipal _frmTelaPrincipal;
        private UsuarioRepository _usuarioRepository;
        public UsuarioController(FrmCadastroUsuario view)
        {
            _frmCadastroUsuario = view;
            _usuarioRepository = new UsuarioRepository();
        }


        public void Salvar(Usuario usuario)
        {
            try
            {
                string confirmarSenha = _frmCadastroUsuario.SenhaConfirmacao;
                if (usuario.Senha == confirmarSenha)
                {
                    int usuarioId = _usuarioRepository.Inserir(usuario);

                    if (usuarioId > 0)
                    {
                        var habilidadeController = new HabilidadeController(_frmCadastroUsuario);
                        habilidadeController.ProcessarHabilidadesDoUsuario(usuarioId);
                        MessageBox.Show("Cadastro realizado com sucesso!!");
                    }

              
 
                }else
                {
                    MessageBox.Show("As senhas não conferem, tente novamente.");
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _usuarioRepository.Excluir(id);
                FrmTelaPerfil frmTelaPerfil = new FrmTelaPerfil();
                frmTelaPerfil.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }

        public void ListarUsuarios(string termo = "")
        {
            try
            {

                var listaUsuario = _usuarioRepository.Listar(termo);
                _frmTelaPrincipal.ExibirUsuario(listaUsuario);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao listar usuários: " + ex.Message);
            }
        }
    }
}
