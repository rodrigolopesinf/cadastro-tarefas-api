using AutoMapper;
using Cadastro.Tarefas.Core.DTOs.CadastroTarefas;
using Cadastro.Tarefas.Core.DTOs.Request.CadastroTarefa;

namespace Cadastro.Tarefas.Core.AutoMapper
{
    public class RequestToDtoMappingProfile : Profile
    {
        public RequestToDtoMappingProfile()
        {
            CreateMap<TarefaRequestAdd, TarefasDto>();
            CreateMap<TarefasDto, TarefaRequestAdd>();

            CreateMap<TerefaRequestUpdate, TarefasDto>();
            CreateMap<TarefasDto, TerefaRequestUpdate>();
        }
    }
}