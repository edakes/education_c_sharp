using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sınıf metodlarını buraya çağırırız
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            Console.ReadLine();

        }
    }
    //sınıf metodu bu şekilde alt alta verilebilir
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("customer added!");
        }
        public void Update() 
        {
            Console.WriteLine("customer update!");
        }
    }
}
