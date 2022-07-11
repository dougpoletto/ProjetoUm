using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProjetoUm
{
    public class CaminhoBancoDados
    {
        private static string Conexao
        {
            get
            {
                if (File.Exists(@"\Sistema\Conexao\Conexao.json"))
                {
                    return @"\Sistema\Conexao\Conexao.json";
                }
                else
                {
                    return Environment.CurrentDirectory + @"\Conexao.json";
                }
            }
        }
        private static string CaminhoBanco { get; set; } = "";

        public static string CaminhoArquivoBancoDados()
        {
            if (CaminhoBanco == "")
            {
                var conexao = CarregaConexaoBancoDados();
                if (conexao != null)
                {
                    CaminhoBanco = $@"Data Source={conexao.DataSource};User ID={conexao.UserId};
                        Password={conexao.Password};Initial Catalog={conexao.InitialCatalog}";
                }
            }
            return CaminhoBanco;
        }

        private static DadosAcessoBancoDados CarregaConexaoBancoDados()
        {
            DadosAcessoBancoDados dadosAcesso = null;
            try
            {
                using (var stream = new StreamReader(@"\Sistema\Conexao\Conexao.json"))
                {
                    var jsonArquivo = stream.ReadToEnd();
                    dadosAcesso = JsonConvert.DeserializeObject<DadosAcessoBancoDados>(jsonArquivo);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($@"Falha ao ler o arquivo de conexão com o banco. Exceção: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dadosAcesso;
        }
    }
}
