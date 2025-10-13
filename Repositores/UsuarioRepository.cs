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
    public class UsuarioRepository
    {

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
    }
}
