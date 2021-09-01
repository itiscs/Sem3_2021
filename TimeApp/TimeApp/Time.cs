using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeApp
{
    public class Time
    {
        private readonly double  sec;

        public double Sec 
        { 
            get=>sec; 
        }
        public double Tik
        {
            get => sec*18.2;
        }
        public double Min
        {
            get => sec/60;
        }

        private Time()
        {
            sec = 0;
        }

        private Time(double s)
        {
            if (s < 0)
                throw new ArgumentException("Negative time!!!");
            sec = s;
        }

        public static Time CreateFromSec(double sec)
        {
            return new Time(sec);
        }
        public static Time CreateFromTik(double tik)
        {
            return new Time(tik/18.2);
        }
        public static Time CreateFromMin(double min)
        {
            return new Time(min*60);
        }

        public override string ToString()
        {
            return $"Sec-{Sec:0.00} Min-{Min:0.00} Tik - {Tik:0.00}";
        }

        public static Time operator+(Time t1, Time t2)
        {
            Time t3 = new Time(t1.sec + t2.sec);
            return t3;
        }
        public static Time operator +(Time t1, double sec)
        {
            Time t3 = new Time(t1.sec + sec);
            return t3;
        }
        public static Time operator &(Time t1, Time t2)
        {
            Time t3 = new Time(t1.sec - t2.sec);
            return t3;
        }





    }
}
