using Microsoft.EntityFrameworkCore;

namespace ProjetoUm
{
    public class ContextoBancoDados : DbContext
    {
        public ContextoBancoDados()
        {
        }

        public ContextoBancoDados(bool criarTabela)
        {
            if (criarTabela)
            {
                this.CriarTabelaBancoDados();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CaminhoBancoDados.CaminhoArquivoBancoDados());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<CadastroPessoas> CadastroPessoas { get; set; }
        public DbSet<CadastroEstado> CadastroEstado { get; set; }
    }
}
