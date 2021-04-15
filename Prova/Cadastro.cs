using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{

    class Cadastro
    {
        public List<PessoaFisica> Cliente { get; private set; } = new List<PessoaFisica>();
        public List<PessoaJuridica> Fornecedor { get; private set; } = new List<PessoaJuridica>();

        public string RelacionarClientes()
        {
            return null;
        }
        public string RelacionarFornecedores()
        {
            return null;
        }
        public void AdicionarCliente(PessoaFisica novoCliente)
        {
            Cliente.Add(novoCliente);
        }
        public void AdicionarFornecedor(PessoaJuridica novoFornecedor)
        {
            Fornecedor.Add(novoFornecedor);
        }
        public void RemoverCliente(PessoaFisica cliente)
        {
            Cliente.Remove(cliente);
        }
        public void RemoverFornecedor(PessoaJuridica fornecedor)
        {
            Fornecedor.Add(fornecedor);
        }
    }


}