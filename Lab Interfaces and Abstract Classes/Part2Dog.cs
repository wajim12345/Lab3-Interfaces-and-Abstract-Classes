using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Interfaces_and_Abstract_Classes
{
    internal class Part2Dog : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get ; set ; }
        public float Height { get; set; }
        public int Age { get; set; }

        public Part2Dog(string name, string colour, float height, int age)
        {
            Name = name;
            Colour = colour;
            Height = height;
            Age = age;
        }

        public string Cry()
        {
            string cry = "Woof!";
            return cry;
        }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }
    }
}
