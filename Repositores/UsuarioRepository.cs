using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Microsoft.Data.SqlClient;
using SkillMap.Database;
using SkillMap.Model;
using SkillMap.View;

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
                    INSERT INTO Usuarios (Nome, Email, senha_hash, senha_salt, Descricao, Localizacao, WhatsApp)
                    VALUES (@Nome, @Email, @Hash, @Salt, @Descricao, @Localizacao, @whatsapp);
                    SELECT SCOPE_IDENTITY();";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                    comando.Parameters.AddWithValue("@Email", usuario.Email);
                    comando.Parameters.AddWithValue("@Hash", usuario.SenhaHash);
                    comando.Parameters.AddWithValue("@Salt", usuario.SenhaSalt);
                    comando.Parameters.AddWithValue("@Localizacao", usuario.Localizacao);
                    comando.Parameters.AddWithValue("@Descricao", usuario.Descricao);
                    comando.Parameters.AddWithValue("@whatsApp",usuario.WhatsApp ?? "");

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
                string sql = "UPDATE Usuarios SET nome = @nome, email = @email, descricao = @descricao, localizacao = @localizacao, WhatsApp = @whatsapp WHERE id = @id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", usuario.Nome);
                    comando.Parameters.AddWithValue("@email", usuario.Email);
                    comando.Parameters.AddWithValue("@descricao", usuario.Descricao);
                    comando.Parameters.AddWithValue("@localizacao", usuario.Localizacao);
                    comando.Parameters.AddWithValue("@whatsapp", usuario.WhatsApp ?? "");
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
                u.WhatsApp,
                STRING_AGG(h.Nome, ', ') AS Habilidades
            FROM Usuarios u
            LEFT JOIN Habilidade_Usuarios hu ON u.Id = hu.usuario_id
            LEFT JOIN Habilidades h ON h.habilidade_id = hu.habilidade_id
            WHERE u.Id = @Id
            GROUP BY u.Id, u.Nome, u.Email, u.Descricao, u.Localizacao, u.WhatsApp
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
                                WhatsApp = reader["WhatsApp"] == DBNull.Value ? "" : reader["WhatsApp"].ToString(),
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

        public void AlterarSenha(string email, string hash, string salt)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"UPDATE Usuarios SET senha_hash = @hash, senha_salt = @salt WHERE email = @email";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@hash", hash);
                    comando.Parameters.AddWithValue("@salt", salt);
                    comando.Parameters.AddWithValue("@email", email);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public Usuario? BuscarPorEmail(string email)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"SELECT Id, email FROM Usuarios";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["email"].ToString() == email)
                            {
                                return new Usuario
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Email = reader["email"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            return null;
        }


        public Usuario? BuscarParaLogin(string email)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SkillMapDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = @"SELECT Id, Nome, Email, senha_hash, senha_salt, Localizacao, Descricao
                 FROM Usuarios
                 WHERE email = @Email";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Email = reader.GetString(2),
                                SenhaHash = reader.GetString(3),
                                SenhaSalt = reader.GetString(4),
                                Localizacao = reader.IsDBNull(5) ? "" : reader.GetString(5),
                                Descricao = reader.IsDBNull(6) ? "" : reader.GetString(6)
                            };
                        }
                    }
                }
            }

            return null;
           
        }

    }
}


//SessaoUsuario.UsuarioLogado = usuario;

//this.Hide();
//FrmTelaPrincipal frmTelaPrincipal = new FrmTelaPrincipal();
//frmTelaPrincipal.ShowDialog();
