using GerenciamentoFutebol.Data;
using GerenciamentoFutebol.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFutebol.DAO
{
    internal class TimesDAO
    {
        public void InsertTime(Times time)
        {
            try
            {
                string sql = "INSERT INTO times(nome_oficial, nome_fantasia, endereco, dt_fundacao, escudo, telefone, email, estadio)" +
                        " VALUES(@nome_oficial, @nome_fantasia, @endereco, @dt_fundacao, @escudo, @telefone, @email, @estadio)";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome_oficial", time.nome_oficial);
                comando.Parameters.AddWithValue("@nome_fantasia", time.nome_fantasia);
                comando.Parameters.AddWithValue("@endereco", time.endereco);
                comando.Parameters.AddWithValue("@dt_fundacao", time.dt_fundacao);
                comando.Parameters.AddWithValue("@escudo", time.escudo);
                comando.Parameters.AddWithValue("@telefone", time.telefone);
                comando.Parameters.AddWithValue("@email", time.email);
                comando.Parameters.AddWithValue("@estadio", time.estadio);

                comando.ExecuteNonQuery();
                Console.WriteLine("Time cadastrado com sucesso!");
                Conexao.FecharConexao();

            }catch(Exception ex)
            {
                throw new Exception("Erro ao cadastrar time! " + ex.Message);
            }
        }
        

    }
}
