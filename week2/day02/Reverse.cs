using System;

namespace Reverse
{
	public class Reverse
	{
		public static void Main(string[] args)
		{
			string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

			Console.WriteLine(Reversed(reversed));


		}

		static string Reversed(string reversedReverese)
		{
			string reserve = "";

			for (int i = reversedReverese.Length - 1; i >= 0; i--)
			{
				reserve += reversedReverese[i];
			}
			return  reserve;
		
		
			}
		}
	}
       