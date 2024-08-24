using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja82.Infra.Linq.Repositorio {
    public class RepositorioCategoria {
        public void AdicionarCategoria(int id, string nome) {
            //Linq To SQL

            Categoria cat = new Categoria();

            cat.idcategoria = id;
            cat.nome = nome;


            Loja82LinqToSQLDataContext linq = new Loja82LinqToSQLDataContext();

            linq.Categoria.InsertOnSubmit(cat);

            linq.SubmitChanges();

        }

        public void AlterarCategoria(int _id, string _nome) {
            //Linq To SQL

            Loja82LinqToSQLDataContext linq = new Loja82LinqToSQLDataContext();

            var categoria = linq.Categoria.First(x => x.idcategoria == _id);

            categoria.nome = _nome;

            linq.SubmitChanges();

        }

        public void ExcluirCategoria(int _id) {
            //Linq To SQL
            Loja82LinqToSQLDataContext linq = new Loja82LinqToSQLDataContext();

            var categoria = linq.Categoria.First(x => x.idcategoria == _id);

            linq.Categoria.DeleteOnSubmit(categoria);

            linq.SubmitChanges();

        }


    }
}
