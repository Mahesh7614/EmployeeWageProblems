namespace Employees
{
    class Program
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {
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
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addcompanyEmpWage("Airtel", 30, 30, 100);
            empWageBuilder.addcompanyEmpWage("TCS", 40, 30, 80);
            empWageBuilder.addcompanyEmpWage("Wipro", 25, 25, 120);
            empWageBuilder.addcompanyEmpWage("Cipla", 23, 28, 111);
            empWageBuilder.computeEmpWage();
>>>>>>> UC10
        }
    }
}