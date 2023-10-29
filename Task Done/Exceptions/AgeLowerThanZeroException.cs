using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Done.Exceptions
{
    public class AgeLowerThanZeroException : ApplicationException
    {
        private string message;
        public AgeLowerThanZeroException(string message = "Age lower than 0")
        {
            this.message = message;
        }
    }
}
