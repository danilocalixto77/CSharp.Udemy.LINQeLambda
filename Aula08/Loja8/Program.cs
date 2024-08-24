

using Loja8.Infra.EF;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Loja8 {
    class Program {
        static void Main(string[] args) {
            #region Aula8 - Conexoes Banco de Dados SQL
            //Salvando categoria com o EntityFrameWork
            //new Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria(1, "Frutas");
            //new Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria(2, "Eletronicos");

            //new Infra.EF.Repositorio.RepositorioCategoria().AlterarCategoria(1, "Frutas e Verduras");
            //new Infra.EF.Repositorio.RepositorioCategoria().AlterarCategoria(2, "Tecnologia e Eletronicos");


            //new Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria(3, "Verduras");
            //new Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria(4, "Legumes");

            //new Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria(5, "Ferramentas");


            //new Infra.EF.Repositorio.RepositorioCategoria().ExcluirCategoria(3);
            //new Infra.EF.Repositorio.RepositorioCategoria().ExcluirCategoria(10);
            //new Infra.EF.Repositorio.RepositorioCategoria().ExcluirCategoria(11);


            //new Infra.EF.Repositorio.RepositorioProduto().AdicionarProduto(1, 2, "IPhone", 8000);
            //new Infra.EF.Repositorio.RepositorioProduto().AdicionarProduto(2, 2, "Galaxy S", 2000);
            //new Infra.EF.Repositorio.RepositorioProduto().AdicionarProduto(3, 2, "Pen Drive 16gb", 29);
            //new Infra.EF.Repositorio.RepositorioProduto().AdicionarProduto(4, 1, "Cebola", 8);
            //new Infra.EF.Repositorio.RepositorioProduto().AdicionarProduto(5, 1, "Alho", 38);
            //new Infra.EF.Repositorio.RepositorioProduto().AdicionarProduto(6, 1, "Laranja", 3);

            //var produtosEF = new Infra.EF.Repositorio.RepositorioProduto().ListarProdutos();
            //produtosEF.ForEach(x => Console.WriteLine(JsonConvert.SerializeObject(x.nome)));
            //Console.ReadKey(); 
            #endregion ;


            try {
                int qtde = 1000000;
                string tempoProcessamentoNormal = ProcessamentoNormal(qtde);
                string tempoProcessamentoParalelo = ProcessamentoParalelo(qtde);

                Console.WriteLine("Tempo processamento paralelo " + tempoProcessamentoParalelo);

                Console.WriteLine("Tempo processamento normal " + tempoProcessamentoNormal);

            } catch (Exception e) {
                Console.WriteLine("Exceção: " + e.Message);

            }
        }

        private static string ProcessamentoNormal(int qtde) { 
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < qtde; i++) {

                Console.WriteLine("Escrevendo a linha" + i.ToString());

            }

            sw.Stop();

            return sw.Elapsed.ToString();   

        }

        private static string ProcessamentoParalelo(int qtde) {

            Stopwatch sw = new Stopwatch();

            sw.Start();

            Parallel.For(0, qtde, index => {
                Console.WriteLine("Escrevendo a linha" + index.ToString());


            });

            sw.Stop();

            return sw.Elapsed.ToString();
        }

    }
}

