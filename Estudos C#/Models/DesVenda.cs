using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Estudos_C_.Models
{
    public class DesVenda
    {
        public int Id { get; set; }

        //Dessa forma podemos tratar tipos de atributos diferentes entre o arquivo fonte.
        [JsonProperty("nome_Produto")]
        public string Produto { get; set; }

        public decimal Preco { get; set; }

        public DateTime DataVenda { get; set; }
    }
}