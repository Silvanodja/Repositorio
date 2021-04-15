using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    abstract class Pessoa
    {
        public long Id { get; protected set; }
        public string Nome { get; protected set; }
        public Endereco Endereco { get; protected set; }
        public string Email { get; protected set; }

        public Pessoa(long id, string nome, Endereco endereco, string email)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Email = email;
        }
    }


}