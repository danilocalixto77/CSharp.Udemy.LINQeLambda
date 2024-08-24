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
    }
}
