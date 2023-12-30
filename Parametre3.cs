using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametre3
{
    internal class Parametre3
    {
        //hangi sayı büyük parametre ile yapımı
        static void Main(string[] args)
        {
            Console.Write("ik sayı : ");
           int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("ikinci sayı : ");
            int sayi2 = int.Parse(Console.ReadLine());

            Hangisi(sayi1, sayi2);
            Console.ReadLine();


        }
        static int Hangisi(int a,int b)
        {
            if (a > b)
            {
                Console.WriteLine("ilk sayı büyük");
            }
            else { Console.WriteLine("ikinc sayı büyük"); }
             return a;
        }
    }
}
