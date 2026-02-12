using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SkillMap.Database;
using SkillMap.Model;

namespace SkillMap.Repositores
{
    public class CodigoVerificacaoRepository
    {

        public int Inserir(CodigoVerificacao codigo)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"INSERT INTO CodigoVerificacao (usuario_id, codigo, expira_em, usado) 
                  VALUES (@usuario_id, @codigo, @expira_em, @usado); 
                  SELECT SCOPE_IDENTITY();";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@usuario_id", codigo.usuario_id);
                    comando.Parameters.AddWithValue("@codigo", codigo.codigo);
                    comando.Parameters.AddWithValue("@expira_em", codigo.expira_em);
                    comando.Parameters.AddWithValue("@usado", codigo.usado);

                    conexao.Open();

                    int idGerado = Convert.ToInt32(comando.ExecuteScalar());
                    return idGerado;
                }
            }
        }

        public CodigoVerificacao? ObterCodigoValido(int usuarioId, string codigo)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"SELECT TOP 1 * FROM CodigoVerificacao 
                           WHERE usuario_id = @usuario_id 
                             AND codigo = @codigo 
                             AND expira_em > GETDATE() 
                             AND usado = 0";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@usuario_id", usuarioId);
                    comando.Parameters.AddWithValue("@codigo", codigo);

                    conexao.Open();

                    using (var codigoReader = comando.ExecuteReader())
                    {
                        if (!codigoReader.Read())
                            return null;

                        return new CodigoVerificacao
                        {
                            id = codigoReader.GetInt32(0),
                            usuario_id = codigoReader.GetInt32(1),
                            codigo = codigoReader.GetString(2),
                            expira_em = codigoReader.GetDateTime(3),
                            usado = codigoReader.GetBoolean(4)

                        };
                    }
                }
            }
        }

        public void MarcarUsado(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"UPDATE CodigoVerificacao SET usado = 1 WHERE id = @id";

                using(var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
