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
    public class HabilidadeController
    {
        private FrmCadastroUsuario _frmCadastroUsuario;
        private HabilidadeRepository _habilidadeRepository;


        public HabilidadeController(FrmCadastroUsuario view)
        {
            _frmCadastroUsuario = view;
            _habilidadeRepository = new HabilidadeRepository();
        }

        

        // MÉTODO CORRIGIDO: Agora recebe o ID do usuário
        public void ProcessarHabilidadesDoUsuario(int usuarioId)
        {
            try
            {
                // ATENÇÃO: Verifique se 'habilidadeNome' é o nome correto da propriedade pública na sua View!
                string habilidadesTexto = _frmCadastroUsuario.habilidadeNome;

                if (string.IsNullOrWhiteSpace(habilidadesTexto)) return;

                var habilidadesSalvar = habilidadesTexto.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(h => h.Trim().ToLowerInvariant()) // Padronização OK!
                    .Where(h => !string.IsNullOrWhiteSpace(h))
                    .Distinct()
                    .ToList();


                foreach (var nomeHabilidade in habilidadesSalvar)
                {
                    // CHAMADA CORRETA: Chama o método que faz a unicidade E a associação
                    _habilidadeRepository.InserirUnicaEAssociar(nomeHabilidade, usuarioId);
                }
                // Geralmente a mensagem de sucesso fica no UsuarioController
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar habilidades: " + ex.Message);
            }
        }
    }
}