using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SkillMap.Database;
using SkillMap.Model;

namespace SkillMap.Repositores
{
    public class UsuarioRepository
    {

        public List<Usuario> Listar(string termo = "")
        {
            var lista = new List<Usuario>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"
            SELECT 
                u.Nome AS Nome_Usuario,
                STRING_AGG(h.Nome, ', ') AS Habilidades,
                u.Localizacao AS Estado
            FROM Usuarios u
                LEFT JOIN UsuarioHabilidades uh ON u.Id = uh.UsuarioId
                LEFT JOIN Habilidades h ON h.Id = uh.HabilidadeId";

                if (!string.IsNullOrEmpty(termo))
                {
                    sql += @"
                    GROUP BY u.Id, u.Nome, u.Localizacao
                    HAVING 
                    u.Nome LIKE @termo
                    OR u.Localizacao LIKE @termo
                    OR STRING_AGG(h.Nome, ', ') LIKE @termo";
                }
                else
                {
                    sql += " GROUP BY u.Id, u.Nome, u.Localizacao ";
                }

                using (var comando = new SqlCommand(sql, conexao))
                {
                    if(!string.IsNullOrEmpty(termo))
                    {
                        comando.Parameters.AddWithValue("@termo", $"%{termo}%");
                    }

                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while(linhas.Read())
                        {
                            var usuario = new Usuario
                            {
                                Nome = linhas["Nome_Usuario"].ToString(),
                                Descricao = linhas["Habilidades"].ToString(),
                                Localizacao = linhas["Estado"].ToString()
                            };
                            lista.Add(usuario);
                        }
                    }


                }
            }

            return lista;
        }


        public int Inserir(Usuario usuario)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"
                    INSERT INTO Usuarios (Nome, Email, Senha, Descricao, Localizacao, tipo_usuario)
                    VALUES (@Nome, @Email, @Senha, @Descricao, @Localizacao, @tipo_usuario);
                    SELECT SCOPE_IDENTITY();";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                    comando.Parameters.AddWithValue("@Email", usuario.Email);
                    comando.Parameters.AddWithValue("@Senha", usuario.Senha);
                    comando.Parameters.AddWithValue("@Localizacao", usuario.Localizacao);
                    comando.Parameters.AddWithValue("@Descricao", usuario.Descricao);
                    comando.Parameters.AddWithValue("@tipo_usuario", usuario.tipo_usuario);
                    conexao.Open();

                    var resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        return Convert.ToInt32(resultado);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "DELETE FROM Usuarios WHERE Id = @Id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }                                                                                                                                                                              
}
