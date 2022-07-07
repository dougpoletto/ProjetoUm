using System.ComponentModel.DataAnnotations;

namespace ProjetoUm
{
    public class CadastroPessoas
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string RgIe { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public List<CadastroPessoasTelefones> CadastroPessoasTelefones { get; set; } = new List<CadastroPessoasTelefones>();
    }
}