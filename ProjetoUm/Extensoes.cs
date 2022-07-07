using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace ProjetoUm
{
    public static class Extensoes
    {
        public static void CriarTabelaBancoDados<TDbContext>(this TDbContext dbContext) where TDbContext : DbContext
        {
            var tipo = typeof(TDbContext);
            var dbSet = typeof(DbSet<>);
            var propriedade = tipo.GetProperties()
                .Where(p => p.PropertyType.Name == dbSet.Name)
                .Select(p => p.Name)
                .ToArray();
            var script = dbContext.Database.GenerateCreateScript();
            try
            {
                foreach (var tabela in propriedade)
                {
                    VerificaTabelaCriacao(dbContext, tabela, script);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Falha ao criar a tabela no banco de dados. Exceção: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void VerificaTabelaCriacao(DbContext dbContext, string tabela, string script)
        {
            var esquemaPadrao = dbContext.Model.GetDefaultSchema();
            var esquemaTabela = string.IsNullOrEmpty(esquemaPadrao)
                ? $"[{tabela}]"
                : $"[{esquemaPadrao}].[{tabela}]";
            var inicioScript = $"create table {esquemaTabela}";
            var scriptCriacao = script.Split(inicioScript).Last();
            var scriptExiste = $@"if not exists (select * from sysobjects where name = '{tabela}' " + 
                $"{scriptCriacao.First()}";

            dbContext.Database.ExecuteSqlRaw(scriptExiste);
        }
    }
}
