using System;
using System.Text;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

			StringBuilder quoteBuiler = new StringBuilder(quote);

			quoteBuiler.Insert(21, "always takes longer than ");

			Console.WriteLine(quoteBuiler);
        }
    }
}