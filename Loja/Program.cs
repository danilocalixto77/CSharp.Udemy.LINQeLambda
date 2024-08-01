using Loja.Dominio.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja {
    internal class Program {
        static void Main(string[] args) {

            //var produto = new Produto();

            //var produtos = produto.Listar().Where(p => p.Valor >4);

            //foreach(Produto p in produtos) {
            //    Console.WriteLine(p.Nome);
            //}
            //Console.ReadKey();

            //Uma forma reduzida
            //new Produto().Listar().ForEach(item => Console.WriteLine(item.Nome));

            //Concatenando atributos do objeto
            //new Produto().Listar().ForEach(item => {
            //    Console.WriteLine(item.Nome);
            //    Console.WriteLine(item.Valor);
            //});


            ////Pare este exemplo é necessário formatar para o tipo List o foreach
            //new Produto().Listar().Where(p => p.Valor > 4).ToList().ForEach(item => {
            //    Console.WriteLine(item.Nome);
            //    Console.WriteLine(item.Valor);
            //});


            //Usando JSon 
            //var produtos = new Produto().Listar();

            //Usando Contains
            //produtos = produtos.Where(p => p.Nome.Contains("M")).ToList();

            //Usando StartsWith e EndsWith
            //produtos = produtos.Where(p => p.Nome.StartsWith("A") || p.Nome.EndsWith("o")).ToList();


            //produtos.ForEach(item => Console.WriteLine(JsonConvert.SerializeObject(item)));


            //Usando Select
            //var nomes = produtos
            //    .Where(p => p.Nome.StartsWith("A") || p.Nome.EndsWith("o"))
            //    //.Select(p => new ProdutoSelecionado { Name = p.Nome.Substring(1,2).Insert(2,"Frutas"), Value = p.Valor})
            //    //.Select(p => new ProdutoSelecionado { Name = p.Nome.Remove(2,2), Value = p.Valor })
            //    .Select(p => new ProdutoSelecionado { Name = p.Nome.Replace("a", "Z"), Value = p.Valor })
            //    .ToList();


            //Usando Datas
            //var nomes = produtos
            //    .Where(p=>p.DateVencimento.Value.Year ==  2018 )
            //    //.Select(p => new ProdutoSelecionado { Name = p.Nome.Substring(1,2).Insert(2,"Frutas"), Value = p.Valor})
            //    //.Select(p => new ProdutoSelecionado { Name = p.Nome.Remove(2,2), Value = p.Valor })
            //    .Select(p => new ProdutoSelecionado { Name = p.Nome.Replace("a", "Z"), Value = p.Valor , DiaDeVencimento =  p.DateVencimento.Value.Day})
            //    .ToList();


            //produtos.ForEach(item => {
            //    Console.WriteLine(JsonConvert.SerializeObject(item));
            //});



            //##############
            //AULA 6 
            //##############

            //Array com itens
            //var produtos = new Produto().Listar();

            //Array vazia
            //List<Produto> produtos = new List<Produto>();

            //if (produtos.Any()) {
            //    Console.WriteLine("Tem item.");
            //} else {
            //    Console.WriteLine("Não tem item.");
            //}


            //if (produtos.Any(p=> p.Quantidade > 10)) {
            //    Console.WriteLine("Exitem produtos com quantidade maior que 10.");
            //}


            ////Adicionando uma lista dentro de outra lista
            //var produtos1 = new Produto().Listar();
            //var produtos2 = new List<Produto>();
            //produtos2.Add(new Produto() { Nome = "Galaxy", Valor = 2500 });
            //produtos2.Add(new Produto() { Nome = "iPhone", Valor = 7900 });
            //produtos1.AddRange(produtos2);
            //produtos1.ForEach(x => Console.WriteLine(x.Nome));


            //int[] numerosPares = {2,4,6,8,10 };
            //int[] numerosImpares = { 1,3,5,7,9};
            //int[] numerosMisturados = { 1, 2, 3, 4 };
            //var temNumerosPares = numerosMisturados.Intersect(numerosPares);
            //foreach( var nP in temNumerosPares) {
            //    Console.WriteLine("{0}", nP );
            //}
            //Console.WriteLine("-----------------------");
            //var numerosQueNaoSeRepetem = numerosMisturados.Except(numerosPares);
            //foreach(var nQNSR in numerosQueNaoSeRepetem) {
            //    Console.WriteLine("{0} ", nQNSR);
            //}


            ////Range - faixa 
            //var sequencia = Enumerable.Range(10, 5);
            //foreach(var seq in sequencia) {
            //    Console.WriteLine($"{seq}");
            //}
            ////Repeat - Repetir
            //var repetir = Enumerable.Repeat("Danilo", 5);
            //foreach (var rep in repetir) {
            //    Console.WriteLine($"{rep}");
            //}


            ////var produto1 = produtos.First();
            ////var produto2 = produtos.FirstOrDefault(); 
            //var produto2 = produtos.FirstOrDefault();
            ////var produto1 = produtos.First();
            ////Last
            //var produto3 = produtos.LastOrDefault();
            ////var produto1 = produtos.Last();
            ////produtos.ForEach(item => {
            ////    Console.WriteLine(JsonConvert.SerializeObject(item));
            ////});


            //##############
            //AULA 7
            //##############

            //var produtos = new Produto().ListarFrutasCompleta();
            ////Valor do produto mais caro
            //var valorProdutoMaisCaro = produtos.Max(p => p.Valor);
            ////Valor do produto mais barato
            //var valorProdutoMaisBarato = produtos.Min(p => p.Valor);
            ////Media qtd em estoque
            //var maiorQtdEmEstoque = produtos.Average(x=> x.Valor);
            ////Soma 
            //var soma = produtos.Sum(x => x.Valor);


            var produtosFrutas = new Produto().ListarFrutas();
            var produtosEletronicos = new Produto().ListarEletronicos();

            var produtos = new List<Produto>();
            produtos.AddRange(produtosFrutas);
            produtos.AddRange(produtosEletronicos);

            Console.WriteLine(produtos.Count());

            produtos.ForEach(x => {
                Console.WriteLine(JsonConvert.SerializeObject(x));
            });

            Console.WriteLine("----------------------------");

            var resultado = (from p in produtos
                            group p by p.Categoria into grupo
                            select new RelatorioProdutoPorCategoria {
                                NomeDaCategoria = grupo.Key,
                                ValorMinimo = grupo.Min(x => x.Valor),
                                ValorMaximo = grupo.Max(x => x.Valor),
                                ValorTotal = grupo.Sum(x => x.Valor)
                            }).OrderBy(x => x.NomeDaCategoria).ToList();

            resultado.ToList().ForEach(x => {
                Console.WriteLine(JsonConvert.SerializeObject(x)); 

            });

            Console.ReadKey();

        }

        public class ProdutoSelecionado { 
            public string Name {  get; set; }   

            public decimal Value {  get; set; } 

            public int DiaDeVencimento { get; set; }    

        }

        public class RelatorioProdutoPorCategoria {
            public string NomeDaCategoria { get; set; }
            public decimal ValorMinimo { get; set; }
            public decimal ValorMaximo { get; set; }
            public decimal ValorTotal { get; set; } 

        }




    }
}

