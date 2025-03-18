using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2
{
    public class Decorator : ITimeFormatter
    {
        protected ITimeFormatter timeFormatter;
        public Decorator(ITimeFormatter _timeFormatter)
        {
            timeFormatter = _timeFormatter;
        }

        public virtual string ToString()
        {
            return timeFormatter.ToString();
        }
        public virtual void PrintTime()
        {
            Console.WriteLine(ToString());
        }
    }
}
