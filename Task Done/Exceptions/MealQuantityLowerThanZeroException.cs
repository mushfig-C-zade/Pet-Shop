using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Done.Exceptions
{
    public class MealQuantityLowerThanZeroException : ApplicationException
    {
        private string message;
        public MealQuantityLowerThanZeroException(string message = "MealQuantity lower than 0")
        {
            this.message = message;
        }
    }
}
