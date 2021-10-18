using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"\d{3,15}");

            Regex reg2 = new Regex(@"^#?([A-Fa-f0-9]){3}(([A-Fa-f0-9]){3})?$");

            Console.WriteLine(reg2.Match("#444444"));
            

            var str = "56576575876987973   he43llo";
            
            Console.WriteLine(reg.IsMatch(str));

            foreach (var m in reg.Matches(str))
            {
                Console.WriteLine(m.ToString());

            }



        }
    }
}
