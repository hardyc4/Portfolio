using System;

//************************************************
//  Using the Salaried employee class as a template,
//  complete all of the missing info (delimited by
//  comments) below.
//
//  Due 12 noon Tuesday, 3/5/2019.
//************************************************

namespace Employee
{   //  Begin namespace Employee
    class Salaried : Employee
    {   //  Begin class Salaried : Employee
        const double MINSALARY = 1000.0;     //  Minimum weekly salary
        const double MAXSALARY = 20000.0;     //	Maximum weekly salary
        const double DEFSALARY = 5000.0;     //	Default weekly salary

        //  Declare Salaried class instance variables
        double weekSalary = 0.0;
        //************************************************
        //	No-arg constructor
        //************************************************
        public Salaried()
        {
            weekSalary = DEFSALARY;
            CalculateEarnings();
        }
        //************************************************
        //	Full-arg constructor
        //************************************************
        public Salaried(string fn, string mi, string ln,
                       bool iu, int en,
                       double ws) : base(fn, mi, ln,
                                                     iu, en)
        {   //  Begin public Salaried() Full-arg constructor
            validateWeekSalary(ws);
        }   //  End   public Hourly() Full-arg constructor
        //************************************************
        //	weeklySalary getter/setter
        //************************************************
        public double WeekSalary
        {   //  Begin public double WeekSalary
            get
            {
                return weekSalary;
            }
            set
            {
                try
                {
                    validateWeekSalary(value);
                }
                catch (OutOfRangeWeekSalaryException e)
                {
                    weekSalary = DEFSALARY;
                    Console.WriteLine(e.Message);
                }
            }
        }   //  End   public double WeekSalary
        //************************************************
        //	validateWeekSalary()
        //************************************************
        public void validateWeekSalary(double value)
        {
            bool result = Double.TryParse(value.ToString(), out weekSalary);

            //  Handle non-numeric input
            if (!result)            //  if (result == false)
            {
                OutOfRangeWeekSalaryException oorwse = new OutOfRangeWeekSalaryException();
                throw (oorwse);
            }
            else if ((value < MINSALARY) || (value > MAXSALARY))
            {
                OutOfRangeWeekSalaryException oorwse = new OutOfRangeWeekSalaryException();
                throw (oorwse);
            }
            else
            {
                weekSalary = value;
            }
        }
        //************************************************
        //	overridden CalculateEarnings()
        //************************************************

        public override double CalculateEarnings()
        {
            //  Calculate earnings as just salary
            return 0.0;
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
            outputStr += "Salary Staus: " + WeekSalary.ToString("c");
            return outputStr;
        }   //  End   public override string ToString()
            //************************************************
    }   //  End   class Salaried : Employee
}   //  End   namespace Employee
