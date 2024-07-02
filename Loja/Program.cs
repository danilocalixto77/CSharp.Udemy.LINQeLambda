using Loja.Dominio.Entidades;
using System;
using System.Collections.Generic;
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
            new Produto().Listar().ForEach(item => Console.WriteLine(item.Nome));

            //Concatenando atributos do objeto
            new Produto().Listar().ForEach(item => 
            {  Console.WriteLine(item.Nome); 
               Console.WriteLine(item.Valor);
            });


            //Pare este exemplo é necessário formatar para o tipo List o foreach
            new Produto().Listar().Where(p => p.Valor >4).ToList().ForEach(item => {
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Valor);
            });


        }
    }
}
