using System;
using System.Collections.Generic;
using System.Configuration;
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
                u.Id,
                u.Nome AS Nome_Usuario,
                STRING_AGG(h.Nome, ', ') AS Habilidades,
                u.Localizacao AS Estado
            FROM Usuarios u
            LEFT JOIN Habilidade_Usuarios hu ON u.id = hu.usuario_id
            LEFT JOIN Habilidades h ON h.habilidade_id = hu.habilidade_id
        ";

                sql += " GROUP BY u.Id, u.Nome, u.Localizacao ";

                if (!string.IsNullOrEmpty(termo))
                {
                    sql += @"
                HAVING 
                       u.Nome LIKE @termo
                    OR u.Localizacao LIKE @termo
                    OR STRING_AGG(h.Nome, ', ') LIKE @termo
            ";
                }

                using (var comando = new SqlCommand(sql, conexao))
                {
                    if (!string.IsNullOrEmpty(termo))
                        comando.Parameters.AddWithValue("@termo", $"%{termo}%");

                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            lista.Add(new Usuario
                            {
                                Id = Convert.ToInt32(linhas["Id"]),
                                Nome = linhas["Nome_Usuario"].ToString(),
                                Descricao = linhas["Habilidades"] == DBNull.Value ? "" : linhas["Habilidades"].ToString(),
                                Localizacao = linhas["Estado"].ToString()
                            });
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
                    INSERT INTO Usuarios (Nome, Email, Senha, Descricao, Localizacao)
                    VALUES (@Nome, @Email, @Senha, @Descricao, @Localizacao);
                    SELECT SCOPE_IDENTITY();";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                    comando.Parameters.AddWithValue("@Email", usuario.Email);
                    comando.Parameters.AddWithValue("@Senha", usuario.Senha);
                    comando.Parameters.AddWithValue("@Localizacao", usuario.Localizacao);
                    comando.Parameters.AddWithValue("@Descricao", usuario.Descricao);

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
            string connectionString = ConfigurationManager.ConnectionStrings["SkillMapDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Usuarios WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(Usuario usuario)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "UPDATE Usuarios SET nome = @nome, email = @email, descricao = @descricao, localizacao = @localizacao WHERE id = @id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", usuario.Nome);
                    comando.Parameters.AddWithValue("@email", usuario.Email);
                    comando.Parameters.AddWithValue("@descricao", usuario.Descricao);
                    comando.Parameters.AddWithValue("@localizacao", usuario.Localizacao);
                    comando.Parameters.AddWithValue("@id", usuario.Id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public  Usuario?  BuscarId(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"
            SELECT 
                u.Id,
                u.Nome,
                u.Email,
                u.Descricao,
                u.Localizacao,
                STRING_AGG(h.Nome, ', ') AS Habilidades
            FROM Usuarios u
            LEFT JOIN Habilidade_Usuarios hu ON u.Id = hu.usuario_id
            LEFT JOIN Habilidades h ON h.habilidade_id = hu.habilidade_id
            WHERE u.Id = @Id
            GROUP BY u.Id, u.Nome, u.Email, u.Descricao, u.Localizacao
        ";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    conexao.Open();

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                Id = (int)reader["Id"],
                                Nome = reader["Nome"].ToString(),
                                Email = reader["Email"].ToString(),
                                Descricao = reader["Descricao"].ToString(),
                                Localizacao = reader["Localizacao"].ToString(),
                                Habilidades = reader["Habilidades"] == DBNull.Value
                                    ? ""
                                    : reader["Habilidades"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

    }
    }
