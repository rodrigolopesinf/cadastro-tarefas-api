using Cadastro.Tarefas.Core.Contextos.CadastroTarefas;
using Cadastro.Tarefas.Core.Interfaces.Repositories;
using Cadastro.Tarefas.Core.Models.Tarefas;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Tarefas.Core.Repositories.CadastroTarefas
{
    public class TarefaRepository : ITarefaRepository
    {
        protected readonly TarefasContext Db;

        public TarefaRepository(TarefasContext context)
        {
            Db = context;
        }

        public async Task<IEnumerable<Tarefa>> GetAll()
        {
            return await Db?.Tarefas?.ToListAsync();
        }

        public async Task<Tarefa> GetById(int id)
        {
            return await Db?.Tarefas?
                .Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public void Remove(int id)
        {
            Db.Tarefas.Remove(new Tarefa() { Id = id });
            Db.SaveChanges();
        }

        public void Save(Tarefa task)
        {
            Db?.Tarefas?.Add(task);
            Db?.SaveChanges();
        }

        public void Update(Tarefa task)
        {
            Db.Tarefas.Update(task);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}