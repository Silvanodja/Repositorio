using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro cadastro = new Cadastro();

            PessoaJuridica fornecedor = new PessoaJuridica(400, "Livros Associados SA", new Endereco(45, "Edificio Gaveta", new Bairro("Copacabana"), new Cidade("Rio de Janeira", new Estado("Rio de Janeiro", "RJ"))), "faleconosco@associados.com", "99.8888.7777-77");

            cadastro.AdicionarCliente(new PessoaFisica(100, "Bob Nelson", new Endereco(23, "Rua das Classes", new Bairro("jardim das Oliveiras"), new Cidade("Brasilia", new Estado("Distrito Federal", "DF"))), "bobNelson@gmail.com", "11.222.333-99", false));

            cadastro.AdicionarCliente(new PessoaFisica(200, "Testolfo Rocha", new Endereco(4, "Avenida Abstrata", new Bairro("Operários"), new Cidade("Rio Verde", new Estado("Goiais", "GO"))), "testolfoROcha26@gmail.com", "444.555.666-11", true));

            cadastro.AdicionarCliente(new PessoaFisica(300, "Belo Teste", new Endereco(26, "Vale das Heranças", new Bairro("Monges Unidos"), new Cidade("Belo Horizonte", new Estado("Minas Gerais", "MG"))), "Testebelo@gmail.com", "999.888.777-72", true));

            cadastro.AdicionarFornecedor(fornecedor);

            Livro livroUm = new Livro(100, fornecedor, 19.99f, 31.99f, 10, EnumGenero.Ficcao,"Dom Casmurro", "Machado de Assis", "Universal");
            Livro livroDois = new Livro(150, fornecedor, 24.35f, 58.99f, 10, EnumGenero.Games, "Unity: desing e  desenvolvimento de jogos", "William Pereira Alves", "Universal");
            Caderno cadernoUm = new Caderno(170, "Caderno Capa Dura - Jaspion", fornecedor, 10.99f, 25.99f, 10, 100);

        }
    }
}
