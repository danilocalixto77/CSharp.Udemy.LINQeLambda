using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Loja8.Infra.EF.Repositorio {
    public class RepositorioCategoria {
        public void AdicionarCategoria(int _id,  string _nome) {
            //EntityFramework

            Categoria cat = new Categoria();

            cat.idcategoria = _id;
            cat.nome = _nome;
            

            Loja8EFEntities ef = new Loja8EFEntities();

            ef.Categoria.Add(cat);

            ef.SaveChanges();

        }

        public void AlterarCategoria(int _id , string _nome) {
            //EntityFramework

            Loja8EFEntities ef = new Loja8EFEntities();

            var categoria = ef.Categoria.First(x => x.idcategoria == _id);

            categoria.nome = _nome;

            ef.SaveChanges();

        }

        public void ExcluirCategoria(int _id) {
            //EntityFramework

            Loja8EFEntities ef = new Loja8EFEntities();

            var categoria = ef.Categoria.First(x => x.idcategoria == _id);

            ef.Categoria.Remove(categoria);

            ef.SaveChanges();

        }

    }
}
