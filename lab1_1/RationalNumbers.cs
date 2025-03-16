using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_1
{
    public class RationalNumbers
    {
        private int Numerator { get; }
        private int Denominator { get; }

        public RationalNumbers(int a, int b)
        {
            //Console.WriteLine("Создание объекта класса RationalNumbers");
            if (b == 0)
            {
               Console.WriteLine("Число не может иметь в знаменателе 0!");
                a = 0;
                b = 1;
            }

            int temp = NOD(a, b);
            a /= temp;
            b /= temp;

            if (a * b >= 0)
            {
                Numerator = Math.Abs(a);
                Denominator = Math.Abs(b);
            }
            else
            {
                Numerator = -Math.Abs(a);
                Denominator = Math.Abs(b);
            }
        }

        private int NOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            if (Denominator == 1)
                return $"{Numerator}";
            return $"{Numerator}/{Denominator}";
        }

        public static RationalNumbers operator +(RationalNumbers a, RationalNumbers b)
        {
            RationalNumbers res = new RationalNumbers(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);
            return res;
        }
        public static RationalNumbers operator -(RationalNumbers a, RationalNumbers b)
        {
            RationalNumbers res = new RationalNumbers(a.Numerator * b.Denominator - b.Numerator * a.Denominator, a.Denominator * b.Denominator);
            return res;
        }
        public static RationalNumbers operator *(RationalNumbers a, RationalNumbers b)
        {
            RationalNumbers res = new RationalNumbers(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
            return res;
        }
        public static RationalNumbers operator /(RationalNumbers a, RationalNumbers b)
        {
            RationalNumbers res = new RationalNumbers(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
            return res;
        }
        public static RationalNumbers operator -(RationalNumbers a)
        {
            RationalNumbers res = new RationalNumbers(-1 * a.Numerator, a.Denominator);
            return res;
        }

        public static bool operator ==(RationalNumbers a, RationalNumbers b)
        {
            return a.Numerator == b.Numerator && a.Denominator == b.Denominator;
        }
        public static bool operator !=(RationalNumbers a, RationalNumbers b)
        {
            return a.Numerator != b.Numerator || a.Denominator != b.Denominator;
        }
        public static bool operator <(RationalNumbers a, RationalNumbers b)
        {
            return a.Numerator * b.Denominator < b.Numerator * a.Denominator;
        }
        public static bool operator <=(RationalNumbers a, RationalNumbers b)
        {
            return a.Numerator * b.Denominator <= b.Numerator * a.Denominator;
        }
        public static bool operator >(RationalNumbers a, RationalNumbers b)
        {
            return a.Numerator * b.Denominator > b.Numerator * a.Denominator;
        }
        public static bool operator >=(RationalNumbers a, RationalNumbers b)
        {
            return a.Numerator * b.Denominator >= b.Numerator * a.Denominator;
        }
    }
}
