using Exercicio02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Repositories
{
    public class ProdutoRepository
    {
        public void ExportarDados(Produto produto, Fornecedor fornecedor)
        {
            #region Definindo o local do arquivo

            var path = $"c:\\temp\\produtos.txt";

            #endregion

            #region Gravando o arquivo em TXT

            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine($"ID DO PRODUTO...: {produto.IdProduto}");
                streamWriter.WriteLine($"NOME............: {produto.Nome}");
                streamWriter.WriteLine($"PREÇO...........: {produto.Preco}");
                streamWriter.WriteLine($"QUANTIDADE......: {produto.Quantidade}");
                streamWriter.WriteLine($"ID DO FORNECEDOR: {fornecedor.IdFornecedor}");
                streamWriter.WriteLine($"NOME FORNECEDOR.: {fornecedor.Nome}");
                streamWriter.WriteLine($"CNPJ............: {fornecedor.Cnpj}");
                streamWriter.WriteLine("\n");
            }

            #endregion
        }
    }
}
