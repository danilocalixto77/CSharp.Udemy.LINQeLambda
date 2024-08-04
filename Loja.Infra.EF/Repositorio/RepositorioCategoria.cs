using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Infra.EF.Repositorio {
    public class RepositorioCategoria {
        public void AdicionarCategoria(string nome) {
            Categoria catFrutas = new Categoria();
            catFrutas.nome = "Frutas";

            Categoria catEletronicos = new Categoria();
            catEletronicos.nome = "Eletronicos";

            LojaEFEntities ef = new LojaEFEntities();

            ef.Categoria.Add(catFrutas);
            ef.Categoria.Add(catEletronicos);


    }
}
