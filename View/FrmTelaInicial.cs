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
using SkillMap.Database;
using SkillMap.View;
using SkilMaps.View;

namespace SkillMap
{
    public partial class FrmTelaInicial : Form
    {
        public FrmTelaInicial()
        {
            InitializeComponent();
        }

       
            
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario frmCadastro = new FrmCadastroUsuario();
            frmCadastro.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Show();
            FrmTelaLogin frmLogin = new FrmTelaLogin();
            frmLogin.Show();
            this.Hide();
        }


    }
}
