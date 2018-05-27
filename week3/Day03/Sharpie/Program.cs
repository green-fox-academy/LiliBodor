using System;

namespace Sharpie
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Sharpie greenSharpie = new Sharpie("green", 2);

			greenSharpie.Use();

			Console.WriteLine(greenSharpie.inkamount);
        }
    }
}
