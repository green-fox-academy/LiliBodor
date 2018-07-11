using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Model;

namespace WebApplication2.Services
{
    public class HomeService
    {

        public int Sum(Number input)
        {
            int summer = 0;

            for (int i = 0; i <= input.Until; i++)
            {
                summer += i;
            }
            return summer;
        }

        public int Factor(Number input)
        {
            int factor = 1;

            for (int i = 1; i <= input.Until; i++)
            {
                factor *= i;
            }
            return factor;
        }

        public int Sum(WithArray input)
        {
            int summer = input.Numbers.Sum();
            return summer;
        }

        public int Multiply(WithArray input)
        {
            int multiplyer = 1;

            for (int i = 1; i < input.Numbers.Length; i++)
            {
                multiplyer *= input.Numbers[i];
            }
            return multiplyer;
        }
    }
}
