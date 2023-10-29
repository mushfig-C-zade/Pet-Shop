using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Done.Exceptions
{
    public class NicknameIsNullException:ApplicationException
    {
        private string message;
        public NicknameIsNullException(string message = "Nickname Is Null")
        {
            this.message = message;
        }
    }
}
