namespace Cadastro.Tarefas.Core.Models.Tarefas
{
    public class Tarefas
    {
        public Tarefas(int id, string titulo, string descricao, DateTime dataCriacao, DateTime? dataAtualizacao)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            DataCriacao = dataCriacao;
            DataAtualizacao = dataAtualizacao;
        }

        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime? DataAtualizacao { get; private set; }
    }
}