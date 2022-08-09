using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.EntityExceptions
{
    public class EntityCouldNotBeFoundException : Exception
    {
        private const string message = "Entity could not be found";
        public EntityCouldNotBeFoundException() : base(message) {}

    }
}
