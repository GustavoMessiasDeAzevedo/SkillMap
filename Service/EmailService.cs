using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Security.AccessControl;

namespace SkillMap.Service
{
    public class EmailService
    {

        private readonly string _emailRemetente = "skillmap.projeto@gmail.com";
        private readonly string _senhaRemetente = "cbxlovqafjjyerdv";

        public void EnviarCodigo(string emailDestino, string codigo)
        {
            var smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(_emailRemetente, _senhaRemetente)
            };

            var mensagem = new MailMessage
            {
                From = new MailAddress(_emailRemetente, "SkillMap"),
                Subject = "Código de Verificação - SkillMap",
                Body = $"Olá,\n\nSeu código de verificação para recuperação de senha é: {codigo}\n\nSe você não solicitou este código, por favor ignore este email.\n\nAtenciosamente,\nEquipe SkillMap",
                
                IsBodyHtml = false,
            };

            mensagem.To.Add(emailDestino);
            smtp.Send(mensagem);
        }

    }
}
