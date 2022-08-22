using System.ComponentModel.DataAnnotations;

namespace Cadastro.Tarefas.Core.DTOs.CadastroTarefas
{
    public class TarefasDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        public string? Descricao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }

    }    
}