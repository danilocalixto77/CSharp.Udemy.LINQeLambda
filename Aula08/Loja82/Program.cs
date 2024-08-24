using Loja82.Infra.Linq.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja82 {
    class Program {
        static void Main(string[] args) {

            //new RepositorioCategoria().AdicionarCategoria(10, "Roupas");
            //new RepositorioCategoria().AdicionarCategoria(11, "Calçados");


            //new RepositorioCategoria().AlterarCategoria(11, "Calçados Masculinos");

            new RepositorioCategoria().ExcluirCategoria(5);

        }
    }
}
