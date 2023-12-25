using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 10000;
            Console.WriteLine("hoşgeldiniz...");
            Console.WriteLine("lütfen yöntem seçiniz" +
                " 1.bakiye görüntüle" +
                " 2.para çekme" +
                " 3.para yatırma" +
                " 4 kapatma");
            string  secim = Console.ReadLine();

            if (secim =="1" )
            {
                Console.WriteLine("bakiyenizde ki mevcut para :" + bakiye);
                Console.ReadLine();
            }
            else if (secim == "2")
            {
                Console.Write("çekilecek bakiye : ");
                int cekilen_miktar = Convert.ToInt32(Console.ReadLine());
                if (cekilen_miktar <= bakiye)
                {
                   
                    Console.WriteLine("kalan bakiye: " + (bakiye - cekilen_miktar));
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("tekrar giriniz");
                    Console.ReadLine();
                    
                    
                }

            }
            else if (secim == "3")
            {
                Console.Write("yüklenecek bakiye: ");
                int yuklenen_miktar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("anlık bakiyeniz : "+(bakiye + yuklenen_miktar));
                Console.ReadLine();
            }
            else if (secim =="4" )
            {
                Console.WriteLine("kapanıyor...");
                Console.ReadLine();

            }
        }

    }
}
