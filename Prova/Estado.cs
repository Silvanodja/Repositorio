using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{

    class Estado
    {
        public string Nome { get; private set; }
        public string Sigla { get; private set; }

        public Estado(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }


    }


}