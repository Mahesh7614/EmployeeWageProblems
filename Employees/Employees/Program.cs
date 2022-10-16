using System;
using System.Runtime.CompilerServices;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWage = new EmpWageBuilder();
            empWage.addcompanyEmpWage("Airtel",20,25,100);
            empWage.addcompanyEmpWage("Tcs",22,26,200);
            empWage.addcompanyEmpWage("Mahindra",30,30,110);
            empWage.addcompanyEmpWage("Cilpa",15,28,113);
            empWage.computeEmpWage();
            
        }
    }
}