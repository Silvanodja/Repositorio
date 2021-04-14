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

        public Livro(long id, float precoCompra, float precoVenda,int quantidadeEstoque,EnumGenero genero, string titulo, string autor, string editora) : base(id, precoCompra, precoVenda, quantidadeEstoque)
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            Genero = genero;
        }

        public override void MostrarDescricao()
        {
            Console.WriteLine("Título do livro: {0}, Autor(a): {1}, Editora: {2}, Gênero: {3}", Titulo, Autor, Editora, Genero);
        }


    }


}