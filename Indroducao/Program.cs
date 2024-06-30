using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao {
    internal class Program {
        static void Main(string[] args) {

            int[] numeros = { 1, 6, 7, 8, 9, 2, 3, 4, 5,  10, 5, 6 };


            var resultado = from num in numeros
                            where num >= 4
                            orderby num 
                            select num;

            foreach (var r in resultado) {
                Console.WriteLine("Descrevendo query {0}", r);
            }


            var resultadoDois = numeros.Where(n => n > 4).OrderBy(o => o);
            

                foreach (int r2 in resultadoDois) {
                Console.WriteLine(r2);
            }



            string[] cores = { "Preto", "Branco", "Verde", "Vermelho", "Azul" };

            var resultadoCores = cores.Where(x => x.Contains("e") || x.Contains("z"));

            foreach( var rC1 in resultadoCores) {
                Console.WriteLine(rC1);
            }


        }
    }
}
