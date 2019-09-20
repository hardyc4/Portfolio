using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class OutOfRangeWeekSalaryException : Exception
    {
        private static string msg = "\nWeekly salary must be between $1,000 and $20,000\n";

        public OutOfRangeWeekSalaryException() : base(msg)
        { }
    }
}
