using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Done.Exceptions
{
    public class PriceLowerThanZeroException : ApplicationException
    {
        private string message;
        public PriceLowerThanZeroException(string message = "Price lower than 0")
        {
            this.message = message;
        }
    }
}
