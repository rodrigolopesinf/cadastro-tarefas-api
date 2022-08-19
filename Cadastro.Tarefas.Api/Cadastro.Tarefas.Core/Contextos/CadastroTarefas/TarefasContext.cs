using Cadastro.Tarefas.Core.Models.Tarefas;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Tarefas.Core.Contextos.CadastroTarefas
{
    public class TarefasContext : DbContext
    {
        public DbSet<Tarefa>? Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TarefasDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}