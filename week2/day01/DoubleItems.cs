using System;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] numList = { 3, 4, 5, 6, 7 };

			for (int i = 0; i < numList.Length; i++)
			{
				Console.WriteLine(numList[i] *= 2);
			}
            Console.ReadLine();
        }
    }
}