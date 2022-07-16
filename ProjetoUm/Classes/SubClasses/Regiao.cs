using Newtonsoft.Json;

namespace ProjetoUm.Classes.SubClasses
{
    public class Regiao
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("sigla")]
        public string Sigla { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
    }
}
