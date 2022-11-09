using System;
using System.ComponentModel.DataAnnotations;

namespace Ordering.Application.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, object key) : base($"Entity \"{name}\" ({key} was not found.")
        {

        }
    }
}
