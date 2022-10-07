using Exercicio02.Entities;
using Exercicio02.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Controllers
{
    public class ProdutoController
    {
        //ler os dados do produto e do fornecedor associado pelo console
        public void CadastrarProduto()
        {
            Console.WriteLine("\n ***** CADASTRO DE PRODUTOS ***** \n");

            var produto = new Produto();

            produto.IdProduto = Guid.NewGuid();

            try
            {
                Console.Write("Nome do Produto........: ");
                produto.Nome = Console.ReadLine();

                Console.Write("Preço..................: ");
                produto.Preco = decimal.Parse(Console.ReadLine());

                Console.Write("Quantidade.............: ");
                produto.Quantidade = int.Parse(Console.ReadLine());

                var fornecedor = new Fornecedor();

                fornecedor.IdFornecedor = Guid.NewGuid();

                Console.Write("Nome do Fornecedor.....: ");
                fornecedor.Nome = Console.ReadLine();

                Console.Write("CNPJ...................: ");
                fornecedor.Cnpj = Console.ReadLine();

                var produtoRepository = new ProdutoRepository();
                produtoRepository.ExportarDados(produto, fornecedor);

                Console.WriteLine($"\nProduto {produto.Nome} cadastrado com sucesso!");

                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine("Falha ao cadastrar produto!");
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }
}
