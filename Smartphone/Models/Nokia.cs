using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartphone.Models
{
    public class Nokia : Smartphone
    {
        public void ApresentarModelo()
        {
            Modelo = "C 12";
            Imei = "331497566947501";
            Memoria = 2;

            Console.Write($"Informações do aparelho \n" +
                    $"Modelo: {Modelo} \n" +
                    $"IMEI: {Imei} \n" +
                    $"Memoria: {Memoria} GB \n");
        }

        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"Acessando a Google Play para instalar o aplicativo {aplicativo}");
        }
    }
}