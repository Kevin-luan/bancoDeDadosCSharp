using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acaoEducativa
{
    public partial class frmCadastrarColaborador : Form
    {
        public frmCadastrarColaborador()
        {
            InitializeComponent();
        }

        private void btnCadastrarColaborador_Click(object sender, EventArgs e)
        {
            ConexaoCombancoDeDados conexao = new ConexaoCombancoDeDados();

            try
            {
                conexao.AbrirConexao();
                MessageBox.Show("conexao OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
