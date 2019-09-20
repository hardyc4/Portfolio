using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class OutOfRangePiecesException : Exception
    {
        private static string msg = "\nPieces Must Be Between 0 - 100\n";

        public OutOfRangePiecesException() : base(msg)
        { }
    }
}
