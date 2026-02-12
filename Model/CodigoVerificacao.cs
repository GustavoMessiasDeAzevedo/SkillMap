using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMap.Model
{
    public class CodigoVerificacao
    {
        public int? id { get; set; }
        public int? usuario_id { get; set; }
        public string? codigo { get; set; }
        public DateTime? expira_em { get; set; }
        public bool usado { get; set; }

    }
}
