using SkillMap.Model;
using SkillMap.Repositores;
using SkillMap.View;
using SkilMaps.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SkillMap.Controller
{
    public class UsuarioController
    {
        private FrmCadastroUsuario _frmCadastroUsuario;
        private FrmTelaPrincipal _frmTelaPrincipal;
        private FrmTelaPerfil _frmTelaPerfil;
        private UsuarioRepository _usuarioRepository;

        // Construtor para Cadastro
        public UsuarioController(FrmCadastroUsuario view)
        {
            _frmCadastroUsuario = view;
            _usuarioRepository = new UsuarioRepository();
        }

        // Construtor para Tela Principal
        public UsuarioController(FrmTelaPrincipal view)
        {
            _frmTelaPrincipal = view;
            _usuarioRepository = new UsuarioRepository();
        }

        // Construtor para Tela de Perfil (para poder excluir)
        public UsuarioController(FrmTelaPerfil view)
        {
            _frmTelaPerfil = view;
            _usuarioRepository = new UsuarioRepository();
        }

        // ===== SALVAR =====
        public void Salvar(Usuario usuario)
        {
            try
            {
                if (_frmCadastroUsuario == null)
                {
                    MessageBox.Show("Salvar só pode ser feito pela tela de cadastro.");
                    return;
                }

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
                }
                else
                {
                    MessageBox.Show("As senhas não conferem, tente novamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        // ===== EXCLUIR =====
        public void Excluir(int id)
        {
            try
            {
                _usuarioRepository.Excluir(id);

                if (_frmTelaPerfil != null)
                {
                    // Fecha a tela real que está aberta
                    _frmTelaPerfil.Close();
                }

                MessageBox.Show("Usuário excluído com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }

        // ===== LISTAR =====
        public void ListarUsuarios(string termo = "")
        {
            try
            {
                if (_frmTelaPrincipal == null)
                    return;

                var listaUsuario = _usuarioRepository.Listar(termo);

                var listaDataGridView = listaUsuario.Select(u => new ListagemUsuario
                {
                    Nome = u.Nome,
                    Habilidades = u.Descricao,
                    Estado = u.Localizacao
                }).ToList();

                _frmTelaPrincipal.ExibirUsuario(listaDataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar usuários: " + ex.Message);
            }
        }

        public void Atualizar(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Atualizar(usuario);
                MessageBox.Show("Usuário atualizado com sucesso.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }
    }
}
