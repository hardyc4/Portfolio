using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class OutOfRangeHourlyRateException : Exception
    {
        private static string msg = "\nHourly Rate Must Be Between 0 - 100\n";

        public OutOfRangeHourlyRateException() : base(msg)
        { }
    }
}
