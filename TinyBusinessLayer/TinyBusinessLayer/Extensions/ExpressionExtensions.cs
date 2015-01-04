using System;
using System.Linq;
using System.Linq.Expressions;
using TinyBusinessLayer.Framework;

namespace TinyBusinessLayer.Extensions
{
    /// <summary>
    /// Based loosely on similar class from https://huyrua.wordpress.com/2010/08/25/specification-pattern-in-entity-framework-4-revisited/
    /// </summary>
    public static class ExpressionExtensions
    {
        /// <summary>
        /// Composes the specified specifications together.
        /// </summary>
        /// <typeparam name="TBusinessObject">The type of the business object.</typeparam>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <param name="merge">The merge expression.</param>
        /// <returns></returns>
        public static Expression<TBusinessObject> Compose<TBusinessObject>(this LambdaExpression first, Expression<TBusinessObject> second, Func<Expression, Expression, Expression> merge)
        {
            Args.IsNotNull(() => first);
            Args.IsNotNull(() => merge);

            // build parameter map (from parameters of second to parameters of first)
            var map = first.Parameters.Select((f, i) => new { f, s = second.Parameters[i] }).ToDictionary(p => p.s, p => p.f);

            // replace parameters in the second lambda expression with parameters from the first
            var secondBody = ParameterRebinder.ReplaceParameters(map, second.Body);

            // apply composition of lambda expression bodies to parameters from the first expression
            return Expression.Lambda<TBusinessObject>(merge(first.Body, secondBody), first.Parameters);
        }

        /// <summary>
        /// Ands the specified first expression with the second expression.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> And<T>(this LambdaExpression first, Expression<Func<T, bool>> second)
        {
            return first.Compose(second, Expression.And);
        }

        /// <summary>
        /// Ors the specified first expression with the second expression.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> Or<T>(this LambdaExpression first, Expression<Func<T, bool>> second)
        {
            return first.Compose(second, Expression.Or);
        }
    }
}
