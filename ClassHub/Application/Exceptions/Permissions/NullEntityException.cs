using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions.Permissions
{
    public class NullEntityException<TModel>:Exception
    {
        public NullEntityException() : base($"Null {nameof(TModel)} error occured") 
        { }
    }
}
