using E_Commerce.Domain.Commen;
using E_Commerce.Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Specifications
{
    internal static class SpecificationsEvaluator
    {

        public static IQueryable<TEntity> CreatQuery<TEntity, Tkey>(IQueryable<TEntity> inputQuery, ISpecifications<TEntity, Tkey> spec)
            where TEntity : BaseEntity<Tkey>
        {
            var query = inputQuery;

            if (spec.Criteria != null)
            {
                query = query.Where(spec.Criteria);
            }


            if (spec.IncludeExpressions.Any())
            {
                query = spec.IncludeExpressions.Aggregate(query, (current, netxExp) => current.Include(netxExp));
            }

            if (spec.OrderBy != null)
            {
                query = query.OrderBy(spec.OrderBy);
            }
            else if(spec.OrderByDescending != null )
            { 
                query = query.OrderByDescending(spec.OrderByDescending);    
            
            }
                return query;

        }

    }
}
