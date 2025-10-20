using System;
using Microsoft.Data.SqlClient;
using SkillMap.Database;
using SkillMap.Model;
using System.Data; // Necessário para DBNull

namespace SkillMap.Repositores
{
    public class HabilidadeRepository
    {
        // NOVO MÉTODO PRINCIPAL: Orquestra a unicidade e a associação
        public void InserirUnicaEAssociar(string nomeHabilidade, int usuarioId)
        {
            // 1. Tenta buscar o ID da habilidade existente
            int habilidadeId = BuscarHabilidadeIdPorNome(nomeHabilidade);

            // 2. Se o ID for 0, a habilidade é nova e precisa ser inserida
            if (habilidadeId == 0)
            {
                habilidadeId = InserirNovaHabilidade(nomeHabilidade);
            }

            // 3. Cria a associação (relacionamento N:N)
            using (var conexao = ConexaoDB.GetConexao())
            {
                // Verifica e insere a associação. A cláusula IF NOT EXISTS previne duplicação
                // na tabela de relacionamento, caso a mesma habilidade seja processada duas vezes
                // por algum motivo (embora o Distinct no Controller já ajude).
                string sqlAssociacao = @"
                    IF NOT EXISTS (SELECT 1 FROM Habilidade_Usuarios WHERE usuario_id = @usuario_id AND habilidade_id = @habilidade_id)
                    BEGIN
                        INSERT INTO Habilidade_Usuarios (usuario_id, habilidade_id)
                        VALUES (@usuario_id, @habilidade_id)
                        SELECT SCOPE_IDENTITY();
                    END";

                using (var comando = new SqlCommand(sqlAssociacao, conexao))
                {
                    comando.Parameters.AddWithValue("@usuario_id", usuarioId);
                    comando.Parameters.AddWithValue("@habilidade_id", habilidadeId);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        // MÉTODO AUXILIAR 1: Busca o ID de uma habilidade existente
        private int BuscarHabilidadeIdPorNome(string nomeHabilidade)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT habilidade_id FROM Habilidades WHERE Nome = @Nome";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", nomeHabilidade);
                    conexao.Open();

                    var resultado = comando.ExecuteScalar();

                    // Checa se o retorno não é nulo ou DBNull
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        return Convert.ToInt32(resultado);
                    }
                    return 0; // Habilidade não encontrada
                }
            }
        }

        // MÉTODO AUXILIAR 2: Insere a nova habilidade e retorna o ID gerado (SCOPE_IDENTITY())
        private int InserirNovaHabilidade(string nomeHabilidade)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                // Inserir na tabela Habilidades e retornar o ID gerado
                string sql = @"INSERT INTO Habilidades (Nome) VALUES (@Nome); 
                               SELECT SCOPE_IDENTITY();";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", nomeHabilidade);

                    conexao.Open();

                    // ExecuteScalar retorna o valor do SCOPE_IDENTITY()
                    var novoId = comando.ExecuteScalar();

                    return Convert.ToInt32(novoId);
                }
            }
        }
    }
}