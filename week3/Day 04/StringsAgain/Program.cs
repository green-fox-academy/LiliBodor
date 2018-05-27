using System;
namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(XRemover("xoxo"));
            Console.ReadLine();
        }
        public static string XRemover(string remover)
        {
			if (remover == "")
            {
                return null;
            }
            else
            {
                char allTheX;
                if (remover[0] == 'x')
                {
					allTheX = ' ';
                }
                else
                {
					allTheX = remover[0];
                }
				return allTheX+ XRemover(remover.Remove(0, 1));
            }
        }
    }
}