using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Entities.Exceptions
{
    public sealed class EntityNotFoundException<T> : NotFoundException
        where T : class
    {
        public EntityNotFoundException(int id) : base($"The {typeof(T).Name} with ID: {id} could not be found.")
        {
        }
    }
}
