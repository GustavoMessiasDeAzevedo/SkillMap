using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SkillMap.Model;
using SkilMaps.View;

namespace SkillMap.View
{
    public partial class FrmTelaLogin : Form
    {
        private FrmTelaInicial frmTelaInicial;
        public FrmTelaLogin()
        {
            InitializeComponent();
            frmTelaInicial = new FrmTelaInicial();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha e-mail e senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["SkillMapDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"SELECT Id, Nome, Email, Senha, Localizacao, Descricao
                 FROM Usuarios
                 WHERE email = @Email AND senha = @Senha";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Usuario usuario = new Usuario
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Email = reader.GetString(2),
                            Senha = reader.GetString(3),
                            Localizacao = reader.IsDBNull(4) ? "" : reader.GetString(4),
                            Descricao = reader.IsDBNull(5) ? "" : reader.GetString(5),

                        };

                        SessaoUsuario.UsuarioLogado = usuario;

                        this.Hide();
                        FrmTelaPrincipal frmTelaPrincipal = new FrmTelaPrincipal();
                        frmTelaPrincipal.ShowDialog();


                    }
                    else
                    {
                        MessageBox.Show("E-mail ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar: " + ex.Message);
                }
            }
        }

        private void btnCadastrase_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario frmCadastro = new FrmCadastroUsuario();
            frmCadastro.Show();
        }

        private void FrmTelaLogin_Load(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void FrmTelaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAlterarSenha frmAlterarSenha = new FrmAlterarSenha();
            frmAlterarSenha.Show();
        }
    }
}

