using System;

//************************************************
//  Due 12 noon Tuesday, 3/5/2019.
//************************************************

namespace Employee
{   //  Begin namespace Employee
    abstract class Employee
    {   //  Begin abstract class Employee
        //	Declare and initialize program constants
        const int MINEMPNUM = 1000;     //  Min employee number
        const int MAXEMPNUM = 10000;    //  Max employee number
        const int DEFEMPNUM = 9999;     //  Default employee number

        //	Declare program instance variables
        private string firstName;
        private string middleInit;
        private string lastName;
        private bool isUnion;
        private int empNum;
        //private double hoursWorked;
        //private double hourlyRate;
        protected double grossPay;

        //************************************************
        //	No-arg constructor
        //************************************************
        public Employee()
        {   //  Begin public Employee() No-arg constructor
            firstName   = "UFN";
            middleInit  = "*";
            lastName    = "ULN";
            isUnion     = false;        //	Unnecessary
            empNum      = DEFEMPNUM;
        }   //  End   public Employee() No-arg constructor 

        //************************************************
        //	Full-arg constructor
        //************************************************
        public Employee(string fn, string mi, string ln,
                        bool iu, int en)
        {   //  Begin public Employee() Full-arg constructor
            this.firstName      = fn;
            this.middleInit     = mi;
            this.lastName       = ln;
            this.isUnion        = iu;
            this.empNum         = en;
        }   //  End   public Employee() Full-arg constructor

        //************************************************
        //	firstName getter/setter
        //************************************************
        public string FirstName
        {   //  Begin public string FirstName
            get
            {
                return firstName;
            }
            set
            {
                if (value == "")
                {
                    firstName = "UFN";
                }
                else
                {
                    firstName = value;
                }
             }
        }   //  End   public string FirstName

        //************************************************
        //	middleInit getter/setter
        //************************************************
        public string MiddleInit
        {   //  Begin public string MiddleInit
            get
            {
                return middleInit;
            }
            set
            {
                middleInit = (value == string.Empty) ? "*" : value;
            }
        }   //  End   public string MiddleInit

        //************************************************
        //	lastName getter/setter
        //************************************************
        public string LastName
        {   //  Begin public string LastName
            get
            {
                return lastName;
            }
            set
            {
                lastName = (value != string.Empty) ? value : "ULN";
            }
        }   //  End   public string LastName

        //************************************************
        //	isUnion getter/setter
        //************************************************
        public bool IsUnion
        {   //  Begin public bool IsUnion
            get
            {
                return isUnion;
            }
            set
            {
                isUnion = ((value == true) || (value == false)) ? value : false;
            }
        }   //  End   public bool IsUnion

        //************************************************
        //	empNum getter/setter
        //************************************************
        public int EmpNum
        {   //  Begin public int EmpNum
            get
            {
                return empNum;
            }
            set
            {
                bool result = Int32.TryParse(value.ToString(), out empNum);

                //  Handle non-numeric input
                if (!result)            //  if (result == false)
                {
                    empNum = DEFEMPNUM;
                }
                else if ((empNum < MINEMPNUM) || (empNum > MAXEMPNUM))
                {
                    empNum = DEFEMPNUM;
                }
                else
                {
                    empNum = value;
                }
            }
        }   //  End   public int EmpNum

        //  Declare abstract method:
        public abstract double CalculateEarnings();

        //************************************************
    }   //  End   abstract class Employee
}   //  End   namespace Employee
