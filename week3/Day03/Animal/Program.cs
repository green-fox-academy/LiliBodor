using System;

namespace Animal
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Animal giraffe = new Animal(50, 50);

			giraffe.Eating();
			giraffe.Drinking();
			giraffe.Playing();

			Console.WriteLine("Your giraffe is " + giraffe.hunger + " hungry!");
			Console.WriteLine("Your giraffe is " + giraffe.thirst + " thirsty");
        }
    }
}
