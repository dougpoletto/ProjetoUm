using Newtonsoft.Json;
using ProjetoUm.Classes.SubClasses;
using RestSharp;
using System.Net;

namespace ProjetoUm.Classes
{
    public class ConsultarEstado
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("sigla")]
        public string Sigla { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("regiao")]
        public Regiao Regiao { get; set; }

        public static async Task<List<ConsultarEstado>> ConsultaEstado()
        {
            try
            {
                List<ConsultarEstado> consultarEstado = new List<ConsultarEstado>();
                var client = new RestClient("https://servicodados.ibge.gov.br/api/v1/localidades/estados");
                var request = new RestRequest();

                request.Method = Method.Get;
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");

                var response = await client.ExecuteAsync(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show($@"Erro no get do Estado. {response.StatusCode}: {response.ErrorMessage}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return default;
                }
                else
                {
                    var json = response.Content;
                    consultarEstado = JsonConvert.DeserializeObject<List<ConsultarEstado>>(json);
                }

                return consultarEstado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Falha na pesquisa do Estado. Exceção: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
