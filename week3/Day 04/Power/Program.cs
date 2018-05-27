using System;

namespace Power
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int baseInt = 1;
			int npower = 1;
			Console.WriteLine("Enter the base: ");
			baseInt = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the power: ");
			npower = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Result is:");
			Console.WriteLine(PowerRecursion(baseInt, npower));
			Console.ReadLine();
		}
		public static int PowerRecursion(int baseInt, int npower)
		{
			if (npower == 0)
			{
				return 1;
			}
			else
			{
				return baseInt * PowerRecursion(baseInt, npower - 1);
			}
		}
	}
}
