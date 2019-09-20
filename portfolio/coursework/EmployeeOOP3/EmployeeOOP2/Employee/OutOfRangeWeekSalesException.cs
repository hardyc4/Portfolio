using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class OutOfRangeWeekSalesException : Exception
    {
        private static string msg = "\nYour sales for the week must be between 0 and 10,000\n";

        public OutOfRangeWeekSalesException() : base(msg)
        { }
    }
}
