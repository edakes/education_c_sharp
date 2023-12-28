using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{    
    //find number array2 numara adedi ve numara bulma
    internal class array2
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 10, 2, 0, 10, 33, 33, 4, 5, 6, 7, 8, 9, 8, 8, 8, 9 };
            int adet = 0;
            Console.Write("değer giriniz : ");
            int deger = Convert.ToInt16(Console.ReadLine());


            for (int i = 0; i < numbers.Length; i++)
            {
                if (deger == numbers[i])
                {
                    adet++;

                }
            }
                if (adet == 0)
                {
                    Console.WriteLine("null.");

                }
                else
                {
                    Console.WriteLine("not null");
                    Console.WriteLine("adedi: " +adet);
                }

                Console.ReadLine();
            }
            
        }
    }

