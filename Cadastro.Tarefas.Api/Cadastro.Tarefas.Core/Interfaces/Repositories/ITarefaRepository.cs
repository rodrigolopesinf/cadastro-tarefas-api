using Cadastro.Tarefas.Core.Models.Tarefas;

namespace Cadastro.Tarefas.Core.Interfaces.Repositories
{
    public interface ITarefaRepository : IRepositoryBase<Tarefa>, IDisposable
    {
    }
}