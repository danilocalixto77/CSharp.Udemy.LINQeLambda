using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Infra.EF.Repositorio {
    public class RepositorioCategoria {
        public void AdicionarCategoria(int id, string nome) {

            //Entity Framework

            Categoria categoria = new Categoria();
            categoria.Id = id;
            categoria.Nome = nome;

            //Instanciar o contexto do Entity Framework
            LojaEFEntities ef = new LojaEFEntities();

            ef.Categoria.Add(categoria);

            ef.SaveChanges();

        }


    }
}
