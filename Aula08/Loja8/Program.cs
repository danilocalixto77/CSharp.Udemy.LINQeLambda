﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Loja8 {
    class Program {
        static void Main(string[] args) {
            //Salvando categoria com o EntityFrameWork
            new Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria(1, "Frutas");
            new Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria(2, "Eletronicos");
            
            


        }
    }
}

