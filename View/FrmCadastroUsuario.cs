using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkilMaps.View
{
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
        }


        public string SenhaConfirmacao
        {
            get { return txtConfirmarSenha.Text; }
        }

        public string habilidadeNome
        {
            get { return txtDescricao.Text; }
        }

    }
}
