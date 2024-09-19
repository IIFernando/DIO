using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartphone.Models
{
    public abstract class Smartphone
    {
        string Numero;
        protected string Modelo;
        protected string Imei;
        protected int Memoria;

        public abstract void InstalarAplicativo(string aplicativo);

        public void Ligar(string numero)
        {
            Numero = numero;
            Console.Write($"Você está ligando para o número {Numero}. \n");
        }

        public void RecebendoLigacao(string numero)
        {
            Numero = numero;
            Console.Write($"Recebendo chamada do número {Numero}. \n");
        }
    }
}