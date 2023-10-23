using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Interfaces_and_Abstract_Classes
{
    internal class Dog : Animal
    {
        public Dog(string name, string colour, int age) : base(name, colour, age)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }
    }
}
