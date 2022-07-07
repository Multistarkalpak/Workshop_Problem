using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    internal class Powerof2
    {
        public void Poweroftwo()
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number < 0 || number > 31)
            {
                Console.WriteLine("Enter the valid number");
            }
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }

        }
    }
}
