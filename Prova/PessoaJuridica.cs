using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{

    class PessoaJuridica : Pessoa
    {
        public long id { get; private set; }  
        public string nome { get; private set; } 
        public string cnpj { get; private set; } 
        public endereco Endereco { get; private set; } 
        public string email { get; private set; } 


    }


}