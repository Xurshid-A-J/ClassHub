using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions.Permissions
{
    public class NotFoundException<TModel>:Exception where TModel:class
    {
        public NotFoundException(Guid Id):base(message:$"Could not find {nameof(TModel)} with id : {Id}")
        { }
    }
}
