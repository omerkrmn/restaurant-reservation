using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Entities.Exceptions
{
    public abstract class ConflictException : Exception
    {
        protected ConflictException(string message) : base(message)
        {
        }
    }
}
