using System;

namespace SumDigit
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine(FirstDigit(222));
        }

        public static int FirstDigit(int inputNumber)
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

