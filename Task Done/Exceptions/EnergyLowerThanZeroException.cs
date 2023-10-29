using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Done.Exceptions;

public class EnergyLowerThanZeroException : ApplicationException
{
    private string message;
    public EnergyLowerThanZeroException(string message = "Energy lower than 0")
    {
        this.message = message;
    }
}
