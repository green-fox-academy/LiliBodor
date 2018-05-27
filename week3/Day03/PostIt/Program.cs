using System;

namespace PostIt
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			PostIt postItFirstOne = new PostIt("orange","blue", "Idea1");
			PostIt postItSecondOne = new PostIt("pink", "black", "Awesome");
			PostIt postItThirdOne = new PostIt("yellow", "green", "Superb!");

			Console.WriteLine(postItSecondOne.textColor);
        }

    }
}
