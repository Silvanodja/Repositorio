using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{

    class Caderno : ItemLoja
    {
        public int QuantidadeFolhas { get; protected set; }
        
        public Caderno(long id, float precoCompra, float precoVenda,int quantidadeFolhas) : base(id, precoCompra, precoVenda, 0)
        {
            QuantidadeFolhas = quantidadeFolhas;
        }

    }


}