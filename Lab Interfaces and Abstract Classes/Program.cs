namespace Lab_Interfaces_and_Abstract_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");
            Console.WriteLine("What is the name of the dog?");
            string dogName = Console.ReadLine();
            Console.WriteLine("What is the colour of the dog?");
            string dogColour = Console.ReadLine();
            Console.WriteLine("What is the age of the dog?");
            int dogAge = Convert.ToInt32(Console.ReadLine());

            Dog dog = new Dog(dogName, dogColour, dogAge);
            dog.Eat();

            Console.WriteLine("What is the name of the cat?");
            string catName = Console.ReadLine();
            Console.WriteLine("What is the colour of the cat?");
            string catColour = Console.ReadLine();
            Console.WriteLine("What is the age of the cat?");
            int catAge = Convert.ToInt32(Console.ReadLine());

            Cat cat = new Cat(catName, catColour, catAge);
            cat.Eat();

            Console.WriteLine("Part 2");
            Console.WriteLine("What is the name of the dog?");
            string dog2Name = Console.ReadLine();
            Console.WriteLine("What is the colour of the dog?");
            string dog2Colour = Console.ReadLine();
            Console.WriteLine("What is the height of the dog?");
            float dog2Height = float.Parse(Console.ReadLine());
            Console.WriteLine("What is the age of the dog?");
            int dog2Age = Convert.ToInt32(Console.ReadLine());

            Part2Dog dog2 = new Part2Dog(dog2Name, dog2Colour, dog2Height, dog2Age);
            dog2.Eat();
            Console.WriteLine(dog2.Cry());

            Console.WriteLine("What is the name of the cat?");
            string cat2Name = Console.ReadLine();
            Console.WriteLine("What is the colour of the cat?");
            string cat2Colour = Console.ReadLine();
            Console.WriteLine("What is the height of the cat?");
            float cat2Height = float.Parse(Console.ReadLine());
            Console.WriteLine("What is the age of the cat?");
            int cat2Age = Convert.ToInt32(Console.ReadLine());

            Part2Cat cat2 = new Part2Cat(cat2Name, cat2Colour, cat2Height, cat2Age);
            cat2.Eat();
            Console.WriteLine(cat2.Cry());

            //Create List of animals
            List<IAnimal> animals = new List<IAnimal>();
            Part2Cat animal1 = new Part2Cat("Tom", "Black", 50.6f, 2);
            animals.Add(animal1);
            Part2Dog animal2 = new Part2Dog("Jack", "Brown", 100.3f, 3);
            animals.Add(animal2);
            Part2Cat animal3 = new Part2Cat("Maru", "Grey", 43.6f, 5);
            animals.Add(animal3);
            Part2Dog animal4 = new Part2Dog("Orochi", "White", 74.3f, 4);
            animals.Add(animal4);

            //Print Animal names
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }


        }
    }
}