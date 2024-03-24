using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class Officer : Employee
    {
        public string Degree { get; set; } //officer degree
        public override decimal CalculateSalary(int workingHours, decimal hourlyWage)
        {
            decimal salary;
            decimal differenceDegree = 1;

            switch (Degree.ToLower())
            {
                case "bachelor degree":
                    differenceDegree = 1.4m;
                    break;
                case "master degree":
                    differenceDegree = 1.6m;
                    break;
                case "phd degree":
                    differenceDegree = 1.8m;
                    break;
                default:
                    differenceDegree = 1;
                    break;
            }

            if(workingHours <= 180)
            {
                salary = hourlyWage * workingHours * differenceDegree;
            }
            else
            {
                salary = (180*hourlyWage*differenceDegree) + ((workingHours-180)*hourlyWage*1.5m * differenceDegree);
            }
            return salary;

        }
        public decimal CalculateHourlyWage()
        {
            switch (Degree.ToLower())
            {
                case "bachelor degree":
                    return 700;
                case "master degree":
                    return 800;
                case "phd degree":
                    return 1000;
                default:
                    return 500;
            }
        }

    }
}
