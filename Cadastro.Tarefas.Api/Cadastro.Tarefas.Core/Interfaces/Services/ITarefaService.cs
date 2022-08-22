using Cadastro.Tarefas.Core.DTOs.CadastroTarefas;
using FluentValidation.Results;

namespace Cadastro.Tarefas.Core.Interfaces.Repositories
{
    public interface ITarefaService : IDisposable
    {
        Task<IEnumerable<TarefasDto>> GetAll();
        Task<TarefasDto> GetById(int id);

        Task<ValidationResult> Save(TarefasDto tarefa);
        Task<ValidationResult> Update(TarefasDto tarefa);
        Task<ValidationResult> Remove(int id);
    }
}