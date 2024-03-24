using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class Manager : Employee
    {
        public override decimal CalculateSalary(int workingHours, decimal hourlyWage)
        {
            decimal minHourlyWage = 500;
            decimal bonus = 1000;//bonus wage
            hourlyWage = Math.Max(hourlyWage, minHourlyWage);
            decimal salary = (hourlyWage * workingHours) + bonus;
            return salary;
        }
    }
}
