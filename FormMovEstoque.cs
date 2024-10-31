using Estoque.Helpers;
using System.Data;
using System.Text;

namespace Estoque
{
    public partial class FormMovEstoque : BaseForm
    {
        private readonly ProdutoHelper _produtoHelper;
        private readonly MovHelper _movtoHelper;
        private readonly ClsConexao _conexao;
        private readonly MessageBoxHelper _messageBoxHelper;
        readonly StringBuilder CmdSql = new( );

        private DataSet? DS;
        DataTable? DT;

        int cod_prod = 0, cod_mov = 0, qty = 0;
        string movType = "", obs = "";

        bool pesquisa = false;

        public FormMovEstoque()
        {
            InitializeComponent( );
            _conexao = new ClsConexao( );
            _produtoHelper = new ProdutoHelper( );
            _movtoHelper = new MovHelper( );
            _messageBoxHelper = new MessageBoxHelper( );
            ResetForm( );
        }

        private void ResetForm()
        {
            TxtCodMov.Text = "0";
            TxtCodProd.Text = "0";
            TxtQty.Text = "0";
            RdbIn.Checked = false;
            RdbOut.Checked = false;
            TxtObs.Text = "";
        }

        private void ShowProdName(int cod)
        {
            try
            {
                

                if(cod > 0)
                {
                    DT = _produtoHelper.BuscarProduto(cod, "dbestoque");

                    if(DT.Rows.Count == 0)
                    {
                        lblDesc.Text = "Sem produtos com este código";
                    }
                    else
                    {
                        lblDesc.Text = DT.Rows[0]["DESCRICAO"].ToString( )?.ToUpper( );
                    }
                }
            }
            catch(Exception ex)
            {
                _messageBoxHelper.CriarMessageBox(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CodProdChange(object sender, EventArgs e)
        {
            int cod = int.Parse(TxtCodProd.Text.Trim( ));

            ShowProdName(cod);
        }

        private void BtnInclude_Click(object sender, EventArgs e)
        {
            try
            {
                cod_mov = int.Parse(TxtCodMov.Text);
                cod_prod = int.Parse(TxtCodProd.Text);
                qty = int.Parse(TxtQty.Text);
                DateTime mov_date = DtpMov.Value;
                long date = new DateTimeOffset(mov_date).ToUnixTimeSeconds( );

                if(RdbIn.Checked)
                {
                    movType = "entrada";
                }

                if(RdbOut.Checked)
                {
                    movType = "saida";
                }

                obs = TxtObs.Text;

                var camposParaValidar = new[]
                {
                    new ValidacaoHelper.Input { Campo = "Código Movimentação", Valor = cod_mov, Tipo = ValidacaoHelper.TipoValidacao.Numero },
                    new ValidacaoHelper.Input { Campo = "Código Produto", Valor = cod_prod, Tipo = ValidacaoHelper.TipoValidacao.Numero },
                    new ValidacaoHelper.Input { Campo = "Quantidade", Valor = (int)qty, Tipo = ValidacaoHelper.TipoValidacao.Numero },
                    new ValidacaoHelper.Input { Campo = "Tipo de Movimentação", Texto = movType, Tipo = ValidacaoHelper.TipoValidacao.Texto }
                };

                ValidacaoHelper.ValidarCampos(camposParaValidar);

                _movtoHelper.InserirOuAtualizarMovimento("insert", cod_mov, cod_prod, date, movType, qty, obs, "dbestoque");

                _messageBoxHelper.CriarMessageBox("Registro criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm( );
            }
            catch(Exception ex)
            {
                _messageBoxHelper.CriarMessageBox(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!pesquisa)
                {
                    throw new Exception("Faça a pesquisa da movimentação primeiro");
                }

                int codMovAtual = int.Parse(TxtCodMov.Text);
                int codProdAtual = int.Parse(TxtCodProd.Text);
                int qtyAtual = int.Parse(TxtQty.Text);
                DateTime movDateAtual = DtpMov.Value;
                long dateAtual = new DateTimeOffset(movDateAtual).ToUnixTimeSeconds( );
                string movTypeAtual = RdbIn.Checked ? "entrada" : (RdbOut.Checked ? "saida" : "");
                string obsAtual = TxtObs.Text != null ? TxtObs.Text : "";

                var camposParaValidar = new[]
                {
                    new ValidacaoHelper.Input { Campo = "Código Movimentação", Valor = codMovAtual, Tipo = ValidacaoHelper.TipoValidacao.Numero },
                    new ValidacaoHelper.Input { Campo = "Código Produto", Valor = codProdAtual, Tipo = ValidacaoHelper.TipoValidacao.Numero },
                    new ValidacaoHelper.Input { Campo = "Quantidade", Valor = qtyAtual, Tipo = ValidacaoHelper.TipoValidacao.Numero },
                    new ValidacaoHelper.Input { Campo = "Tipo de Movimentação", Texto = movTypeAtual, Tipo = ValidacaoHelper.TipoValidacao.Texto }
                };

                ValidacaoHelper.ValidarCampos(camposParaValidar);

                DT = _movtoHelper.BuscarMovto(codMovAtual, "dbestoque");

                if(DT == null || DT.Rows.Count == 0) throw new Exception("Movimentação não encontrada.");

                int codProdBanco = int.Parse(DT.Rows[0]["cod_prod"].ToString( ));
                int qtyBanco = int.Parse(DT.Rows[0]["qty"].ToString( ));
                DateTime movDateBanco = DateTime.Parse(DT.Rows[0]["movto_date"].ToString( ));
                string movTypeBanco = DT.Rows[0]["movto_type"].ToString( );
                string obsBanco = DT.Rows[0]["info"].ToString( );

                bool houveAlteracao =
                    codProdAtual != codProdBanco ||
                    qtyAtual != qtyBanco ||
                    movDateAtual != movDateBanco ||
                    movTypeAtual != movTypeBanco ||
                    obsAtual != obsBanco;

                if(houveAlteracao)
                {
                    _movtoHelper.InserirOuAtualizarMovimento("update", codMovAtual, codProdAtual, dateAtual, movTypeAtual, qtyAtual, obsAtual, "dbestoque");
                    _messageBoxHelper.CriarMessageBox("Registro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _messageBoxHelper.CriarMessageBox("Nenhuma alteração detectada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ResetForm( );
            }
            catch(Exception ex)
            {
                _messageBoxHelper.CriarMessageBox(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                cod_mov = int.Parse(TxtCodMov.Text);

                var camposParaValidar = new[]
                {
                    new ValidacaoHelper.Input { Campo = "Código Movimentação", Valor = cod_mov, Tipo = ValidacaoHelper.TipoValidacao.Numero }
                };

                ValidacaoHelper.ValidarCampos(camposParaValidar);

                DT = _movtoHelper.BuscarMovto(cod_mov, "dbestoque");

                if(DT.Rows.Count == 0)
                {
                    throw new Exception("Movimentação não encontrada");
                }

                
                TxtCodProd.Text = DT.Rows[0]["cod_prod"].ToString( );
                TxtQty.Text = DT.Rows[0]["qty"].ToString( );
                DtpMov.Value = DateTime.Parse(DT.Rows[0]["movto_date"].ToString( ));


                if(DT.Rows[0]["movto_type"].ToString( ) == "entrada")
                {
                    RdbIn.Checked = true;
                }
                else
                {
                    RdbOut.Checked = true;
                }

                if(DT.Rows[0]["info"] != null)
                {
                    TxtObs.Text = DT.Rows[0]["info"]?.ToString( ) ??"";
                }

                ShowProdName(int.Parse(DT.Rows[0]["cod_prod"].ToString( )));

                pesquisa = true;
            }
            catch(Exception ex)
            {
                ResetForm( );
                _messageBoxHelper.CriarMessageBox(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
            if(!pesquisa)
            {
                throw new Exception("Faça a pesquisa da movimentação primeiro");
            }

                var result = CriarMessageBox("Confirma a exclusão da movimentação?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    _movtoHelper.DeleteMovimento(cod_mov, "dbestoque");
                    _messageBoxHelper.CriarMessageBox("Movimentação excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }catch(Exception ex)
            {
                _messageBoxHelper.CriarMessageBox(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DialogResult CriarMessageBox(string mensagem, string tipo, MessageBoxButtons botoes, MessageBoxIcon icone)
        {
            return MessageBox.Show(mensagem, tipo, botoes, icone);
        }
    }
}
