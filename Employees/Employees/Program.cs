namespace Employees
{
    class Program
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {
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
        {
            // Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <=MAX_HOURS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                
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
                totalWorkingDays++;
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
            
            int totalempwage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalempwage);
            return totalempwage;
        }
        static void Main(string[] args)
        {
            computeEmpWage();
>>>>>>> UC7
        }
    }
}