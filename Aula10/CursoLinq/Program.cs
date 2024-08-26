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


            //Retorna o primeiro objeto da coleção do filtro. Caso não encontre gera exceção.
            Produto produto1 = produtos.First();
            Produto produto1_1 = produtos.First(x => x.nome.Contains("a"));

            //Retorna o primeiro objeto da coleção do filtro. Caso exista NULL evita gerar exceção.
            Produto produto2 = produtos.FirstOrDefault();
            //Retorna o primeiro objeto da coleção do filtro. Caso exista NULL evita gerar exceção.
            Produto produto2_1 = produtos.FirstOrDefault();

            //Single() Retornar um único registro. E for NULL ou encontrar mais de 1 registro gera exceção.
            //SingleOrDefault() Retornar um único registro. E for NULL não gera exceção. Se encontrar mais de 1 registro gera exceção.
            try {
                Produto produto3 = produtos.Single(x => x.nome.Contains("a")); // Obtém o primeiro produto com a letra 'a'
                Console.WriteLine("----------------------------- Single() ");
                Console.WriteLine(produto3.nome);
            } catch (Exception e){
                Console.WriteLine("Há mais de um registro para condição filtrada.");
                Produto produto3_1 = produtos.SingleOrDefault(x => x.nome.Contains("aaaa")); // Obtém o primeiro produto ou retorna null
                Console.WriteLine("----------------------------- SingleOrDefault() ");
                if (produto3_1 != null){
                    Console.WriteLine(produto3_1.nome);
                }
                
            }


            //Skip - Pula quantidade de registros passado como parâmetro
            var produtosPaginados1 = produtos.Skip(2).ToList(); //Skip é do tipo Enumerable precisa parsear pra um tipo list.
            Console.WriteLine("----------------------------- Skip(2) ");
            produtosPaginados1.ForEach(x => {
                Console.WriteLine(x.nome);
            });

            //Take - Semelhante ao Top, pega a quantidade de itens passados no parâmetro
            var produtosPaginados2 = produtos.Take(3).ToList(); //Take é do tipo Enumerable precisa parsear pra um tipo list.
            Console.WriteLine("----------------------------- Take(3) ");
            produtosPaginados2.ForEach(x => {
                Console.WriteLine(x.nome);
            });

            //Skip e Take
            Console.WriteLine("----------------------------- Skip(2) / Take(2) ");
            var produtosPaginados3 = produtos.Skip(2).Take(2).ToList();
            produtosPaginados3.ForEach(x => {
                Console.WriteLine(x.nome);
            });

            //Count
            Console.WriteLine("----------------------------- Count() ");
            var qtdProdutos = produtos.Count();
            var qtdProdutosComLetraA = produtos.Count(x => x.nome.Contains("a"));

            Console.WriteLine($"Quantidade de produtos: {qtdProdutos} Quantidade de produtos com a ledra 'a': {qtdProdutosComLetraA}" );

            //SkipWhile
            Console.WriteLine("----------------------------- SkipWhile ");
            var pulandoProdutosCaros = produtos.SkipWhile(x => x.valor > 1000).ToList();
            pulandoProdutosCaros.ForEach(x => {
                Console.WriteLine(string.Concat(x.nome, " R$ ", x.valor));
            });

            //Sum, Max, Min
            Console.WriteLine("----------------------------- Sum() Max() Min() ");
            var somandoValores = produtos.Sum(x =>  x.valor);
            var valorMaximo = produtos.Max(x  => x.valor);
            var valorMinimo = produtos.Min(x  => x.valor);
            Console.WriteLine($"A soma é: {somandoValores} o valor máximo é {valorMaximo} e o valor mínimo é {valorMinimo}");

            //Union
            Console.WriteLine("----------------------------- Union() ");
            int[] vetor1 = {5,3,9,7,5,9,3,7 };
            int[] vetor2 = {8,3,6,4,4,9,1,0 };

            IEnumerable<int> vetor3Union = vetor1.Union(vetor2);

            vetor3Union.ToList().ForEach(numeros => {
                Console.WriteLine(numeros);
            });

            //Distinct
            Console.WriteLine("----------------------------- Distinct() ");
            var iphones = produtos.Where(x => x.nome.Contains("IPhone")).Select(x=> x.nome).Distinct().ToList();
            iphones.ToList().ForEach(x => {
                Console.WriteLine(x);
            });

            //Any
            var existe = produtos.Any(); //Se existir = true
            var existeLivro = produtos.Any(x=> x.nome == "Livros"); //Se existir = true

            //




        }
    }
}

