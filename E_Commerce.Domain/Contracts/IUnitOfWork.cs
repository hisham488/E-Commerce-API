using E_Commerce.Domain.Commen;

namespace E_Commerce.Domain.Contracts
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync (CancellationToken ct = default);
        IGenericRepository<TEntity, Tkey> GetRepository<TEntity, Tkey>() where TEntity : BaseEntity<Tkey>;
    }
}
