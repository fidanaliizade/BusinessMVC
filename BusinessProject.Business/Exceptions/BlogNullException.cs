using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.Business.Exceptions
{
    public class BlogNullException : Exception
    {
        public BlogNullException():base("Blog can't be null.")
        {
            
        }
        public BlogNullException(string? message) : base(message)
        {
        }
    }
}
