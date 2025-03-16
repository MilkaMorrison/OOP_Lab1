using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2
{
    class AmericanTimePrinter : ITimeFormatter
    {
        public override string ToString()
        {
            CultureInfo myCIintl = new CultureInfo("es-US", false);
            return DateTime.Now.ToString(myCIintl);
        }
        public void PrintTime()
        {
            Console.WriteLine(ToString());
        }
    }
}
