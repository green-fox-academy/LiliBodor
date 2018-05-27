using System;

namespace StringOne
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(Changex("xoxo"));
            Console.ReadLine();
        }
        public static string Changex(string xoxo)
        {

			if (xoxo == "")
            {
                return null;
            }
			else
            {
                char findTheX;
                
                if (xoxo[0] == 'x')
                {
					findTheX = 'y';
                }

				else
				{
					findTheX = xoxo[0];
				}
				return findTheX + Changex(xoxo.Remove(0, 1));
            }
        }
    }
}
