using System.Collections.Generic;
using System.Linq.Expressions;

namespace TinyBusinessLayer.Framework
{
    /// <summary>
    /// 
    /// </summary>
    public class ParameterRebinder
        : ExpressionVisitor
    {
        private readonly Dictionary<ParameterExpression, ParameterExpression> map;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterRebinder"/> class.
        /// </summary>
        /// <param name="map">The map.</param>
        public ParameterRebinder(Dictionary<ParameterExpression, ParameterExpression> map)
        {
            this.map = map ?? new Dictionary<ParameterExpression, ParameterExpression>();
        }

        /// <summary>
        /// Replaces the parameters.
        /// </summary>
        /// <param name="map">The map.</param>
        /// <param name="expression">The exp.</param>
        /// <returns></returns>
        public static Expression ReplaceParameters(Dictionary<ParameterExpression, ParameterExpression> map, Expression expression)
        {
            return new ParameterRebinder(map).Visit(expression);
        }

        /// <summary>
        /// Visits the parameter.
        /// </summary>
        /// <param name="node">The first node.</param>
        /// <returns></returns>
        protected override Expression VisitParameter(ParameterExpression node)
        {
            ParameterExpression replacement;
            if (map.TryGetValue(node, out replacement))
            {
                node = replacement;
            }
            return base.VisitParameter(node);
        }
    }
}
