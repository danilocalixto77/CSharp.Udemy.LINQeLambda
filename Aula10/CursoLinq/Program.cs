using CursoLinq.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinq {
    internal class Program {
        static void Main(string[] args) {

            List<Produto> produtos = new List<Produto>();   

            using (LojaContext ef = new LojaContext()) {

                produtos = ef.Produto.ToList(); 
            }

            produtos.ForEach(x => {
                Console.WriteLine(x.nome);
            });

            

              
        }
    }
}
