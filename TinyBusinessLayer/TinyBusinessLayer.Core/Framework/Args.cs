using System;
using System.Linq.Expressions;

namespace TinyBusinessLayer.Core.Framework
{
    public static class Args
    {
        public static void IsNotNull(params Expression<Func<Object>>[] expressions)
        {
            if (expressions != null)
            {
                foreach (var expression in expressions)
                {
                    if (expression.Compile().Invoke() == null)
                    {
                        throw new ArgumentNullException((expression.Body as MemberExpression).Member.Name);
                    }
                }
            }
        }
    }
}
