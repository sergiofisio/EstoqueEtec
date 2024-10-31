using Estoque.Helpers;
using System.Data;
using System.Text;

namespace Estoque
{
    public partial class FormProduto : BaseForm
    {
        private readonly ProdutoHelper _produtoHelper;
        private readonly ClsConexao _conexao;
        readonly StringBuilder CmdSql = new( );

        private DataSet? DS;
        DataTable? DT;

        public FormProduto()
        {
            InitializeComponent( );
            _produtoHelper = new ProdutoHelper( );
            _conexao = new ClsConexao( );
            ResetForm( );
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = int.Parse(TxtCod.Text.Trim( ));
                DT = _produtoHelper.BuscarProduto(cod, "dbestoque");

                if(cod == 0)
                {
                    if(DT.Rows.Count == 0)
                    {
                        throw new Exception("Sem produtos cadastrados!");
                    }
                    DtgTable.DataSource = DT;
                    DtgTable.Visible = true;
                }
                else
                {
                    if(DT.Rows.Count == 0)
                    {
                        throw new Exception("Produto com este codigo não encontrado. Verifique as informações e tente novamente." );
                    }
                    DtgTable.Visible=false;
                    AtualizarCamposProduto(DT.Rows[0]);
                    TxtDesc.Text = DT.Rows[0]["DESCRICAO"].ToString( );
                    decimal valor = decimal.Parse(DT.Rows[0]["VALOR"].ToString( ));
                    TxtValue.Mask = "";
                    TxtValue.Text = valor.ToString("0.00").Replace(".", ",");
                    DtpExp.Value = DateTime.ParseExact(DT.Rows[0]["VALIDADE"].ToString( ), "dd/MM/yyyy", null);
                }
                TxtDesc.Enabled = false;
                TxtValue.Enabled = false;
                DtpExp.Enabled = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ResetForm( );
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = int.Parse(TxtCod.Text.Trim( ));

                string desc = TxtDesc.Text.Trim( );

                decimal value = ConverterTextoParaValor(TxtValue.Text.Trim( ));

                DateTime expDate = DtpExp.Value;
                long expTimestamp = new DateTimeOffset(expDate).ToUnixTimeSeconds( );

                var camposParaValidar = new[]
                {
                    new ValidacaoHelper.Input { Campo = "Código", Valor = cod, Tipo = ValidacaoHelper.TipoValidacao.Numero },
                    new ValidacaoHelper.Input { Campo = "Descrição", Texto = desc, Tipo = ValidacaoHelper.TipoValidacao.Texto },
                    new ValidacaoHelper.Input { Campo = "Valor", Valor = (int)value, Tipo = ValidacaoHelper.TipoValidacao.Numero },
                    new ValidacaoHelper.Input { Campo = "Data de Validade", Data = expDate, Tipo = ValidacaoHelper.TipoValidacao.Data }
                };

                ValidacaoHelper.ValidarCampos(camposParaValidar);

                _produtoHelper.InserirProduto(cod, desc, value, expTimestamp, "dbestoque");

                MessageBox.Show("Produto incluído com sucesso!");
                ResetForm( );
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void ChangeNumber(object sender, MouseEventArgs e)
        {
            if(int.TryParse(TxtCod.Text, out int cod))
            {
                HabilitarCampos(cod > 0);
            }
            TxtDesc.Enabled = true;
            TxtDesc.Text = "";
            TxtValue.Enabled = true;
            TxtValue.Text = "";
            DtpExp.Enabled = true;
            DtpExp.Value = DateTime.Now;
        }

        private void ResetForm()
        {
            TxtCod.Text = "0";
            TxtDesc.Enabled = true;
            TxtDesc.Text = "";
            TxtValue.Enabled = true;
            TxtValue.Text = "";
            DtpExp.Enabled = true;
            DtpExp.Value = DateTime.Now;
        }

        private void HabilitarCampos(bool enable)
        {
            TxtDesc.Enabled = enable;
            TxtValue.Enabled = enable;
            TxtValue.Mask = enable ? "99999.99" : "";
            DtpExp.Enabled = enable;
        }

        private void AtualizarCamposProduto(DataRow produto)
        {
            TxtDesc.Text = produto["DESCRICAO"].ToString( );
            TxtValue.Mask = "";
            TxtValue.Text = decimal.Parse(produto["VALOR"].ToString( )).ToString("0.00").Replace(".", ",");
            DtpExp.Value = DateTime.ParseExact(produto["VALIDADE"].ToString( ), "dd/MM/yyyy", null);
        }

        private decimal ConverterTextoParaValor(string valorTexto)
        {
            valorTexto = valorTexto.Replace("_", "").Replace(",", ".");
            if(!decimal.TryParse(valorTexto, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal value))
            {
                throw new Exception("O valor inserido não é válido. Verifique e tente novamente.");
            }
            return value;
        }
    }
}
