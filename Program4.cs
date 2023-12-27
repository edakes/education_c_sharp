using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    
   
    //asal sayi primar number
    internal class Program4
    {    
        static void Main(string[] args)
        {
            if (IsPrimeNumber(6)){
                Console.WriteLine("this is a prime number");
            }
            else {
                Console.WriteLine("this is not prime number");
                 }
            Console.ReadLine();
        }


         private static bool IsPrimeNumber(int number)
         {
                bool result = true;
                
                for (int i = 2;i <number-1;i++)
                {
                 if (number % i==0)
                    {
                        result = false;
                        i = number;
                    }
                } 
                return result;
         }
        }
    }

