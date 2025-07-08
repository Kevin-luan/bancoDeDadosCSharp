using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Prepare;
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

    public partial class frmCadartroDeProduto : Form
    {


        MySqlConnection Conexao;
        public frmCadartroDeProduto()
        {
            InitializeComponent();
        }



        private void btnCadastraProduto_Click(object sender, EventArgs e)
        {
            string nomeProduto, marcaProduto;
            int quantidadeProduto = 0;

            nomeProduto = txtNomeProduto.Text;
            marcaProduto = txtMarcaProduto.Text;
            quantidadeProduto = int.Parse(txtQuantidade.Text);


            CadastaProduto();





        }


        public void limparCampos()
        {

            txtNomeProduto.Clear();
            txtMarcaProduto.Clear();
            txtQuantidade.Clear();
            string x = "0";

            txtQuantidade.Text = x;
            

        }


       
              
          
        
        
    public void CadastaProduto()
        {
            try
            {
                string conexaoMysql = "datasource=localhost;username=root;password=;database=db_acaoeducativa";


                Conexao = new MySqlConnection(conexaoMysql);
                string slq = " insert into tb_produto (nomeProduto, marcaProduto, quantidadeProduto) values(@nomeProduto,@marcaProduto,@quantidadeProduto)";

                MySqlCommand comando = new MySqlCommand(slq, Conexao);

                comando.Parameters.AddWithValue("@nomeProduto", txtNomeProduto.Text);
                comando.Parameters.AddWithValue("@marcaProduto", txtMarcaProduto.Text);
                comando.Parameters.AddWithValue("@quantidadeProduto", txtQuantidade.Text);

                Conexao.Open();


                comando.ExecuteNonQuery();
                limparCampos();
                MessageBox.Show("Produto cadastrado com sucesso");


            }catch (Exception ex){

                MessageBox.Show(ex.Message);
            }





        }
    }
}


