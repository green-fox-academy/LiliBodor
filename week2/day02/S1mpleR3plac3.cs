using System;

namespace SimpleReplace
{
	public class SimpleReplace
	{
		public static void Main(string[] args)
		{
			string example = "In a dishwasher far far away";

			example = example.Replace("dishwasher", "galaxy");


			Console.WriteLine(example);
		}
	}
}

