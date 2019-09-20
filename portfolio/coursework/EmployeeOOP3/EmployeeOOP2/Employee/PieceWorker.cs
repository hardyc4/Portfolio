using System;

//************************************************
//  Using the Hourly employee class as a template,
//  complete all of the missing info (delimited by
//  comments) below.
//
//  Due 12 noon Tuesday, 3/5/2019.
//************************************************

namespace Employee
{   //  Begin namespace Employee
    class PieceWorker : Employee
    {   //  Begin class PieceWorker : Employee
        //  Declare and initialize class constants
        const int    MINPIECES  =    0;     //	Minimum pieces made per hour
        const int    MAXPIECES  =  100;     //	Maximum pieces made per hour
        const int    DEFPIECES  =   25;     //	Default pieces made per hour
        const double MINPPP     =    0.0;   //	Minimum price per piece
        const double MAXPPP     =    1.0;   //  Maximum price per piece
        const double DEFPPP     =    0.5;   //	Default price per piece

        //  Declare PieceWorker class instance variables
        int pieces           = 0;
        double pricePerPiece = 0.0;

        //************************************************
        //	No-arg constructor
        //************************************************
        public PieceWorker()
        {  //  Start   public PieceWorker() No-arg constructor
            pieces        = DEFPIECES;
            pricePerPiece = DEFPPP;
            CalculateEarnings();
        }  //  End   public PieceWorker() No-arg constructor



        //************************************************
        //	Full-arg constructor
        //************************************************
        public PieceWorker(string fn, string mi, string ln,
                       bool iu, int en,
                       int pc, double ppp) : base(fn, mi, ln,
                                                     iu, en)
        {   //  Begin public Hourly() Full-arg constructor
            validatePieces(pc);
            validatePricePerPiece(ppp);
        }   //  End   public Hourly() Full-arg constructor

        //************************************************
        //	pieces getter/setter
        //************************************************
        public int Pieces
        {   //  Begin public int Pieces
            get
            {
                return pieces;
            }
            set
            {
                try
                {
                    validatePieces(value);
                }
                catch (OutOfRangePiecesException e)
                {
                    pieces = DEFPIECES;
                    Console.WriteLine(e.Message);
                }
            }
        }   //  End   public int Pieces

        //************************************************
        //	pricePerPiece getter/setter
        //************************************************
        public double PricePerPiece
        {   //  Begin public double PricePerPiece
            get
            {
                return pricePerPiece;
            }
            set
            {
                try
                {
                    validatePricePerPiece(value);
                }
                catch (OutOfRangePricePerPieceException e)
                {
                    Console.WriteLine(e.Message + "\t" + pricePerPiece);
                    pricePerPiece = DEFPPP;
                }
                CalculateEarnings();
            }
        }   //  End   public double PricePerPiece

        //************************************************
        //	validatePieces()
        //************************************************
        public void validatePieces(int value)
        {
            bool result = int.TryParse(value.ToString(), out pieces);

            //  Handle non-numeric input
            if (!result)            //  if (result == false)
            {
                OutOfRangePiecesException oorpe = new OutOfRangePiecesException();
                throw (oorpe);
            }
            else if ((value < MINPIECES) || (value > MAXPIECES))
            {
                OutOfRangePiecesException oorpe = new OutOfRangePiecesException();
                throw (oorpe);
            }
            else
            {
                pieces = value;
            }
        }

        //************************************************
        //	validatePrice Per Piece()
        //************************************************
        public void validatePricePerPiece(double value)
        {
            bool result = double.TryParse(value.ToString(), out pricePerPiece);

            //  Handle non-numeric input
            if (!result)            //  if (result == false)
            {
                OutOfRangePricePerPieceException oorppp = new OutOfRangePricePerPieceException();
                throw (oorppp);
            }
            else if ((value < MINPPP) || (value > MAXPPP))
            {
                OutOfRangePricePerPieceException oorppp = new OutOfRangePricePerPieceException();
                throw (oorppp);
            }
            else
            {
                pricePerPiece = value;
            }
        }

        //************************************************
        //	overridden CalculateEarnings()
        //************************************************
        public override double CalculateEarnings()
        {
            //  Calculate earnings as piecesMade * pricePerPiece
            grossPay = pieces * pricePerPiece;
            return grossPay;
        }

        //************************************************
        //	Overridden ToString()
        //************************************************
        public override string ToString()
        {   //  Begin public override string ToString()
            string outputStr = "";

            outputStr += "Employee Name: " + FirstName + " " +
                                                    MiddleInit + " " +
                                                    LastName + "\n";
            outputStr += "Union Status:  " + IsUnion.ToString() + "\n";
            outputStr += "Employee Number: " + EmpNum.ToString() + "\n";
            outputStr += "Pieces made: " + Pieces.ToString() + "\n";
            outputStr += "Price Per Piece: " + PricePerPiece.ToString("c") + "\n";
            outputStr += "Gross Pay: " + grossPay.ToString("c") + "\n";

            return outputStr;
        }   //  End   public override string ToString()

        //************************************************
    }   //  End   class PieceWorker : Employee
}   //  End   namespace Employee
