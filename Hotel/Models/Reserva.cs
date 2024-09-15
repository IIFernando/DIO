using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Reserva
    {   
        string? resultado;
        string escolha;
        decimal diaria;
        readonly decimal percentualDesconto = 10.00m; // Percentual de desconto

        // Lista de hóspedes
        private List<Pessoa> hospedes = new List<Pessoa>();
        
        public void CadastrarHospedes(Pessoa hospede)
        {
            hospedes.Add(hospede);
        }

        public  string CadastrarSuite(int escolha)
        {
            if (escolha == 1)
            {
                this.escolha = "Econômico";
            }
            else if (escolha == 2)
            {
                this.escolha = "Normal";
            }
            else if(escolha == 3)
            {
                this.escolha = "Premium";
            }
            else
            {
                this.escolha = "Escolha inválida";
            }
            
            return this.escolha;
        }

        public string ObterQuantidadeHospides(int quantidade)
        {
            if(escolha.Equals("Econômico"))
            {
                resultado = (quantidade <= 1) ? "Reserva realizda" : "Quantidade de hopedes ultrapassada.";
            }
            else if(escolha.Equals("Normal"))
            {
                resultado = (quantidade <= 2) ? "Reserva realizda" : "Quantidade de hopedes ultrapassada.";
            }
            else if (escolha.Equals("Premium"))
            {
                resultado = (quantidade <= 4) ? "Reserva realizda" : "Quantidade de hopedes ultrapassada.";
            }
            return resultado;
        }

        public decimal CalcularValorDiaria(int dias)
        {

            if(escolha.Equals("Econômico"))
            {
                decimal valorE = 10m * dias;
                decimal desconto = valorE * (percentualDesconto / 100);
                diaria = (dias >= 10) ? valorE - desconto : 10m * dias;
            }

            else if(escolha.Equals("Normal"))
            {
                decimal valorN = 20m * dias;
                decimal desconto = valorN * (percentualDesconto / 100);
                diaria = (dias >= 10) ? valorN - desconto : 10m * dias;
            }
            
            else if (escolha.Equals("Premium"))
            {
                decimal valorP = 30m * dias;
                decimal desconto = valorP * (percentualDesconto / 100);
                diaria = (dias >= 10) ? valorP - desconto : 30m * dias;
            }

            return diaria;
        }
    }
}