using System;
using System.Collections;
using static System.Console;

//************************************************
//  Due 12 noon Thursday, 3/7/2019.
//************************************************

namespace Employee
{   //  Begin namespace Employee
    class Program
    {   //  Begin class Program

        //Declare constant
        const int MAXARRAYSIZE = 100;

        //Declare global variables
        static ArrayList hourlyEmployee       = new ArrayList();
        static ArrayList salariedEmployee     = new ArrayList();
        static ArrayList pieceWorkerEmployee  = new ArrayList();
        static ArrayList commissionEmployee   = new ArrayList();
        static Hourly[] hourlyArray           = new Hourly[MAXARRAYSIZE];
        static Commission[] commissionArray    = new Commission[MAXARRAYSIZE];
        static Salaried[] salariedArray       = new Salaried[MAXARRAYSIZE];
        static PieceWorker[] pieceWorkerArray = new PieceWorker[MAXARRAYSIZE];
        static int hourlyCount                = 0;
        static int commissionCount            = 0;
        static int pieceWorkerCount           = 0;
        static int salariedCount              = 0;

        static void Main(string[] args)
        {   //  Begin static void Main(string[] args)
            //  Call to Full-Arg Constructor
            var goodNoOTEmployee0 = new Hourly();

            //  Call to getter
            //WriteLine("Employee 0:\n" + goodNoOTEmployee0);

            //  Call to No-Arg Constructor
            var goodNoOTEmployee1 = new Hourly();

            //  Calls to associated setters
            goodNoOTEmployee1.FirstName = "Jeffrey";
            goodNoOTEmployee1.MiddleInit = "P";
            goodNoOTEmployee1.LastName = "Scott";
            goodNoOTEmployee1.IsUnion = false;
            goodNoOTEmployee1.EmpNum = 1111;
            goodNoOTEmployee1.HoursWorked = 40.0;
            goodNoOTEmployee1.HourlyRate = 25.0;
            goodNoOTEmployee1.CalculateEarnings();

            //  Call to getter
            //WriteLine("Employee 1:\n" + goodNoOTEmployee1);

            //  Call to No-Arg Constructor
            var goodOTEmployee = new Hourly();

            //  Calls to associated setters
            goodOTEmployee.FirstName = "Mary";
            goodOTEmployee.MiddleInit = "K";
            goodOTEmployee.LastName = "Jones";
            goodOTEmployee.IsUnion = true;
            goodOTEmployee.EmpNum = 2222;
            goodOTEmployee.HoursWorked = 50.0;
            goodOTEmployee.HourlyRate = 20.0;
            goodOTEmployee.CalculateEarnings();

            //  Call to getter
            //WriteLine("Employee 2:\n" + goodOTEmployee);

            //  Call to No-Arg Constructor
            var badFNEmployee = new Hourly();

            //  Calls to associated setters
            badFNEmployee.FirstName = "";
            badFNEmployee.MiddleInit = "G";
            badFNEmployee.LastName = "Wilson";
            badFNEmployee.IsUnion = true;
            badFNEmployee.EmpNum = 3333;
            badFNEmployee.HoursWorked = 45.0;
            badFNEmployee.HourlyRate = 30.0;
            badFNEmployee.CalculateEarnings();

            //  Call to getter
            //WriteLine("Employee 3:\n" + badFNEmployee);

            //  Call to No-Arg Constructor
            var badMIEmployee = new Hourly();

            //  Calls to associated setters
            badMIEmployee.FirstName = "Kiley";
            badMIEmployee.MiddleInit = "";
            badMIEmployee.LastName = "Fleming";
            badMIEmployee.IsUnion = false;
            badMIEmployee.EmpNum = 4444;
            badMIEmployee.HoursWorked = 40.0;
            badMIEmployee.HourlyRate = 40.0;
            badMIEmployee.CalculateEarnings();

            //  Call to getter
            //WriteLine("Employee 4:\n" + badMIEmployee);

            //  Call to No-Arg Constructor
            var badLNEmployee = new Hourly();

            //  Calls to associated setters
            badLNEmployee.FirstName = "John";
            badLNEmployee.MiddleInit = "J";
            badLNEmployee.LastName = "";
            badLNEmployee.IsUnion = true;
            badLNEmployee.EmpNum = 5555;
            badLNEmployee.HoursWorked = 10.0;
            badLNEmployee.HourlyRate = 10.0;
            badLNEmployee.CalculateEarnings();

            //  Call to getter
            //WriteLine("Employee 5:\n" + badLNEmployee);

            //  Call to No-Arg Constructor
            var badENEmployee = new Hourly();

            //  Calls to associated setters
            badENEmployee.FirstName = "Mark";
            badENEmployee.MiddleInit = "B";
            badENEmployee.LastName = "Bronson";
            badENEmployee.IsUnion = false;
            badENEmployee.EmpNum = 66666;
            badENEmployee.HoursWorked = 10.0;
            badENEmployee.HourlyRate = 10.0;
            badENEmployee.CalculateEarnings();

            //  Call to getter
            //WriteLine("Employee 6:\n" + badENEmployee);

            //  Call to No-Arg Constructor
            //var badHREmployee = new Hourly();

            //try
            //{
            //    //  Calls to associated setters
            //    badHREmployee.FirstName = "Cari";
            //    badHREmployee.MiddleInit = "J";
            //    badHREmployee.LastName = "Granger";
            //    badHREmployee.IsUnion = false;
            //    badHREmployee.EmpNum = 8888;
            //    badHREmployee.HoursWorked = 50.0;
            //    badHREmployee.HourlyRate = -10.0;
            //    badHREmployee.CalculateEarnings();
            //}
            //catch (OutOfRangeHourlyRateException e)
            //{
            //    WriteLine(e.Message);
            //    WriteLine(e.StackTrace);
            //    ReadLine();
            //}

            //  Call to getter
            //WriteLine("Employee 8:\n" + badHREmployee);

            //  Call to No-Arg Commission Constructor
            //var commEmployeeNoArg = new Commission();

            //  Call to getter
            //WriteLine("Employee 9:\n" + commEmployeeNoArg);

            //  Call to No-Arg Commission Constructor
            //var commEmployeeFullArg = new Commission("John", "J", "Jennings", false, 98766, 0.2, 2500);

            //  Call to getter
            //WriteLine("Employee 10:\n" + commEmployeeFullArg);

            //  Call to No-Arg Salaried Constructor
            //var salEmployeeNoArg = new Salaried();

            //  Call to getter
            //WriteLine("Employee 11:\n" + salEmployeeNoArg);

            //  Call to No-Arg Commission Constructor
            //var salEmployeeFullArg = new Salaried("Helen", "H", "Hansen", false, 87654, 5500);

            //  Call to getter
            //WriteLine("Employee 12:\n" + salEmployeeFullArg);

            //  Call to No-Arg Salaried Constructor
            //var pwEmployeeNoArg = new PieceWorker();

            //  Call to getter
            // WriteLine("Employee 13:\n" + pwEmployeeNoArg);

            //  Call to No-Arg Commission Constructor
            //var pwEmployeeFullArg = new PieceWorker("Frank", "F", "Phillips", true, 76543, 58, 0.33);

            //  Call to getter
            //WriteLine("Employee 14:\n" + pwEmployeeFullArg);

            //ReadLine();
            //************************************************
            //  NOTE: We will go over this "test"
            //        as a class after spring break
            //        (probably on Monday 3/18/2019)
            //************************************************
            //
            //  Using the following resources and the
            //  Internet if/as necessary:
            //
            //  C# collections:
            //  http://zetcode.com/lang/csharp/collections/  
            //
            //  C# ArrayList Tutorial with Examples:
            //  https://www.guru99.com/c-sharp-arraylist.html 
            //
            //  C# - ArrayList:
            //  https://www.tutorialsteacher.com/csharp/csharp-arraylist  
            //
            //
            //  Create a:
            //
            //  Global hourlyEmployees arraylist
            //  Global salariedEmployees arraylist
            //  Global pieceWorkerEmployees arraylist
            //  Global commissionEmployees arraylist
            //
            //  In Main() below, write/call a method to
            //  continuously (use a loop) prompt a user to:
            //
            //  Enter a 1 to create a new hourlyEmployee
            //
            //  Enter a 2 to create a new salariedEmployee
            //
            //  Enter a 3 to create a new pieceWorkerEmployee
            //
            //  Enter a 4 to create a new commissionEmployee
            //
            //  Enter a 5 to iterate through (print out)
            //  the complete hourlyEmployee arraylist
            //
            //  Enter a 6 to iterate through (print out)
            //  the complete salariedEmployee arraylist
            //
            //  Enter a 7 to iterate through (print out)
            //  the complete pieceWorkerEmployee arraylist
            //
            //  Enter an 8 to iterate through (print out)
            //  the complete commissionEmployee arraylist
            //
            //  Enter a 9 to quit the program
            //
            //  As you input the information for each
            //  employee, immediately add said employee to 
            //  their associated arraylist
            //
            //************************************************

            //WriteLine("\nRest Of Program Output Shows Up Here!");
            //ReadLine();



            promptScreen();
        }   //  End   static void Main(string[] args)

        private static void promptScreen()
        {

            string choose;
            bool endApplication = false;

            while (!endApplication)
            {
                WriteLine("Enter a 1 to create a new hourlyEmployee" +
                      "\nEnter a 2 to create a new salariedEmployee" +
                      "\nEnter a 3 to create a new pieceWorkerEmployee" +
                      "\nEnter a 4 to create a new commissionEmployee" +
                      "\nEnter a 5 to iterate through(print out) the complete hourlyEmployee arraylist" +
                      "\nEnter a 6 to iterate through(print out) the complete salariedEmployee arraylist" +
                      "\nEnter a 7 to iterate through(print out) the complete pieceWorkerEmployee arraylist" +
                      "\nEnter an 8 to iterate through(print out) the complete commissionEmployee arraylist" +
                      "\nEnter a 9 to quit the program");
                Write(" Please enter 1 - 9 now: ");

                choose = ReadLine();

                if (choose == "1")
                {
                    newHourlyEmployee();
                }
                else if (choose == "2")
                {
                    newSalaryEmployee();
                }
                else if (choose == "3")
                {
                    newPieceWorkerEmployee();
                }
                else if (choose == "4")
                {
                    newCommissionEmployee();
                }
                else if (choose == "5")
                {
                    printHourlyEmployees();
                }
                else if (choose == "6")
                {
                    printSalaryEmployees();
                }
                else if (choose == "7")
                {
                    printPieceWorkerEmployees();
                }
                else if (choose == "8")
                {
                    printCommissionEmployees();
                }
                else if (choose == "9")
                {
                    endApplication = true;
                    Write("Application closing");
                }
                else
                {
                    Write("Press 'Enter' and Try Again");
                }

                ReadLine();
                Console.Clear();
            }

            
        }

        //*************************************

        private static void newHourlyEmployee()
        {
            hourlyArray[hourlyCount] = new Hourly();

            hourlyArray[hourlyCount].FirstName = generateFirstName();
            hourlyArray[hourlyCount].MiddleInit = generateMiddleInit();
            hourlyArray[hourlyCount].LastName = generateLastName();
            hourlyArray[hourlyCount].IsUnion = generateUnionStatus();
            hourlyArray[hourlyCount].EmpNum = generateEmployeeNumber();
            hourlyArray[hourlyCount].HoursWorked = generateHoursWorked();
            hourlyArray[hourlyCount].HourlyRate = generateHourlyRate();
            WriteLine(hourlyArray[hourlyCount]);
            hourlyEmployee.Add(hourlyArray[hourlyCount]);

            ++hourlyCount;
        }

        //*************************************

        private static void printHourlyEmployees()
        {
            for(int lcv = 0; lcv < hourlyCount; ++lcv)
            {
                WriteLine(hourlyEmployee[lcv]);
            }
        }

        //*************************************

        private static void newSalaryEmployee()
        {
            salariedArray[salariedCount] = new Salaried();

            salariedArray[salariedCount].FirstName = generateFirstName();
            salariedArray[salariedCount].MiddleInit = generateMiddleInit();
            salariedArray[salariedCount].LastName = generateLastName();
            salariedArray[salariedCount].IsUnion = generateUnionStatus();
            salariedArray[salariedCount].EmpNum = generateEmployeeNumber();
            salariedArray[salariedCount].WeekSalary = generateWeekSalary();
            WriteLine(salariedArray[salariedCount]);
            salariedEmployee.Add(salariedArray[salariedCount]);

            salariedCount++;
        }

        //*************************************

        private static void printSalaryEmployees()
        {
            for (int lcv = 0; lcv < salariedCount; ++lcv)
            {
                WriteLine(salariedEmployee[lcv]);
            }
        }

        //*************************************

        private static void newPieceWorkerEmployee()
        {
            pieceWorkerArray[pieceWorkerCount] = new PieceWorker();

            pieceWorkerArray[pieceWorkerCount].FirstName = generateFirstName();
            pieceWorkerArray[pieceWorkerCount].MiddleInit = generateMiddleInit();
            pieceWorkerArray[pieceWorkerCount].LastName = generateLastName();
            pieceWorkerArray[pieceWorkerCount].IsUnion = generateUnionStatus();
            pieceWorkerArray[pieceWorkerCount].EmpNum = generateEmployeeNumber();
            pieceWorkerArray[pieceWorkerCount].Pieces = generatePieces();
            pieceWorkerArray[pieceWorkerCount].PricePerPiece = generatePricePerPiece();
            WriteLine(pieceWorkerArray[pieceWorkerCount]);
            pieceWorkerEmployee.Add(pieceWorkerArray[pieceWorkerCount]);

            ++pieceWorkerCount;
        }

        //*************************************

        private static void printPieceWorkerEmployees()
        {
            for (int lcv = 0; lcv < pieceWorkerCount; ++lcv)
            {
                WriteLine(pieceWorkerEmployee[lcv]);
            }
        }

        //*************************************

        private static void newCommissionEmployee()
        {
            commissionArray[commissionCount] = new Commission();

            commissionArray[commissionCount].FirstName = generateFirstName();
            commissionArray[commissionCount].MiddleInit = generateMiddleInit();
            commissionArray[commissionCount].LastName = generateLastName();
            commissionArray[commissionCount].IsUnion = generateUnionStatus();
            commissionArray[commissionCount].EmpNum = generateEmployeeNumber();
            commissionArray[commissionCount].WeekSales = generateWeekSales();
            commissionArray[commissionCount].CommRate = generateCommRate();
            WriteLine(commissionArray[commissionCount]);
            commissionEmployee.Add(commissionArray[commissionCount]);

            ++commissionCount;
        }

        //*************************************

        private static void printCommissionEmployees()
        {
            for (int lcv = 0; lcv < commissionCount; ++lcv)
            {
                WriteLine(commissionEmployee[lcv]);
            }
        }

        //*************************************
        private static string generateFirstName()
        {
            Write("\nPlease enter your first name\t\t");
            return ReadLine();
        }

        //*************************************

        private static string generateMiddleInit()
        {
            Write("\nPlease enter your middle initial\t\t");
            return ReadLine();
        }

        //*************************************

        private static string generateLastName()
        {
            Write("\nPlease enter your last name\t\t");
            return ReadLine();
        }

        //*************************************

        private static bool generateUnionStatus()
        {
            string input = "";
            Write("\nAre you a union member? (Y/N)\t\t");
            input = ReadLine().ToUpper();

            if ((input.StartsWith("Y")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //*************************************

        private static int generateHoursWorked()
        {
            Write("\nHow many hours have you worked?\t\t");
            string input = ReadLine();
            if ((!isNumeric(input)) || (String.IsNullOrWhiteSpace(input)))
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(input);
            }
        }


        //*************************************

        private static int generateHourlyRate()
        {
            Write("\nWhat is your hourly rate?\t\t");
            string input = ReadLine();
            if ((!isNumeric(input)) || (String.IsNullOrWhiteSpace(input)))
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(input);
            }
        }


        //*************************************

        private static int generateEmployeeNumber()
        {
            Write("\nWhat is your Employee Number?\t\t");
            string input = ReadLine();
            if ((!isNumeric(input)) || (String.IsNullOrWhiteSpace(input)))
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(input);
            }
        }

        //*************************************

        private static int generateWeekSalary()
        {
            Write("\nWhat is your Weekly Salary?\t\t");
            string input = ReadLine();
            if ((!isNumeric(input)) || (String.IsNullOrWhiteSpace(input)))
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(input);
            }
        }

        //*************************************

        private static int generatePieces()
        {
            Write("\nHow many pieces did you make?\t\t");
            string input = ReadLine();
            if ((!isNumeric(input)) || (String.IsNullOrWhiteSpace(input)))
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(input);
            }
        }

        //*************************************

        private static double generatePricePerPiece()
        {
            Write("\nhow much is the price per piece?\t\t");
            string input = ReadLine();
            if ((!isNumericDouble(input)) || (String.IsNullOrWhiteSpace(input)))
            {
                return -1;
            }
            else
            {
                return Convert.ToDouble(input);
            }
        }

        //*************************************

        private static double generateWeekSales()
        {
            Write("\nwhat were your weeks sales?\t\t");
            string input = ReadLine();
            if ((!isNumericDouble(input)) || (String.IsNullOrWhiteSpace(input)))
            {
                return -1;
            }
            else
            {
                return Convert.ToDouble(input);
            }
        }
        //*************************************

        private static double generateCommRate()
        {
            Write("\nHow much do you make off each Commission?\t\t");
            string input = ReadLine();
            if ((!isNumericDouble(input)) || (String.IsNullOrWhiteSpace(input)))
            {
                return -1;
            }
            else
            {
                return Convert.ToDouble(input);
            }
        }

        //*************************************

        static bool isNumeric(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }

        //*************************************

        static bool isNumericDouble(string input)
        {
            double test;
            return double.TryParse(input, out test);
        }
    }   //  End   class Program
}   //  End   namespace Employee
