using System;

namespace ChangeElement
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] s = { 1, 2, 3, 8, 5, 6 };

			int newS = 4;

			s[3] = newS;

			Console.WriteLine(s[3]);
				
          
            Console.ReadLine();
        }
    }
}