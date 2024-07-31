using System;
using System.Collections.Generic;

namespace Loja.Dominio.Entidades {
    public class Produto {

        private List<Produto> _produtos;
        public Produto()
        {
            _produtos = new List<Produto>();
        }


        public List<Produto> ListarFrutasCompleta() {
            //_produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Banana", Quantidade = 5, Valor = 2, DateVencimento = DateTime.Now.AddDays(5) });
            //_produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Morango", Quantidade = 4, Valor = 25, DateVencimento = DateTime.Now.AddDays(2) });
            //_produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Pera", Quantidade = 2, Valor = 12, DateVencimento = DateTime.Now.AddDays(3) });
            //_produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Abacaxi", Quantidade = 1, Valor = 4, DateVencimento = DateTime.Now.AddDays(4) });
            //_produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Melão", Quantidade = 35, Valor = 5, DateVencimento = DateTime.Now.AddDays(10) });

            return _produtos;
        }

        public List<Produto> ListarFrutas() {

            _produtos.Add(new Produto() { Nome = "Banana", Valor = 2, Categoria = "Frutas" });
            _produtos.Add(new Produto() {  Nome = "Morango", Valor = 25, Categoria = "Frutas" });
            _produtos.Add(new Produto() {  Nome = "Pera", Valor = 12, Categoria = "Frutas" });
            _produtos.Add(new Produto() {  Nome = "Abacaxi", Valor = 4, Categoria = "Frutas" });
            _produtos.Add(new Produto() {  Nome = "Melão", Valor = 5, Categoria = "Frutas" });

            return _produtos;
        }


        public List<Produto> ListarEletronicos() {
            
            _produtos.Add(new Produto() { Nome = "IPhone", Valor = 8000, Categoria = "Eletronicos" });
            _produtos.Add(new Produto() { Nome = "Galaxy S7 Edge", Valor = 2000, Categoria = "Eletronicos" });
            _produtos.Add(new Produto() { Nome = "Pen Drive", Valor = 100, Categoria = "Eletronicos" });

            return _produtos;
        }


        //public Guid Id { get; set; }

        public string Nome { get; set; }

        //public int Quantidade {  get; set; }    

        public decimal Valor { get; set; }

        //public DateTime? DateVencimento { get; set; }

        public string Categoria { get; set; }   

    }
}
