using MySql.Data.MySqlClient;
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
    public partial class frmMenucs : Form
    {
        MySqlConnection Conexao;

        public frmMenucs()
        {
            InitializeComponent();
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            frmCadartroDeProduto abrir = new frmCadartroDeProduto();
            abrir.Show();
            this.Hide();

        }

        private void btnVerProdutos_Click(object sender, EventArgs e)
        {
            frmListaDeProdutos listaDeProdutos = new frmListaDeProdutos();

            listaDeProdutos.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexaMyslq = "datasourca=localhost;username=root;password=;database=acaoedicativa";
                Conexao = new MySqlConnection(conexaMyslq);


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
