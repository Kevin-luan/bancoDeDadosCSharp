using Microsoft.SqlServer.Server;
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

            lstBuscar.View = View.Details;
            lstBuscar.Columns.Add("Id", 30,HorizontalAlignment.Left);
            lstBuscar.Columns.Add("Nome Produto", 150, HorizontalAlignment.Left);
            lstBuscar.Columns.Add("Marca ou Modelo ", 150, HorizontalAlignment.Left);
            lstBuscar.Columns.Add("Quantidade", 150, HorizontalAlignment.Left);


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
                string busca = "'%" + txtBuscar.Text + "+'";
               


                string conexaoMyslq = "datasource=localhost;username=root;password=;database=db_acaoeducativa";

                Conexao = new MySqlConnection(conexaoMyslq);
                // string sql = "select * from tb_produto where nomeProduto= " + busca  ;
                string sql = "SELECT * FROM tb_produto WHERE nomeProduto LIKE @nome";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                comando.Parameters.AddWithValue("@nome", "%" + txtBuscar.Text + "%");
                Conexao.Open();
           

                MySqlDataReader reader = comando.ExecuteReader();
                lstBuscar.Items.Clear();


                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3).ToString(),
                    };

                    
                    var linha = new ListViewItem(row);
                    lstBuscar.Items.Add(linha);
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }   
        }
    }
}
