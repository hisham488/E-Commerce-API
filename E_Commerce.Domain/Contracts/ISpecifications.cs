
using E_Commerce.Domain.Commen;
using System.Linq.Expressions;

namespace E_Commerce.Domain.Contracts
{
    public interface ISpecifications<TEntity , Tkey> where TEntity : BaseEntity<Tkey>
    {
        ICollection<Expression<Func<TEntity , object>>> IncludeExpressions { get; }
        Expression<Func<TEntity , bool>> Criteria { get; }
        Expression<Func<TEntity , object>> OrderBy { get; }
        Expression<Func<TEntity , object>> OrderByDescending { get; }


    }
}
