using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationApp
{
    //a*x^2 + b*x + c = 0

    public class Equation
    {
        protected int countSol = 0;

        public virtual void Solve()
        {
            Console.WriteLine("Решаем уравнение...");
        }
        public virtual void Solution()
        {
            Console.WriteLine("Решение уравнения: ...");
        }

        public static Equation CreateEquation(params double[] param)
        {
            if (param.Length == 0)
                return new Equation0(0);
            if (param[0] == 0)
                throw new ArgumentException("нельзя первый ноль!");
            else if (param.Length == 1)
                return new Equation0(param[0]);
            else if (param.Length == 2)
                return new Equation1(param[0], param[1]);
            else
                return new Equation2(param[0], param[1], param[2]);

        }
    }


    public class Equation0:Equation
    {
        protected double c;

        public Equation0(double _c)
        {
            c = _c;
        }
       
        public override void Solve()
        {
            if (c != 0)
                countSol = 0;
            else
                countSol = int.MaxValue;
        }
        public override void Solution()
        {
            if (countSol == 0)
                Console.WriteLine("Решений нет");
            else
               Console.WriteLine("Вся числовая ось");
        }

        public override string ToString()
        {
            return $"{c:0.00} = 0";
        }
    }

    public class Equation1 : Equation0
    {
        protected double b;
        protected double x1;

        public Equation1(double _b, double _c):base(_c)
        {
            b = _b;
        }

        public override void Solve()
        {
            if (b == 0)
                countSol = 0;
            else
            {
                countSol = 1;
                x1 = -c / b;
            }
        }
        public override void Solution()
        {
            if (countSol == 0)
                Console.WriteLine("Решений нет");
            else
                Console.WriteLine($"x = {x1:0.00}");
        }

        public override string ToString()
        {
            return $"{b:0.00}*x + {c:0.00} = 0";
        }
    }

    public class Equation2 : Equation1
    {
        protected double a;
        protected double x2;

        public Equation2(double _a,double _b, double _c) : base(_b,_c)
        {
            a = _a;
        }

        public override void Solve()
        {
            var discr = b * b -  (4 * a * c);
            if (discr < 0)
                countSol = 0;
            else
            {
                countSol = 2;
                x1 = (-b + Math.Sqrt(discr)) / (2 * a);
                x2 = (-b - Math.Sqrt(discr)) / (2 * a);
            }
        }
        public override void Solution()
        {
            if (countSol == 0)
                Console.WriteLine("Решений нет");
            else
                Console.WriteLine($"x1 = {x1:0.00}\nx2 = {x2:0.00}");
        }

        public override string ToString()
        {
            return $"{a:0.00}*x^2 + {b:0.00}*x + {c:0.00} = 0";
        }
    }


}
