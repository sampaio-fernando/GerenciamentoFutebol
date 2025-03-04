using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFutebol.Data
{
    public static class Conexao
    {
        static MySqlConnection conexao;

        public static MySqlConnection Conectar()
        {
            try
            {
                string strconexao = "server=localhost;port=3306;uid=root;pwd=root;database=timeFutebol";
                conexao = new MySqlConnection(strconexao);
                conexao.Open();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao realizar a conexão com o banco de dados " + ex);
            }
            return conexao;
        }

        public static void FecharConexao()
        {
            conexao.Close();
        }
        
    }  
    
}
