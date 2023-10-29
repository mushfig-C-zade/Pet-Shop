using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Done.Exceptions
{
    public class AgeUpperThanFiveHundred : ApplicationException
    {
        private string message;
        public AgeUpperThanFiveHundred(string message = "Age upper than 500")
        {
            this.message = message;
        }
    }
}
