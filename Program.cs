using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition2
{
    internal class Program
    {
        static void Main(string[] args)                       //Height weight index in condition
        {
            Console.WriteLine("Enter your weight: ");
            int weight=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double hwi=Convert.ToDouble(weight/(height*height));

            if(hwi<18)
            {
                Console.WriteLine("You are weak!");
                Console.ReadLine();
            }
            else if (hwi >18 && hwi <25)
            {
                Console.WriteLine("You're normal...");
                Console.ReadLine();
            }
            else if(hwi>25)
            {
                Console.WriteLine("You are obese");
                Console.ReadLine();
            }
        }
    }
}
