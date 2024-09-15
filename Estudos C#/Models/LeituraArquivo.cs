using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudos_C_.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string Caminho)
        {
            
            try
            {
                string[] linhas = File.ReadAllLines(Caminho);
                return (true, linhas, linhas.Count());
            }
            catch(Exception)
            {
                return (false, new string[0], 0);
            }

        }

        public void Deconstruct()
        {
            
        }
    }
}