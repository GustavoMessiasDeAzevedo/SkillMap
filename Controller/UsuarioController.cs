using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillMap.Model;
using SkillMap.Repositores;
using SkilMaps.View;

namespace SkillMap.Controller
{
    public class UsuarioController
    {
        private FrmCadastroUsuario _frmCadastroUsuario;
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
                    //int usuarioId = _usuarioRepository.Inserir(usuario);

                    //var habilidadeController = new HabilidadeController(_frmCadastroUsuario);
                    //habilidadeController.ProcessarHabilidadesDoUsuario(usuarioId);
                    _usuarioRepository.Inserir(usuario);
                    MessageBox.Show("Cadastro realizado com sucesso!!");
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
    }
}
