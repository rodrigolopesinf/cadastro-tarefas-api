using Cadastro.Tarefas.Core.Models.Tarefas;
using FluentValidation;

namespace Cadastro.Tarefas.Core.Models.CadastroTarefas
{
    public class TarefaValidator : AbstractValidator<Tarefa>
    {
        public TarefaValidator()
        {
            Initialize();
        }
        private void Initialize()
        {
            TituloValidator();
            DescricaoValidator();
        }
        private void TituloValidator()
        {
            RuleFor(c => c.Titulo)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage("O Título é obrigatório");
        }

        private void DescricaoValidator()
        {
            RuleFor(c => c.Titulo)
                   .NotNull()
                   .NotEmpty()
                   .WithMessage("A Descrição é obrigatória");
        }
    }
}