namespace Cadastro.Tarefas.Core.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        void Save(T model);
        void Update(T model);
        void Remove(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);        
    }
}