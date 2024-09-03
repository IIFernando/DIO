using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.models
{
    public class Estacionamento
    {
        List<string> carros = new List<string>();

        public void addCarro(string carro)
        {
            carros.Add(carro);
        }

        // Remove todas as ocorrências do carro da lista
        public void RemoveCarro(string carro)
        {
            while (carros.Contains(carro))
            {
                carros.Remove(carro);
            }
        }

        // Método para imprimir a lista completa de carros
         public void ImprimirCarros()
        {
            if (carros.Count == 0)
            {
                Console.WriteLine("Não há carros no estacionamento.");
                return;
            }

            Console.WriteLine("Carros no estacionamento:");

            // Iterar e imprimir cada carro da lista
            foreach (var carro in carros)
            {
                Console.WriteLine(carro);
            }
        }

        public double CustoFinal(double custoEntrada, double custoHora, int horas)
        {
            double vFinal = custoEntrada + custoHora * horas;
            return vFinal;
        }
        
    }
}