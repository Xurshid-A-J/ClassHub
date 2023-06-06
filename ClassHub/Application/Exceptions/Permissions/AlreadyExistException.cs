using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions.Permissions
{
    public class AlreadyExistException<TModel>:Exception
    {
        public AlreadyExistException(string name) :base($" {typeof(TModel).Name} with name : {name} , already exists")
        { }
    }
}
