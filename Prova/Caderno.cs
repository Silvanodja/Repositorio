using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{

    class Caderno : ItemLoja
    {
        public int QuantidadeFolhas { get; protected set; }
        
        public Caderno(long id, float precoCompra, float precoVenda,int quantidadeEstoque, int quantidadeFolhas) : base(id, precoCompra, precoVenda, quantidadeEstoque)
        {
            QuantidadeFolhas = quantidadeFolhas;
        }

        public override void MostrarDescricao()
        {
            Console.WriteLine("O caderno posssui {0} páginas", QuantidadeFolhas);
        }
    }


}