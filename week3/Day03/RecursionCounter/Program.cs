using System;

namespace RecursionCounter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n;
            n = 8;
			Console.WriteLine(Recursion(n));

        }

        public static int Recursion(int n)
        {
            
			if (n == 1)
			{
				return 1;

			}
            
			else
			{
				Console.WriteLine(n);
                return Recursion(n - 1);


            }
        }
    }
}