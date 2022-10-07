using Exercicio02.Entities;
using Exercicio02.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Controllers
{
    public class FornecedorController
    {
        //ler os dados do fornecedor informado pelo usuário
        public void CadastrarFornecedor()
        {
            Console.WriteLine("\n ***** CADASTRO DE FORNECEDORES ***** \n");

            var fornecedor = new Fornecedor();

            fornecedor.IdFornecedor = Guid.NewGuid();

            try
            {
                Console.Write("Nome do Fornecedor.....: ");
                fornecedor.Nome = Console.ReadLine();

                Console.Write("CNPJ...................: ");
                fornecedor.Cnpj = Console.ReadLine();

                Console.WriteLine($"\nFornecedor {fornecedor.Nome} cadastrado com sucesso!");

                var fornecedorRepository = new FornecedorRepository();
                fornecedorRepository.ExportarDados(fornecedor);

                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine("Falha ao cadastrar fornecedor!");
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }
}
