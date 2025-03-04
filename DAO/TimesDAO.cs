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

            } catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar time! " + ex.Message);
            }
        }

        public void DeleteTime(int id)
        {
            try
            {
                string delete = "DELETE FROM times WHERE idtime = @idtime";
                MySqlCommand comando = new MySqlCommand(delete, Conexao.Conectar());
                comando.Parameters.AddWithValue("@idtime", id);
                comando.ExecuteNonQuery();
                Console.WriteLine("Time excluído com sucesso!");
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir dado do time " + ex.Message);
            }
         
        }

        public void UpdateTime(Times time)
        {
            try
            {
                string update = "UPDATE times SET nome_oficial = @nome, nome_fantasia = @nomefan, endereco = @endereco, " +
                "dt_fundacao = @dataFund, escudo = @escudo, telefone = @telefone, email = @email, estadio = @estadio " +
                "WHERE idtime = @idtime";

                MySqlCommand comando = new MySqlCommand(update,Conexao.Conectar());
                comando.Parameters.AddWithValue("@idtime", time.idtime);
                comando.Parameters.AddWithValue("@nome", time.nome_oficial);
                comando.Parameters.AddWithValue("@nomefan", time.nome_fantasia);
                comando.Parameters.AddWithValue("@endereco", time.endereco);
                comando.Parameters.AddWithValue("@datafund", time.dt_fundacao);
                comando.Parameters.AddWithValue("@escudo", time.escudo);
                comando.Parameters.AddWithValue("@telefone", time.telefone);
                comando.Parameters.AddWithValue("@email", time.email);
                comando.Parameters.AddWithValue("@estadio", time.estadio);
                

                comando.ExecuteNonQuery();
                Console.WriteLine("Time atualizado com sucesso!");
                Conexao.FecharConexao();
            }catch(Exception ex)
            {
                throw new Exception("Erro ao atualizar os dados do time " + ex.Message);
            }
        }

        public List<Times> ListaTimes()
        {
            List<Times> times = new List<Times>();

            try
            {

                var lista = "SELECT * FROM times ORDER BY nome_oficial ASC";

                MySqlCommand comando = new MySqlCommand(lista, Conexao.Conectar());
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Times time = new Times();
                        time.idtime = dr.GetInt32("idtime");
                        time.nome_oficial = dr.GetString("nome_oficial");
                        time.nome_fantasia = dr.GetString("nome_fantasia");
                        time.endereco = dr.GetString("endereco");
                        time.dt_fundacao = dr.GetDateTime("dt_fundacao");
                        time.escudo = dr.GetString("escudo");
                        time.telefone = dr.GetString("telefone");
                        time.email = dr.GetString("email");

                        times.Add(time);

                    }
                }
               

            }catch(Exception ex)
             {
                throw new Exception("Erro ao listar os times " + ex.Message);
             }
            finally
            {
                Conexao.FecharConexao();
            }
            return times;

        }
        

    }
}
