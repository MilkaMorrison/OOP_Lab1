using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2
{
    class EuropeTimePrinter : ITimeFormatter
    {
        public override string ToString()
        {
            CultureInfo myCIintl = new CultureInfo("es-ES", false);
            return DateTime.Now.ToString(myCIintl);
        }
        public void PrintTime()
        {
            Console.WriteLine(ToString());
        }
    }
}
