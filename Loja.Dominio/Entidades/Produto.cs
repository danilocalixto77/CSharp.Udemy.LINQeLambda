using System;

namespace Loja.Dominio.Entidades {
    public class Produto {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public int Quantidade {  get; set; }    

        public decimal Valor { get; set; }

        public DateTime? DateVencimento { get; set; }

    }
}
