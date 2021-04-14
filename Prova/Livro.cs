using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{

    class Livro : ItemLoja
    {
        public string Titulo { get; private set; }
        public EnumGenero Genero { get; private set; }
        public string Autor { get; private set; }
        public string Editora { get; private set; }
        


    }


}