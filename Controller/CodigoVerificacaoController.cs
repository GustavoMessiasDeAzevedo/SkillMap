using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using SkillMap.Model;
using SkillMap.Repositores;
using SkillMap.View;
using System.Net;
using System.Net.Mail;
using SkillMap.Service;

namespace SkillMap.Controller
{
    public class CodigoVerificacaoController
    {
        private CodigoVerificacaoRepository _codigoVerificacaoRepository;
        private  FrmAlterarSenha _frmAlterarSenha;
        private EmailService _emailService;
        public CodigoVerificacaoController(FrmAlterarSenha view)
        {
            _frmAlterarSenha = view;
            _emailService = new EmailService();
            _codigoVerificacaoRepository = new CodigoVerificacaoRepository();
        }
        private string GerarCodigo()
        {
            return new Random().Next(100000, 999999).ToString();
        }

        public void EnviarCodigo(int usuario_id, string email)
        {
            try
            {
                string codigoGerado = GerarCodigo();

                var codigo = new CodigoVerificacao
                {
                    usuario_id = usuario_id,
                    codigo = codigoGerado,
                    expira_em = DateTime.Now.AddMinutes(10),
                    usado = false
                };

                int codigoId = _codigoVerificacaoRepository.Inserir(codigo);

                _emailService.EnviarCodigo(email, codigoGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar código de verificação: " + ex.Message);
            }
        }

        public bool ValidarCodigo(int usuario_id, string codigoDigitado)
        {
            try
            {

                var codigo = _codigoVerificacaoRepository.ObterCodigoValido(usuario_id, codigoDigitado);

                if (codigo == null)
                    return false;

                _codigoVerificacaoRepository.MarcarUsado(codigo.id.Value);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar código de verificação: " + ex.Message);
                return false;
            }
        }
    }
}
