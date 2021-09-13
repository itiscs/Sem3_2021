using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var eqs = new List<Equation>();
            
            eqs.Add(Equation.CreateEquation(1,-40,4,2,3,4,5));
            eqs.Add(Equation.CreateEquation(-40, 4));
            eqs.Add(Equation.CreateEquation(4));
            eqs.Add(Equation.CreateEquation());
            eqs.Add(new Equation());

            foreach (var eq in eqs)
            {
                Console.WriteLine(eq);
                eq.Solve();
                eq.Solution();
                Console.WriteLine("********************");
            }
        }
    }
}
