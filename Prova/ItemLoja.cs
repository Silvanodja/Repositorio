using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{

    abstract class ItemLoja
    {
        public long Id { get; protected set; }
        public PessoaJuridica Fornecedor { get; protected set; }

        public float PrecoCompra { get; protected set; }
        public float PrecoVenda { get; protected set; }
        public int QuantidadeEstoque { get; protected set; }














    }


}