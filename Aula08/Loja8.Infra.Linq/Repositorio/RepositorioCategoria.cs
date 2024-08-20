using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja8.Infra.Linq.Repositorio {
    public class RepositorioCategoria {
        public void AdicionarCategoria(int id, string nome) {
            //Linq TO SQL

            Categoria cat = new Categoria();

            cat.idcategoria = id;
            cat.nome = nome;


            Loja8LinqToSQLDataContext linq = new Loja8LinqToSQLDataContext();

            linq.Categoria.InsertOnSubmit(cat);

            linq.SubmitChanges();



        }
    }
}
}
