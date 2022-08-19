using Cadastro.Tarefas.Core.Contextos.CadastroTarefas;
using Cadastro.Tarefas.Core.Interfaces.Repositories;
using Cadastro.Tarefas.Core.Models.Tarefas;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Tarefas.Core.Repositories.CadastroTarefas
{
    public class TarefaRepository : ITarefaRepository
    {
        protected readonly TarefasContext Db;
        protected readonly DbSet<Tarefa> DbSet;

        public TarefaRepository(TarefasContext context)
        {
            Db = context;
            DbSet = Db.Set<Tarefa>();
        }

        public async Task<IEnumerable<Tarefa>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<Tarefa> GetById(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Tarefa task)
        {
            DbSet.Add(task);
        }

        public void Update(Tarefa task)
        {
            DbSet.Update(task);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}