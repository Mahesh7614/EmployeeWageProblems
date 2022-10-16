﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employees
{
    public class EmpWageBuilder: IComputeEmpWage
    {
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2;

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> empWageDictionary;

        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.empWageDictionary = new Dictionary<string, CompanyEmpWage>();
        }
        public void addcompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.empWageDictionary.Add(company, companyEmpWage);
        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            // Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            // Comutation
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
                int dailyWage = empHrs * companyEmpWage.empRatePerHour;
                Console.WriteLine("Daily Wage Of Employee Is : " +dailyWage);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }

        public int getTotalWage(string company)
        {
            return this.empWageDictionary[company].totalEmpWage;
        }

    }
}
