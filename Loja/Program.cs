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
            var produtos = new Produto().Listar();

            //Usando Contains
            //produtos = produtos.Where(p => p.Nome.Contains("M")).ToList();

            //Usando StartsWith e EndsWith
            produtos = produtos.Where(p => p.Nome.StartsWith("A") || p.Nome.EndsWith("o")).ToList();

                        
            produtos.ForEach(item => Console.WriteLine(JsonConvert.SerializeObject(item)));


            //Usando Select
            var nomes = produtos
                .Where(p => p.Nome.StartsWith("A") || p.Nome.EndsWith("o"))
                .Select(p => new ProdutoSelecionado { Name = p.Nome , Value = p.Valor})
                .ToList();


            nomes.ForEach(item => {
                Console.WriteLine(JsonConvert.SerializeObject(item));
            });

            Console.ReadKey();

        }

        public class ProdutoSelecionado { 
            public string Name {  get; set; }   

            public decimal Value {  get; set; } 
        }



    }
}
