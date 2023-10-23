using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Interfaces_and_Abstract_Classes
{
    internal class Part2Cat : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public float Height { get; set; }
        public int Age { get; set; }

        public Part2Cat(string name, string colour, float height, int age)
        {
            this.Name = name;
            this.Colour = colour;
            this.Height = height;
            this.Age = age;
        }
        public string Cry()
        {
            string cry = "Meow!";
            return cry;
        }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }
    }
}
