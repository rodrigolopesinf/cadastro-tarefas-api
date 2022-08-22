using Cadastro.Tarefas.Core.DTOs.CadastroTarefas;
using Cadastro.Tarefas.Core.Interfaces.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Tarefas.Api.Controllers
{
    public class CadastroTarefasController : ApiController
    {
        private readonly ITarefaService _tarefaService;

        public CadastroTarefasController(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [AllowAnonymous]
        [HttpGet("tarefa")]
        public async Task<IActionResult> Get()
        {
            var tarefas = await _tarefaService.GetAll();
            if (tarefas?.Count() > 0)
            {
                return Ok(tarefas);
            }
            else
                return new NoContentResult();
        }

        [AllowAnonymous]
        [HttpGet("tarefa/{id:guid}")]
        public async Task<IActionResult> Get(int id)
        {
            var tarefa = await _tarefaService.GetById(id);
            if (tarefa != null)
            {
                return Ok(tarefa);
            }
            else
                return new NoContentResult();
        }

        [HttpPost("tarefa")]
        public async Task<IActionResult> Post([FromBody] TarefasDto tarefaDto)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _tarefaService.Save(tarefaDto));
        }

        [HttpPut("tarefa")]
        public async Task<IActionResult> Put([FromBody] TarefasDto tarefaDto)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _tarefaService.Update(tarefaDto));
        }

        [HttpDelete("tarefa")]
        public async Task<IActionResult> Delete(int id)
        {
            return CustomResponse(await _tarefaService.Remove(id));
        }
    }
}