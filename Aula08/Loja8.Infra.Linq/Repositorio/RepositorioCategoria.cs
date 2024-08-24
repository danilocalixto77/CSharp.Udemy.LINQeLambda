using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja8.Infra.Linq.Repositorio {
    class RepositorioCategoria {
        public void AdicionarCategoria(int id, string nome) {
            //Linq To SQL

            Categoria cat = new Categoria();

            cat.idcategoria = id;
            cat.nome = nome;


            Loja8LinqToSqlDataContext linq = new Loja8LinqToSqlDataContext();

            linq.Categoria.InsertOnSubmit(cat);

            linq.SubmitChanges();   

            

        }

    }
}
