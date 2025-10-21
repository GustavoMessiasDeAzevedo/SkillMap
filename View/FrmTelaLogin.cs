using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SkilMaps.View;

namespace SkillMap.View
{
    public partial class FrmTelaLogin : Form
    {
        public FrmTelaLogin()
        {
            InitializeComponent();
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

            string connectionString = "Server=MAR0625665W10-1;Database=SkillMap;User Id=sa;Password=senac2025;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE email = @Email AND senha = @Senha";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login realizado com sucesso!");

                        
                        TelaPrincipal frm = new TelaPrincipal();
                        frm.Show();

                        
                        this.Hide();
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
            frmCadastro.ShowDialog();
        }
    }
}

