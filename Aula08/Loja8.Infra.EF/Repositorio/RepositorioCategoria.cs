using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Loja8.Infra.EF.Repositorio {
    public class RepositorioCategoria {
        public void AdicionarCategoria(string nome) {

            Categoria cat = new Categoria();

            cat.nome = nome;

            Loja8EFEntities ef = new Loja8EFEntities();

            ef.Categoria.Add(cat);

            ef.SaveChanges();



        }
    }
}
