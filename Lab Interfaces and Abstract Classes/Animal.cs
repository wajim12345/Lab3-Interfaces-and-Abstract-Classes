using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Interfaces_and_Abstract_Classes
{
    abstract class Animal
    {
        private string name;
        private string colour;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Colour
        {
            get
            {
                return colour;
            }
            set
            {
                colour = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age > 0)
                {
                    age = value;
                }
            }
        }
        public Animal(string name, string colour, int age)
        {
            this.Name = name;
            this.Colour = colour;
            this.Age = age;
        }
        public abstract void Eat();

    }
}
