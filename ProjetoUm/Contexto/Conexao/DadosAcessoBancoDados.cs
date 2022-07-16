using Newtonsoft.Json;

namespace ProjetoUm.Contexto.Conexao
{
    public class DadosAcessoBancoDados
    {
        [JsonProperty("dataSource")]
        public string DataSource { get; set; }
        [JsonProperty("userId")]
        public string UserId { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("initialCatalog")]
        public string InitialCatalog { get; set; }
    }
}
