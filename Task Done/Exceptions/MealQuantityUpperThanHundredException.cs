using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Done.Exceptions
{
    public class MealQuantityUpperThanHundredException: ApplicationException
    {
        private string message;
        public MealQuantityUpperThanHundredException(string message = "MealQuantity upper than 100")
        {
            this.message = message;
        }
    }
}
