using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification()
        {
        }

        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
   
        }

        public Expression<Func<T, bool>> Criteria {get; }

        public List<Expression<Func<T, object>>> Include {get; } = new List<Expression<Func<T, object>>>();


        protected void addInclude(Expression<Func<T, object>> includeExpression)
      {
          Include.Add(includeExpression);
      }


    }
}