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
    public partial class frmEditarProduto : Form
    {

        MySqlConnection Conexao;
        public frmEditarProduto()
        {
            InitializeComponent();
            lstBuscar.View = View.Details;
            lstBuscar.FullRowSelect = true;
            lstBuscar.Columns.Add("Id", 30, HorizontalAlignment.Left);
            lstBuscar.Columns.Add("Nome Produto", 150, HorizontalAlignment.Left);
            lstBuscar.Columns.Add("Marca ou Modelo ", 150, HorizontalAlignment.Left);
            lstBuscar.Columns.Add("Quantidade", 150, HorizontalAlignment.Left);
           



        }

        private void btnBuscarTudo_Click(object sender, EventArgs e)
        {
            try
            {
                  
               
                
                string stringConecao = "datasource=localhost;username=root;password=;database=db_acaoeducativa";
                Conexao = new MySqlConnection(stringConecao);
                string sql = "SELECT * FROM tb_produto";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                



                MySqlDataReader reader = cmd.ExecuteReader();

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
            catch (Exception ex) {


                MessageBox.Show(ex.Message);
            }
        }

        private void lstBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBuscar.SelectedItems.Count > 0)
            {
                ListViewItem item = lstBuscar.SelectedItems[0];

                string id = item.SubItems[0].Text;
                string nomeProduto = item.SubItems[1].Text;
                string marcaModelo = item.SubItems[2].Text;
                string quantidade = item.SubItems[3].Text;

                // Exemplo: preencher campos de edição
            

                // Ou apenas exibir os dados
                // MessageBox.Show($"ID: {id}\nProduto: {nomeProduto}");
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenucs voltar = new frmMenucs();
            voltar.Show();
            this.Hide();        
        }
    }
}
