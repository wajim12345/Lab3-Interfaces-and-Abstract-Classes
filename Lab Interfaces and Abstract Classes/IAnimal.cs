using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Interfaces_and_Abstract_Classes
{
    internal interface IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public float Height { get; set; }
        public int Age { get; set; }

        public abstract void Eat();
        public string Cry();

    }
}
