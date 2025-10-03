using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SkillMap.Database
{
    public class ConexaoDB
    {
        public static SqlConnection GetConexao()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SkillMapDB"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}
