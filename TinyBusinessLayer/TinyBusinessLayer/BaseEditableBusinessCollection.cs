using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TinyBusinessLayer.Interfaces;

namespace TinyBusinessLayer
{
    /// <summary>
    /// A base collection to handle editable business objects.
    /// </summary>
    /// <typeparam name="TBusinessObject">The type of the business object.</typeparam>
    public abstract class BaseEditableBusinessCollection<TBusinessObject>
        : BaseBusinessObjectCollection<TBusinessObject>, IEditableBusinessCollection<TBusinessObject>
        where TBusinessObject : IBusinessObject
    {

    }
}