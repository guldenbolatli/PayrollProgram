using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public int WorkingHours { get; set; }
        public virtual decimal CalculateSalary(int workingHours, decimal hourlyWage)
        {
            return 0;
        }
    }
}
