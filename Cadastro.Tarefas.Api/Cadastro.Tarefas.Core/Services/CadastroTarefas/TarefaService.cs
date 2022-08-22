using AutoMapper;
using Cadastro.Tarefas.Core.DTOs.CadastroTarefas;
using Cadastro.Tarefas.Core.Interfaces.Repositories;
using Cadastro.Tarefas.Core.Models.CadastroTarefas;
using Cadastro.Tarefas.Core.Models.Tarefas;
using FluentValidation.Results;

namespace Cadastro.Tarefas.Core.Services.CadastroTarefas
{
    public class TarefaService : ITarefaService
    {
        private readonly IMapper _mapper;
        private readonly ITarefaRepository _repository;

        public TarefaService(IMapper mapper, ITarefaRepository repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TarefasDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<TarefasDto>>(await _repository.GetAll());
        }

        public async Task<TarefasDto> GetById(int id)
        {
            return _mapper.Map<TarefasDto>(await _repository.GetById(id));
        }

        public Task<ValidationResult> Save(TarefasDto tarefaDto)
        {
            TarefaValidator validator = new TarefaValidator();
            var tarefa = _mapper.Map<Tarefa>(tarefaDto);
            var tarefaValidate = validator.ValidateAsync(tarefa);
            if (tarefaValidate.Result.IsValid)
            {
                _repository.Save(tarefa);
            }

            return tarefaValidate;
        }

        public Task<ValidationResult> Update(TarefasDto tarefaDto)
        {
            TarefaValidator validator = new TarefaValidator();
            var tarefa = _mapper.Map<Tarefa>(tarefaDto);
            var tarefaValidate = validator.ValidateAsync(tarefa);
            if (tarefaValidate.Result.IsValid)
            {
                _repository.Update(tarefa);
            }

            return tarefaValidate;
        }

        public Task<ValidationResult> Remove(int id)
        {
            TarefaRemoveValidator validator = new TarefaRemoveValidator();
            var tarefaValidate = validator.ValidateAsync(new Tarefa() { Id = id });
            if (tarefaValidate.Result.IsValid)
            {
                _repository.Remove(id);
            }

            return tarefaValidate;

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}