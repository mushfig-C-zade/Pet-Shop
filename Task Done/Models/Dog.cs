using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Done.Main
{
    public class Dog : Animal
    {
        public Dog(string nickname, int age, string gender, int energy, int price, int mealQuantity) : base(nickname, age, gender, energy, price, mealQuantity)
        {

        }
    }
}
