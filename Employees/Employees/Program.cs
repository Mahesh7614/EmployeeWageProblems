namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constants
            int IS_FULL_TIME = 1;
<<<<<<< HEAD
=======
            int IS_PART_TIME = 2;
>>>>>>> UC3
            int EMP_RATE_PER_HOUR = 20;
            // Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);
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
        }
    }
}