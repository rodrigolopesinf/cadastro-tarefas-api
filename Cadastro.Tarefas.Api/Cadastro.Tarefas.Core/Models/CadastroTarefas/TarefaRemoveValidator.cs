using Cadastro.Tarefas.Core.Models.Tarefas;
using FluentValidation;

namespace Cadastro.Tarefas.Core.Models.CadastroTarefas
{
    public class TarefaRemoveValidator : AbstractValidator<Tarefa>
    {
        public TarefaRemoveValidator()
        {
            Initialize();
        }
        private void Initialize()
        {
            IdValidator();
        }
        private void IdValidator()
        {
            RuleFor(c => c.Id)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage("O id não pode ser vazio");
        }
    }
}
