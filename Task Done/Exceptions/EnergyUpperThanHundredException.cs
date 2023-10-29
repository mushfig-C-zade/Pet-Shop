using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Done.Exceptions
{
    public class EnergyUpperThanHundredException : ApplicationException
    {
        private string message;
        public EnergyUpperThanHundredException(string message = "Energy upper than 100")
        {
            this.message = message;
        }
    }
}
