using System.ComponentModel.DataAnnotations;

namespace ProjetoUm
{
    public class CadastroEstado
    {
        [Key]
        public string Estado { get; set; }
        public string NomeEstado { get; set; }
    }
}
