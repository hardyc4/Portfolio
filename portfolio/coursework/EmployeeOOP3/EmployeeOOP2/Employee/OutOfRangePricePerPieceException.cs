using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class OutOfRangePricePerPieceException : Exception
    {
        private static string msg = "\nPrice per piece must be between 0 and 1.\n";

        public OutOfRangePricePerPieceException() : base(msg)
        { }
    }
}
