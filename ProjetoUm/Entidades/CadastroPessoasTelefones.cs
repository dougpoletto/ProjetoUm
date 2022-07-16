using System.ComponentModel.DataAnnotations;

namespace ProjetoUm.Entidades
{
    public class CadastroPessoasTelefones
    {
        [Key]
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}