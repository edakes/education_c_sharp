using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametre2
{
    internal class Parametre2
    {    
        //tek çift sayı bulma parametre ile yapımı
        static void Main(string[] args)
        {
            Console.Write("değer giriniz: ");
            

            int girilenSayi = int.Parse(Console.ReadLine());
            TekCift(girilenSayi);
            Console.ReadLine();
        }

       
        static int TekCift(int a)
        {
            if(a%2==0)
            {
                Console.WriteLine("sayı çifttir.");
            }
            else { Console.WriteLine("sayı tektir."); }
            return a;
        }
    }
}
