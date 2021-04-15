using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{

    abstract class ItemLoja : IItemRelatorio
    {
        public long Id { get; protected set; }
        public PessoaJuridica Fornecedor { get; protected set; }

        public float PrecoCompra { get; protected set; }
        public float PrecoVenda { get; protected set; }
        public int QuantidadeEstoque { get; protected set; }


        public ItemLoja(long id, PessoaJuridica fornecedor, float precoCompra, float precoVenda, int quantidadeEstoque)
        {
            Id = id;
            Fornecedor = fornecedor;
            PrecoCompra = precoCompra;
            PrecoVenda = precoVenda;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public abstract void MostrarDescricao();










    }


}