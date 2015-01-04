using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TinyBusinessLayer.Interfaces;

namespace TinyBusinessLayer
{
    /// <summary>
    /// A base collection to handle business objects that can't be modified.
    /// </summary>
    /// <typeparam name="TBusinessObject">The type of the business object.</typeparam>
    public abstract class BaseReadOnlyBusinessCollection<TBusinessObject>
        : BaseBusinessObjectCollection<TBusinessObject>, IReadOnlyBusinessCollection<TBusinessObject>
        where TBusinessObject : IBusinessObject
    {

    }
}