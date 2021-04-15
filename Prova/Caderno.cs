using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{

    class Caderno : ItemLoja
    {
        public int QuantidadeFolhas { get; private set; }
        public string Nome { get; private set; }

        public Caderno(long id,string nome, PessoaJuridica fornecedor, float precoCompra, float precoVenda, int quantidadeEstoque, int quantidadeFolhas) : base(id, fornecedor, precoCompra, precoVenda, quantidadeEstoque)
        {
            Nome = nome;
            QuantidadeFolhas = quantidadeFolhas;
        }

        public override void MostrarDescricao()
        {
            Console.WriteLine("O caderno posssui {0} páginas", QuantidadeFolhas);
        }
    }


}