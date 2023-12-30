using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametreler
{
    internal class Parametre
    {
        //parametre kullanımı 
        static void Main(string[] args)
        {
            //metotlar çağırılır
            AdiniYazdir();
            Toplama(8,7);
            Carpma(2,5);
        }
        //VOİD geriye değer döndürmez
        //PARAMETRESİZ METOT
        static void AdiniYazdir()
        {
            Console.Write("adınız: ");
            Console.ReadLine();
        }
        //PARAMETRELİ METOT
        static void Toplama(int n,int y)
        {
            Console.WriteLine(n+y);
            Console.ReadLine();
        }
        //geriye değer döndürmek
        static int Carpma(int n,int y)
        {
            int sonuc = n * y;
            return sonuc; 
            //returndan sonra yazılan kodlar çalışmaz
            //ve değerleri döndürür

        }
    }
}
