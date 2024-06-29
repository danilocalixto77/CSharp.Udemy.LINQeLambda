using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao {
    internal class Program {
        static void Main(string[] args) {

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            var resultado = from num in numeros select num;

            foreach (int i in numeros.Where(n => n > 4)) {
                Console.WriteLine(i);
            }
        }
    }
}
