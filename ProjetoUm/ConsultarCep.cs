using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace ProjetoUm
{
    public class ConsultarCep
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty("complemento")]
        public string Complemento { get; set; }
        [JsonProperty("bairro")]
        public string Bairro { get; set; }
        [JsonProperty("localidade")]
        public string Localidade { get; set; }
        [JsonProperty("uf")]
        public string Uf { get; set; }
        [JsonProperty("ibge")]
        public int Ibge { get; set; }
        [JsonProperty("gia")]
        public int Gia { get; set; }
        [JsonProperty("ddd")]
        public int Ddd { get; set; }
        [JsonProperty("siafi")]
        public int Siafi { get; set; }

        public static async Task<ConsultarCep> ConsultaCep(string cep)
        {
            try
            {
                var conulstaCep = new ConsultarCep();
                var client = new RestClient($"https://viacep.com.br/ws/{cep.Replace("-", "")}/json/");
                var request = new RestRequest();

                request.Method = Method.Get;
                request.AddHeader("cache-control", "public");
                request.AddHeader("content-type", "application/json");

                var response = await client.ExecuteAsync(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show($@"Erro no get do Cep. {response.StatusCode}: {response.ErrorMessage}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    var json = response.Content;
                    conulstaCep = JsonConvert.DeserializeObject<ConsultarCep>(json);
                }

                return conulstaCep;
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Falha na pesquisa do Cep. Exceção: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
