using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMap.Model
{
    public class Usuario
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? Localizacao { get; set; }
        public string? Descricao { get; set; }
        public string?  WhatsApp {  get; set; }

        public string? SenhaHash {  get; set; }
        public string? SenhaSalt {  get; set; }

        public string? Habilidades { get; set; }
    }
}
