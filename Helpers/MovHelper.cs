using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace Estoque.Helpers
{

    public class MovHelper
    {
        private readonly ClsConexao _conexao;
        public MovHelper()
        {
            _conexao = new ClsConexao( );
        }

        public DataTable BuscarMovto(int cod, string dbName)
        {
            StringBuilder cmdSql = new( );
            cmdSql.Append("SELECT cod_mov, cod_prod, movto_date, movto_type, qty, info ");
            cmdSql.Append("FROM movto");

            if(cod > 0)
            {
                cmdSql.Append($" WHERE cod_mov = {cod};");
            }
            else
            {
                cmdSql.Append(";");
            }

            _conexao.StrSql = cmdSql.ToString( );
            DataSet ds = _conexao.RetornarDatase(dbName);
            return ds.Tables[0];
        }

        public void InserirOuAtualizarMovimento(string type, int cod_mov, int cod_prod, long movto_date,string movto_type,int qty,string info, string dbName)
        {
            StringBuilder cmdSql = new( );
            if(type == "insert") { 
                cmdSql.Append("INSERT INTO movto ");
                cmdSql.Append("(cod_mov, cod_prod, movto_date, movto_type, qty, info) ");
                cmdSql.Append("VALUES (@cod_mov, @cod_prod, FROM_UNIXTIME(@date), @movto_type, @qty, @info )");
            }
            else
            {
                cmdSql.Append("UPDATE movto ");
                cmdSql.Append("set cod_prod=@cod_prod, movto_date=@movto_date, movto_type=@movto_type, qty=@qty, info=@info ");
                cmdSql.Append("WHERE cod_mov = @cod_mov;");
            }

            using(MySqlConnection conn = new(_conexao.strconexao + $";database={dbName}"))
            {
                using(MySqlCommand cmd = new(cmdSql.ToString( ), conn))
                {
                    cmd.Parameters.AddWithValue("@cod_mov", cod_mov);
                    cmd.Parameters.AddWithValue("@cod_prod", cod_prod);
                    cmd.Parameters.AddWithValue("@movto_date", movto_date);
                    cmd.Parameters.AddWithValue("@movto_type", movto_type);
                    cmd.Parameters.AddWithValue("@qty", qty);
                    cmd.Parameters.AddWithValue("@info", info);

                    try
                    {
                        conn.Open( );
                        cmd.ExecuteNonQuery( );
                    }
                    catch(Exception ex)
                    {
                        throw new Exception($"Erro ao incluir produto: {ex}");
                    }
                }
            }
        }

        public void DeleteMovimento(int cod_mov, string dbName)
        {
            StringBuilder cmdSql = new( );
            cmdSql.Append("DELETE FROM movto ");
            cmdSql.Append("WHERE cod_mov = @cod_mov;");

            using(MySqlConnection conn = new(_conexao.strconexao + $";database={dbName}"))
            {
                using(MySqlCommand cmd = new(cmdSql.ToString( ), conn))
                {
                    cmd.Parameters.AddWithValue("@cod_mov", cod_mov);

                    try
                    {
                        conn.Open( );
                        cmd.ExecuteNonQuery( );
                    }
                    catch(Exception ex)
                    {
                        throw new Exception($"Erro ao incluir produto: {ex.Message}");
                    }
                }
            }
        }


    }
}
