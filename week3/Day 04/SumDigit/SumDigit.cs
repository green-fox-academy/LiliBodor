using System;
namespace SumDigit
{
	public class SumDigit
	{
		class SumDigitsClass
		{
			public static void Main(string[] args)
			{

				Console.WriteLine("FirstDigit(222)");
			}

			public int FirstDigit(int inputNumber)
			{
				int sum = inputNumber % 10;
				if (inputNumber == 0)
				{
					return 0;
				}
				else
				{

					return sum + FirstDigit(inputNumber / 10);
				}
			}


		}
	}
}
