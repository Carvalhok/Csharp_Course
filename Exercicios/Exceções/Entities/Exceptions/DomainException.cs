using System;

namespace Exceções.Entities.Exceptions
{
    class DomainException: ApplicationException
    {
        public string message { get; set; }

        public DomainException(string message) :base(message)
        {
        }
    }
}
