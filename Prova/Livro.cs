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

        public Livro(long id, float precoCompra, float precoVenda, string titulo, string autor, string editora) : base(id, precoCompra, precoVenda, 0)
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
        }
        


    }


}