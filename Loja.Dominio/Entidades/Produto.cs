using System;
using System.Collections.Generic;

namespace Loja.Dominio.Entidades {
    public class Produto {

        private List<Produto> _produtos;
        public Produto()
        {
            _produtos = new List<Produto>();
        }

        public List<Produto> Listar() {
            _produtos.Add(new Produto() {Id = Guid.NewGuid(), Nome = "Banana", Quantidade = 5, Valor = 2, DateVencimento = DateTime.Now.AddDays(5) });
            _produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Morango", Quantidade = 4, Valor = 25, DateVencimento = DateTime.Now.AddDays(2) });
            _produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Pera", Quantidade = 2, Valor = 12, DateVencimento = DateTime.Now.AddDays(3) });
            _produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Abacaxi", Quantidade = 1, Valor = 4, DateVencimento = DateTime.Now.AddDays(4) });
            _produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Melão", Quantidade = 35, Valor = 5, DateVencimento = DateTime.Now.AddDays(10) });

            return _produtos;
        }


        public Guid Id { get; set; }

        public string Nome { get; set; }

        public int Quantidade {  get; set; }    

        public decimal Valor { get; set; }

        public DateTime? DateVencimento { get; set; }

    }
}
