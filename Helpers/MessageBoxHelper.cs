namespace Estoque.Helpers
{
    internal class MessageBoxHelper
    {
        public DialogResult CriarMessageBox(string mensagem, string tipo, MessageBoxButtons botoes, MessageBoxIcon icone)
        {
            return MessageBox.Show(mensagem, tipo, botoes, icone);
        }
    }
}
