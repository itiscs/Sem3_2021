using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = Time.CreateFromSec(10);
            Console.WriteLine(t1);

            Time t2 = Time.CreateFromTik(100);
            Console.WriteLine(t2);
            
            Time t3 = Time.CreateFromMin(2);
            Console.WriteLine(t3);

            Console.WriteLine($"Sum = {t3 - t2 - t1}");


            Time t4 = t1 + 5.00;
            Console.WriteLine(t4);


        }
    }
}
