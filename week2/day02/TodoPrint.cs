using System;
using System.Text;

namespace TodoPrint
{
    public class TodoPrint
    {
        public static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";

			StringBuilder todoTextBuilder = new StringBuilder(todoText);

			todoTextBuilder.Insert(0, "My todo:\n");
			todoTextBuilder.Append(" - Download games");
			todoTextBuilder.Append("\n\t- Diablo");
            

			Console.WriteLine(todoTextBuilder);
        }
    }
}