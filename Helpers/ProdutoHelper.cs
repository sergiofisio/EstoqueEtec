using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace Estoque.Helpers
{
    public class ProdutoHelper
    {
        private readonly ClsConexao _conexao;

        public ProdutoHelper()
        {
            _conexao = new ClsConexao( );
        }

        public DataTable BuscarProduto(int cod, string dbName)
        {
            StringBuilder cmdSql = new( );
            cmdSql.Append("SELECT cod as CODIGO, description as DESCRICAO, value as VALOR, ");
            cmdSql.Append("DATE_FORMAT(expiration_date, '%d/%m/%Y') as VALIDADE ");
            cmdSql.Append("FROM products");

            if(cod > 0)
            {
                cmdSql.Append($" WHERE cod = {cod};");
            }
            else
            {
                cmdSql.Append(";");
            }

            _conexao.StrSql = cmdSql.ToString( );
            DataSet ds = _conexao.RetornarDatase(dbName);
            return ds.Tables[0];
        }

        public void InserirProduto(int cod, string desc, decimal value, long expTimestamp, string dbName)
        {
            StringBuilder cmdSql = new( );
            cmdSql.Append("INSERT INTO products ");
            cmdSql.Append("(cod, description, value, expiration_date) ");
            cmdSql.Append("VALUES (@cod, @desc, @value, FROM_UNIXTIME(@date))");

            using(MySqlConnection conn = new(_conexao.strconexao + $";database={dbName}"))
            {
                using(MySqlCommand cmd = new(cmdSql.ToString( ), conn))
                {
                    cmd.Parameters.AddWithValue("@cod", cod);
                    cmd.Parameters.AddWithValue("@desc", desc);
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.Parameters.AddWithValue("@date", expTimestamp);

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
