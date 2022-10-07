using Exercicio02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Repositories
{
    public class FornecedorRepository
    {
        public void ExportarDados(Fornecedor fornecedor)
        {
            #region Definindo o local do arquivo

            var path = $"c:\\temp\\fornecedores.txt";

            #endregion

            #region Gravando o arquivo em TXT

            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine($"ID DO FORNECEDOR: {fornecedor.IdFornecedor}");
                streamWriter.WriteLine($"NOME FORNECEDOR.: {fornecedor.Nome}");
                streamWriter.WriteLine($"CNPJ............: {fornecedor.Cnpj}");
                streamWriter.WriteLine("\n");
            }

            #endregion
        }
    }
}
