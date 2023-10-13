using System;

namespace mysalles.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base(message) 
        {

        }
    }
}
