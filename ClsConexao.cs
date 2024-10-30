using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace Estoque
{
    class ClsConexao
    {
        private string _StrSql = "";
        readonly StringBuilder CmdSql = new();

        public string StrSql
        {
            get { return _StrSql; }
            set { _StrSql = value; }
        }

        public string strconexao = "datasource=localhost;username=root;password=";

        private MySqlConnection AbrirBanco(string database)
        {
            MySqlConnection Conn = new();
            Conn.ConnectionString = strconexao+ database;
            Conn.Open();
            return Conn;
        }

        private static void FecharBanco(MySqlConnection Conn)
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }

        public DataSet RetornarDatase(string dbName)
        {
            MySqlConnection conn = new();
            MySqlCommand cmd = new();
            MySqlDataAdapter DA = new();
            DataSet DS = new();

            try
            {
                conn = AbrirBanco($";database={dbName}");

                cmd.CommandText = _StrSql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                DA.SelectCommand = cmd;
                DA.Fill(DS);

                return (DS);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharBanco(conn);
            }
        }

        public MySqlDataReader RetornarDataReader(string dbName)
        {
            
            MySqlConnection conn = new();
            MySqlCommand cmd = new();

            try
            {
                conn = AbrirBanco($";database={dbName}");

                cmd.CommandText = _StrSql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ExecutarCmd(string dbName)
        {
            MessageBox.Show(dbName);
            MySqlConnection conn = new();
            MySqlCommand cmd = new();

            try
            {
                conn = AbrirBanco($";database={dbName}");
                cmd.CommandText = _StrSql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void CriarBancoETabela(string dbName, string[]dbTables)
        {
            try
            {
                using(var conn = AbrirBanco(null))
                {
                    using (var cmd = new MySqlCommand($"CREATE DATABASE IF NOT EXISTS {dbName};", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    conn.ChangeDatabase(dbName);

                    CmdSql.Clear();
                    
                    foreach (var query in dbTables)
                    {
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating database and table: " + ex.Message);
            }
        }
    }
}
