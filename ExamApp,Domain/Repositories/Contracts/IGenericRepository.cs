using ExamApp_Domain.Entities;

namespace ExamApp_Domain.Repositories.Contracts
{
    internal interface IGenericRepository<TEntity> where TEntity : BaseEntity, new()
    {
        Task CreateAsync(TEntity entity);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(int id);
    }
}
