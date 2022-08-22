using AutoMapper;
using Cadastro.Tarefas.Core.DTOs.CadastroTarefas;
using Cadastro.Tarefas.Core.Models.Tarefas;

namespace Cadastro.Tarefas.Core.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Tarefa, TarefasDto>();
            CreateMap<TarefasDto, Tarefa>();
        }
    }
}
