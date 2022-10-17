using System;
using System.Runtime.CompilerServices;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            //Constants
            int IS_FULL_TIME = 1;
<<<<<<< HEAD
=======
            int IS_PART_TIME = 2;
>>>>>>> UC3
            int EMP_RATE_PER_HOUR = 20;
=======
>>>>>>> UC4
            // Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);
<<<<<<< HEAD
            if (empCheck == IS_PART_TIME)
            {
<<<<<<< HEAD
=======
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
>>>>>>> UC3
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
<<<<<<< HEAD
            Console.WriteLine("Emp Wage : " + empWage); 
=======
            Console.WriteLine("Emp Wage : " + empWage);
>>>>>>> UC3
=======
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " +empWage);
>>>>>>> UC4
=======
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2, EMP_RATE_PER_HOUR = 20, NUM_OF_WORKING_DAYS = 20;
        static void Main(string[] args)
=======
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2, EMP_RATE_PER_HOUR = 20, NUM_OF_WORKING_DAYS = 20, MAX_HOURS_IN_MONTH = 100;

        public static int computeEmpWage()
>>>>>>> UC7
=======
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2;

        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
>>>>>>> UC8
        {
            // Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            // Comutation
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days : " + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
<<<<<<< HEAD
        empWage = empHrs * EMP_RATE_PER_HOUR;
        totalempwage = empWage * NUM_OF_WORKING_DAYS;
        Console.WriteLine("Emp Wage : " + empWage);
        Console.WriteLine("Total Emp Wage : " + totalempwage);
>>>>>>> UC5
=======
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2, EMP_RATE_PER_HOUR = 20, NUM_OF_WORKING_DAYS = 20, MAX_HOURS_IN_MONTH = 100;
        static void Main(string[] args)
        {
            // Variables
            int empHrs = 0, totalEmpHrs = 0, totalempwage = 0, totalworkingDays = 0;

            while (totalEmpHrs <= MAX_HOURS_IN_MONTH && totalworkingDays < NUM_OF_WORKING_DAYS)
            {
                totalworkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs +=empHrs;
                Console.WriteLine("Days : " + totalworkingDays + " Emp Hours : " + empHrs);
            }
            totalempwage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalempwage);
>>>>>>> UC6
=======
            
            int totalempwage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage of " + company + " is :" + totalempwage);
            return totalempwage;
        }
        static void Main(string[] args)
        {
<<<<<<< HEAD
            computeEmpWage();
>>>>>>> UC7
=======
            computeEmpWage("Airtel",30,30,100);
            computeEmpWage("TCS",40,30,80);
            computeEmpWage("Wipro",25,25,120);
            computeEmpWage("Cipla",23,28,111);
>>>>>>> UC8
=======
        static void Main(string[] args)
        {
            EmpWageBuilderObject Airtel = new EmpWageBuilderObject("Airtel",30,30,100);
            EmpWageBuilderObject TCS = new EmpWageBuilderObject("TCS",40,30,80);
            EmpWageBuilderObject Wipro = new EmpWageBuilderObject("Wipro",25,25,120);
            EmpWageBuilderObject Cipla = new EmpWageBuilderObject("Cipla",23,28,111);
            Airtel.computeEmpWage();
            Console.WriteLine(Airtel.toString());
            TCS.computeEmpWage();
            Console.WriteLine(TCS.toString());
            Wipro.computeEmpWage();
            Console.WriteLine(Wipro.toString());
            Cipla.computeEmpWage();
            Console.WriteLine(Cipla.toString());
>>>>>>> UC9
=======
=======
=======
=======
>>>>>>> c132c6957fea2f5a406e3e370a7cb3892d6a0199
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();

            Console.WriteLine("Enter i to Enter Company Details or otherwise enter any key : ");
            var input = Console.ReadLine();
            while (input == "i")
            {
                var obj = UserInput();
                empWageBuilder.addcompanyEmpWage(obj.company, obj.empRatePerHour, obj.numOfWorkingDays, obj.maxHoursPerMonth);
                Console.WriteLine("Enter i to Enter Company Details or otherwise enter any key :");
                input = Console.ReadLine();
            }
            empWageBuilder.computeEmpWage();
        }

        public static CompanyEmpWage UserInput()
        {
<<<<<<< HEAD
>>>>>>> UC11ComputeEmployeeWageMultipleCompaniesUsingApiApproach
=======
>>>>>>> c132c6957fea2f5a406e3e370a7cb3892d6a0199
            Console.WriteLine("Enter Company Name : ");
            string compName = Console.ReadLine();

            Console.WriteLine("Enter Employee Rate Per Hour : ");
            int empRatePerHour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter No of Working Days : ");
            int numOfDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Maximum Hours Per Month : ");
<<<<<<< HEAD
<<<<<<< HEAD
            int maxHourMonth = Convert.ToInt32(Console.ReadLine());
            
>>>>>>> UC11
=======
>>>>>>> UC12
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();

            Console.WriteLine("Enter i to Enter Company Details or otherwise enter any key : ");
            var input = Console.ReadLine();
            while (input == "i")
            {
                var obj = UserInput();
                empWageBuilder.addcompanyEmpWage(obj.company, obj.empRatePerHour, obj.numOfWorkingDays, obj.maxHoursPerMonth);
                Console.WriteLine("Enter i to Enter Company Details or otherwise enter any key :");
                input = Console.ReadLine();
            }
            empWageBuilder.computeEmpWage();
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> UC10
=======
=======
            EmpWageBuilder empWage = new EmpWageBuilder();
            empWage.addcompanyEmpWage("Airtel",20,25,100);
            empWage.addcompanyEmpWage("Tcs",22,26,200);
            empWage.addcompanyEmpWage("Mahindra",30,30,110);
            empWage.addcompanyEmpWage("Cilpa",15,28,113);
            empWage.computeEmpWage();
>>>>>>> UC14
            
>>>>>>> UC12
=======
=======
>>>>>>> c132c6957fea2f5a406e3e370a7cb3892d6a0199
            int maxWorkingHourPerMonth = Convert.ToInt32(Console.ReadLine());

            return new CompanyEmpWage(compName,empRatePerHour,numOfDays,maxWorkingHourPerMonth)
=======

        }
        public static CompanyEmpWage UserInput()
        {
            Console.WriteLine("Enter Company Name : ");
            string compName = Console.ReadLine();

            Console.WriteLine("Enter Employee Rate Per Hour : ");
            int empRatePerHour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter No of Working Days : ");
            int numOfDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Maximum Hours Per Month : ");
            int maxWorkingHourPerMonth = Convert.ToInt32(Console.ReadLine());

            return new CompanyEmpWage(compName, empRatePerHour, numOfDays, maxWorkingHourPerMonth)
>>>>>>> UC12ComputeTotalEmployeeWageUsingArrayList
            {
                company = compName,
                empRatePerHour = empRatePerHour,
                numOfWorkingDays = numOfDays,
                maxHoursPerMonth = maxWorkingHourPerMonth
            };
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> UC11ComputeEmployeeWageMultipleCompaniesUsingApiApproach
=======
>>>>>>> c132c6957fea2f5a406e3e370a7cb3892d6a0199
=======
>>>>>>> UC12ComputeTotalEmployeeWageUsingArrayList
        }
    }
}