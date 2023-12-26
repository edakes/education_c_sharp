using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //User login test (kullanıcı girişi test)
            int trial = 3;
            while (true)
            {
                Console.WriteLine("please enter your nickname: ");
                string nickname = Console.ReadLine();

                Console.WriteLine("please enter your password: ");
                string pasword = Console.ReadLine();

                if (nickname == "butterfly" && pasword == "123")
                {
                    Console.WriteLine("correct...");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("nickname or password is incorrect");

                    if (trial > 0)
                    {
                        Console.WriteLine("Log in again!");
                        trial--;
                       
                    }
                    if (trial == 0)
                    {
                        Console.WriteLine("Not allowed to log in");
                            break;
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
