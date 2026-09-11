using E_Commerce.Domain.Commen;
using E_Commerce.Domain.Contracts;
using System.Linq.Expressions;

namespace E_Commerce.Application.Specifications
{
    internal class BaseSpecification<TEntity, Tkey> : ISpecifications<TEntity, Tkey> where TEntity : BaseEntity<Tkey>
    {
        public ICollection<Expression<Func<TEntity, object>>> IncludeExpressions { get; } = [];

        public Expression<Func<TEntity, bool>> Criteria { get; private set; }

        public Expression<Func<TEntity, object>>? OrderBy {  get; private set; }

        public Expression<Func<TEntity, object>>? OrderByDescending {  get; private set; }

        protected void AddOrderBy(Expression<Func<TEntity, object>> OrderByExpression)
        {
            OrderBy = OrderByExpression;
        }
        protected void AddOrderDescBy(Expression<Func<TEntity, object>> OrderByDescExpression)
        {
            OrderByDescending = OrderByDescExpression;
        }

        public BaseSpecification(Expression<Func<TEntity, bool>> criteria)
        {
            Criteria = criteria;
        }

        protected void AddInclude(Expression<Func<TEntity, object>> include)
        {
            IncludeExpressions.Add(include);
        }
    }
}
