using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace acaoEducativa
{
    public class ConexaoCombancoDeDados
    {
        MySqlConnection Conexao;
        public string servidor = "localhost";
        public string baseDeDados = "db_acaoeducativa";
        public string username = "root";
        public string senha = "";

        public string stringConexao;

        public ConexaoCombancoDeDados()
        {

            stringConexao = $"Server={servidor};Database={baseDeDados};User Id={username};Password={senha}";
            Conexao = new MySqlConnection(stringConexao);
        }



        

    public void AbrirConexao()
        {
            Conexao.Open();
            
        }

        public void CloseConexao()
        {
            Conexao.Close();
        }

    }
}
