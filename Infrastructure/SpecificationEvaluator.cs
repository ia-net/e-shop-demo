using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class SpecificationEvaluator<T> where T : BaseEntity
    {
        public static IQueryable<T> GetQuery(IQueryable<T> query, ISpecification<T> spec)
        {
            if (spec.Criteria is not null)
            {
                query = query.Where(spec.Criteria); // x => x.ProductTypeId == id
            }

            if (spec.OrderBy is not null)
            {
                query = query.OrderBy(spec.OrderBy);
            }

            if (spec.OrderByDecending is not null)
            {
                query = query.OrderByDescending(spec.OrderByDecending);
            }

            if (spec.IsDistinst)
            {
                query = query.Distinct();
            }

            if (spec.IsPaginEnabled)
            {
                query = query.Skip(spec.Skip).Take(spec.Take);
            }

            return query;
        }



        public static IQueryable<TResult> GetQuery<TSpec, TResult>(IQueryable<T> query, ISpecification<T, TResult> spec)
        {
            if (spec.Criteria is not null)
            {
                query = query.Where(spec.Criteria); // x => x.ProductTypeId == id
            }

            if (spec.OrderBy is not null)
            {
                query = query.OrderBy(spec.OrderBy);
            }

            if (spec.OrderByDecending is not null)
            {
                query = query.OrderByDescending(spec.OrderByDecending);
            }


            var selectQuery = query as IQueryable<TResult>;

            if (spec.Select is not null)
            {
                selectQuery = query.Select(spec.Select);
            }

            if (spec.IsDistinst)
            {
                selectQuery = selectQuery?.Distinct();
            }

            if (spec.IsPaginEnabled)
            {
                selectQuery = selectQuery?.Skip(spec.Skip).Take(spec.Take);
            }

            return selectQuery ?? query.Cast<TResult>();
        }
    }
}
