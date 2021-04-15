using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{

    class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; private set; }

        public PessoaJuridica(long id, string nome, Endereco endereco, string email, string cnpj) : base(id, nome, endereco, email)
        {
            Cnpj = cnpj;
        }

    }


}