using System;
using System.Runtime.CompilerServices;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addcompanyEmpWage("Airtel",20,25,100);
            empWageBuilder.addcompanyEmpWage("Tcs",22,26,200);
            empWageBuilder.addcompanyEmpWage("Mahindra",30,30,110);
            empWageBuilder.addcompanyEmpWage("Cilpa",15,28,113);
            empWageBuilder.computeEmpWage();
            
        }
    }
}