namespace Cadastro.Tarefas.Core.DTOs.CadastroTarefas
{
    public class TarefasDto
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }

        public TarefasDto SetarId(int id)
        {
            Id = id;
            return this;
        }

        public TarefasDto SetarTitulo(string titulo)
        {
            Titulo = titulo;
            return this;
        }

        public TarefasDto SetarDescricao(string descricao)
        {
            Descricao = descricao;
            return this;
        }

        public TarefasDto SetarDataCriacao(DateTime dataCriacao)
        {
            DataCriacao = dataCriacao;
            return this;
        }

        public TarefasDto SetarDataAtualizacao(DateTime dataAtualizacao)
        {
            DataAtualizacao = dataAtualizacao;
            return this;
        }
    }    
}
