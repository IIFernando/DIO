using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartphone.Models
{
    public class Iphone : Smartphone
    {

        public void ApresentarModelo()
        {
            Modelo = "Iphone 15";
            Imei = "447733539461829";
            Memoria = 6;

            Console.Write($"Informações do aparelho \n" +
                    $"Modelo: {Modelo} \n" +
                    $"IMEI: {Imei} \n" +
                    $"Memoria: {Memoria} GB \n");
        }

        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"Acessando a Apple Store para instalar o aplicativo {aplicativo}");
        }
    }
}