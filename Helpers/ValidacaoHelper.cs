using Mysqlx.Crud;
using System;

namespace Estoque.Helpers
{
    public static class ValidacaoHelper
    {
        public enum TipoValidacao
        {
            Numero,
            Texto,
            Data
        }

        public class Input
        {
            public string Campo { get; set; }
            public int? Valor { get; set; }
            public DateTime? Data { get; set; }
            public string Texto { get; set; }
            public TipoValidacao Tipo { get; set; }
        }

        public static void ValidarCampos(Input[] campos)
        {
            foreach(var campo in campos)
            {
                switch(campo.Tipo)
                {
                    case TipoValidacao.Numero:
                        if(campo.Valor <= 0)
                        {
                            throw new Exception($"O campo {campo.Campo} deve ser maior que 0.");
                        }
                        break;

                    case TipoValidacao.Texto:
                        if(string.IsNullOrWhiteSpace(campo.Texto))
                        {
                            throw new Exception($"O campo {campo.Campo} não pode estar vazio.");
                        }
                        break;

                    case TipoValidacao.Data:
                        if(campo.Data <= DateTime.Now)
                        {
                            throw new Exception($"O campo {campo.Campo} deve ter uma data futura.");
                        }
                        break;

                    default:
                        throw new Exception("Tipo de validação desconhecido.");
                }
            }
        }
    }
}
