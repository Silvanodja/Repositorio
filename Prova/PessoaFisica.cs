using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{

    class PessoaFisica : Pessoa
    {
        public string Cpf { get; private set; }
        public bool Vip { get; private set; }
        public PessoaFisica(long id, string nome, Endereco endereco, string email, string cpf, bool vip) : base(id, nome, endereco, email)
        {
            Cpf = cpf;
            Vip = vip;
        }

    }


}