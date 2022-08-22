using System.ComponentModel.DataAnnotations;

namespace Cadastro.Tarefas.Core.DTOs.Request.CadastroTarefa
{
    public class TarefaRequestAdd
    {
        [Required(ErrorMessage = "O título é obrigatório")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        public string? Descricao { get; set; }

        public DateTime DataCriacao => DateTime.Now;
    }
}