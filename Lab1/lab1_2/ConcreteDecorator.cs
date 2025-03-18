using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2
{
    public class ConcreteDecorator : Decorator
    {
        protected string str;
        public ConcreteDecorator(ITimeFormatter _timeFormatter, string _str) : base(_timeFormatter)
        { 
            str = _str;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(str + ' ');
            sb.Append(timeFormatter.ToString());
            sb.Append(' ' + str);
            return sb.ToString();
        }
    }
}
