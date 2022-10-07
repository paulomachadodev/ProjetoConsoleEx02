using Exercicio02.Controllers;
using Exercicio02.Entities;
using Exercicio02.Repositories;

namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nSEJA BEM VINDO AO SISTEMA DE CADASTRO DE PRODUTOS E FORNECEDORES\n");

            Console.WriteLine("Por favor escolha uma opção: ");
            Console.Write("(1) Cadastro de Produtos | (2) Cadastro de Fornecedores: ");
            var opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    var produtoController = new ProdutoController();
                    produtoController.CadastrarProduto();
              
                    break;

                case 2:
                    var fornecedorController = new FornecedorController();
                    fornecedorController.CadastrarFornecedor();
                    break;
            }
        }
    }
}