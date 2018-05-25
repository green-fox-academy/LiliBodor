using System;

namespace Bunny
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numberOfBunnies;


            Console.WriteLine("Number of bunnies: ");
            numberOfBunnies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of ears: ");
			//earsOfTheBunnies = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(BunnoBunny(numberOfBunnies));

        }
        public static int BunnoBunny(int numberOfBunnies)
        {
			if (numberOfBunnies == 1)
            {
                return 2;
            }
            else
            {
				return 2 + BunnoBunny(numberOfBunnies - 1);
            }
        }
    }
}
