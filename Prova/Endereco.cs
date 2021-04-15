using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{

    class Endereco

    {
        public long Numero { get; private set; }
        public string Rua { get; private set; }
        public Bairro Bairro { get; private set; }
        public Cidade Cidade { get; private set; }
        public Endereco(long numero, string rua, Bairro bairro, Cidade cidade)
        {
            Numero = numero;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
        }


    }
}