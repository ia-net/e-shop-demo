using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class BaseSpecification<T>(Expression<Func<T, bool>>? criteria) : ISpecification<T>
    {
        protected BaseSpecification() : this(null) { }
        public Expression<Func<T, bool>>? Criteria => criteria;
        public Expression<Func<T, object>>? OrderBy { get; private set; }
        public Expression<Func<T, object>>? OrderByDecending {get; private set; }

        public bool IsDistinst { get; private set; }

        public int Take { get; private set; }

        public int Skip { get; private set; }

        public bool IsPaginEnabled { get; private set; }

        public IQueryable<T> ApplyCriteria(IQueryable<T> query)
        {
            if (Criteria is not null)
            {
                query = query.Where(Criteria);
            }

            return query;
        }

        protected void AddOrderBy(Expression<Func<T, object>> orderByExpression)
        {
            OrderBy = orderByExpression;
        }
        
        protected void AddOrderByDescending(Expression<Func<T, object>> orderByDescExpression)
        {
            OrderByDecending = orderByDescExpression;
        }

        protected void ApplyDistinct()
        {
            IsDistinst = true;
        }

        protected void ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            IsPaginEnabled = true;
        }

    }

    public class BaseSpecification<T, TResult>(Expression<Func<T, bool>>? criteria)
        : BaseSpecification<T>(criteria), ISpecification<T, TResult>
    {
        protected BaseSpecification() : this(null!) { }
        public Expression<Func<T, TResult>>? Select { get; private set; }

        protected void AddSelect(Expression<Func<T, TResult>> selectExpression)
        {
            Select = selectExpression;
        }
    }
}
