using E_Commerce.Domain.Commen;
using E_Commerce.Domain.Contracts;
using E_Commerce.Infrastructure.Data;


namespace E_Commerce.Infrastructure.Repositories
{
    internal class UnitOfWork(StoreDbContext dbContext) : IUnitOfWork
    {
        private readonly Dictionary<string, object> repositories=[];

        public IGenericRepository<TEntity, Tkey> GetRepository<TEntity, Tkey>() where TEntity : BaseEntity<Tkey>
        {
            var typeName= typeof(TEntity).Name;

            if(repositories.TryGetValue(typeName, out object? value))
            {
                return (IGenericRepository<TEntity, Tkey>)value;
            }
            else
            {
                var repo = new GenericRepository<TEntity, Tkey>(dbContext);
                repositories[typeName] = repo;
                return repo;
            }
           
        }

        public async Task<int> SaveChangesAsync(CancellationToken ct = default) => await dbContext.SaveChangesAsync(ct);

      
    }
}
