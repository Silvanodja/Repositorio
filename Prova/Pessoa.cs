using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    abstract class Pessoa
    {
        private long Id { get; protected set; }
        public string Nome { get; protected set; }
        public Endereco Endereco { get; protected set; }
        public string Email { get; protected set; }


    }


}