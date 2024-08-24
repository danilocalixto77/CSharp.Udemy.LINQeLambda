

using Loja8.Infra.EF;
using System;

namespace Loja8 {
    class Program {
        static void Main(string[] args) {
            //Salvando categoria com o EntityFrameWork
            //new Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria(1, "Frutas");
            //new Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria(2, "Eletronicos");

            //new Infra.EF.Repositorio.RepositorioCategoria().AlterarCategoria(1, "Frutas e Verduras");


            //new Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria(3, "Verduras");
            //new Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria(4, "Legumes");

            //new Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria(5, "Ferramentas");


            new Infra.EF.Repositorio.RepositorioCategoria().ExcluirCategoria(3);
            new Infra.EF.Repositorio.RepositorioCategoria().ExcluirCategoria(4);



            ;
        }
    }
}

