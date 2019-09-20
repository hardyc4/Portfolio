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
    class Commission : Employee
    {   //  Begin class Commission : Employee 
        const double MINCOMMRATE = 0.10;     //  Minimum commission rate
        const double MAXCOMMRATE = 0.33;     //	Maximum commission rate
        const double DEFCOMMRATE = 0.20;     //	Default commission rate
        const double MINWSALES = 0.0;      //  Minimum weekly sales
        const double MAXWSALES = 10000.0;      //	Maximum weekly sales
        const double DEFWSALES = 1000.0;      //	Default weekly sales

        //  Declare Commission class instance variables
        double commRate = 0.0;
        double weekSales = 0.0;
        //************************************************
        //	No-arg constructor
        //************************************************
        public Commission()
        {   //  Begin public Hourly() No-arg constructor
            commRate = DEFCOMMRATE;
            weekSales = DEFWSALES;
            CalculateEarnings();
        }   //  End   public Hourly() No-arg constructor 
        //************************************************
        //	Full-arg constructor
        //************************************************
        public Commission(string fn, string mi, string ln,
                       bool iu, int en,
                       double cr, double ws) : base(fn, mi, ln,
                                                     iu, en)
        {   //  Begin public Hourly() Full-arg constructor
            validateCommRate(cr);
            validateWeekSales(ws);
        }   //  End   public Hourly() Full-arg constructor
        //************************************************
        //	commRate getter/setter
        //************************************************
        public double CommRate
        {   //  Begin public double HoursWorked
            get
            {
                return commRate;
            }
            set
            {
                try
                {
                    validateCommRate(value);
                }
                catch (OutOfRangeCommRateException e)
                {
                    CommRate = DEFCOMMRATE;
                    Console.WriteLine(e.Message);
                }
            }
        }   //  End   public double HoursWorked
        //************************************************
        //	weeklySales getter/setter
        //************************************************
        public double WeekSales
        {   //  Begin public double HoursWorked
            get
            {
                return weekSales;
            }
            set
            {
                try
                {
                    validateWeekSales(value);
                }
                catch (OutOfRangeWeekSalesException e)
                {
                    weekSales = DEFWSALES;
                    Console.WriteLine(e.Message);
                }
                CalculateEarnings();
            }
        }   //  End   public double HoursWorked

        //************************************************
        //	validateHoursWorked
        //************************************************
        public void validateCommRate(double value)
        {
            bool result = Double.TryParse(value.ToString(), out commRate);

            //  Handle non-numeric input
            if (!result)            //  if (result == false)
            {
                OutOfRangeCommRateException oocre = new OutOfRangeCommRateException();
                throw (oocre);
            }
            else if ((value < MINCOMMRATE) || (value > MAXCOMMRATE))
            {
                OutOfRangeCommRateException oocre = new OutOfRangeCommRateException();
                throw (oocre);
            }
            else
            {
                commRate = value;
            }
        }

        //************************************************
        //	validateHoursWorked
        //************************************************
        public void validateWeekSales(double value)
        {
            bool result = Double.TryParse(value.ToString(), out weekSales);

            //  Handle non-numeric input
            if (!result)            //  if (result == false)
            {
                OutOfRangeWeekSalesException oorhe = new OutOfRangeWeekSalesException();
                throw (oorhe);
            }
            else if ((value < MINWSALES) || (value > MAXWSALES))
            {
                OutOfRangeWeekSalesException oorhe = new OutOfRangeWeekSalesException();
                throw (oorhe);
            }
            else
            {
                weekSales = value;
            }
        }
        //************************************************
        //	overridden CalculateEarnings()
        //************************************************

        public override double CalculateEarnings()
        {
            //  Calculate earnings as commRate * weeklySales
            grossPay = (commRate * weekSales);

            return grossPay;
        }   //  End   public override double CalculateEarnings()


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
            outputStr += "Week Sales: " + WeekSales.ToString("c") + "\n";
            outputStr += "Comm Rate: " + CommRate.ToString("c") + "\n";
            outputStr += "Gross Pay: " + grossPay.ToString("c") + "\n";

            return outputStr;
        }   //  End   public override string ToString()
            //************************************************
    }   //  End   class Commission : Employee 
}   //  End   namespace Employee
