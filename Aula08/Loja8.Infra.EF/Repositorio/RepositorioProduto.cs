using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja8.Infra.EF.Repositorio {
    public class RepositorioProduto {
        public void AdicionarProduto(int _id, int _idcategoria, string _nome, decimal valor) {
            //EntityFramework

            Produto pro = new Produto();

            pro.id = _id;
            pro.idcategoria = _idcategoria;
            pro.nome = _nome;
            pro.valor = valor;


            Loja8EFEntities ef = new Loja8EFEntities();

            ef.Produto.Add(pro);

            ef.SaveChanges();

        }

        public List<Produto> ListarProdutos() {
            Loja8EFEntities ef = new Loja8EFEntities();

            return ef.Produto.ToList();


        }

    }
}
