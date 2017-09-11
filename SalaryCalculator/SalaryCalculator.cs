using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int hoursInYear = 2080;

        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            decimal annualSalary;

            if (hourlyWage > 0)
            {
               annualSalary = hourlyWage * hoursInYear;
            }
            else
            {
                return 0;
            }

            return annualSalary;
        }

        public decimal GetHourlyWage(decimal annualSalary)
        {
            decimal hourlyWage;

            if(annualSalary > 0)
            {
                hourlyWage = annualSalary / hoursInYear;
            }
            else
            {
                return 0;
            }
            return hourlyWage;
        }
    }
}
