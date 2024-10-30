
namespace Estoque
{
    public partial class FormMenu : BaseForm
    {
        public FormMenu()
        {
            InitializeComponent( );
            CreateDatabaseAndTable( );
        }

        private static void CreateDatabaseAndTable()
        {
            try
            {
                var connection = new ClsConexao( );
                String[] dbTable =
                    [
                        @"
                        CREATE TABLE IF NOT EXISTS products (
                            cod INT AUTO_INCREMENT PRIMARY KEY,
                            description VARCHAR(50) NOT NULL UNIQUE,
                            value DECIMAL(10,2) NOT NULL CHECK (value >= 0),
                            expiration_date TIMESTAMP NOT NULL,
                            created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                            updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
                        );",
                        @"
                        CREATE TABLE IF NOT EXISTS movto (
                            cod_mov INT AUTO_INCREMENT PRIMARY KEY,
                            cod_prod INT NOT NULL,
                            movto_date TIMESTAMP NOT NULL,
                            movto_type ENUM('entrada', 'saida') NOT NULL,
                            qty INT NOT NULL CHECK (qty > 0),
                            info VARCHAR(255), 
                            FOREIGN KEY (cod_prod) REFERENCES products(cod),
                            updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
                        );"
                    ];
                connection.CriarBancoETabela("dbestoque", dbTable);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao criar banco de dados e tabela:\n{ex.Message}");
            }
        }

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduto produto = new( );
            produto.ShowDialog( );
        }

        private void MovimentaçãoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMovEstoque estoque = new( );
            estoque.ShowDialog( );
        }
    }
}
