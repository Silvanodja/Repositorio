using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    abstract class Pessoa
    {
        private long Id { get;  set; }
        public string Nome { get; protected set; }
        public endereco Endereco { get; protected set; }
        public string Email { get; protected set; }

        public Pessoa(long id)
        {
            Id = id;
        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
         public Pessoa(endereco endereco)
        {
            Endereco = endereco;
        }
         public Pessoa(string email)
        {
            Email = email;
        }
    }


}