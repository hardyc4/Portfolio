using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class OutOfRangeCommRateException : Exception
    {
        private static string msg = "\nYour commission rate must be between 0.10 and 0.33\n";

        public OutOfRangeCommRateException() : base(msg)
        { }
    }
}
