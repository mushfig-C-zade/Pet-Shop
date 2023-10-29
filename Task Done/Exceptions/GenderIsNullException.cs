using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Done.Exceptions
{
    public class GenderIsNullException : ApplicationException
    {
        private string message;
        public GenderIsNullException(string message = "Gender Is Null")
        {
            this.message = message;
        }
    }
}
