using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public static class Payroll
    {
        public static void CreatePayroll(List<Employee> employeeList)
        {
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine($"Enter working hour for {employee.FirstName} {employee.LastName}:");
                int workingHours = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Enter hourly wage for {employee.FirstName} {employee.LastName}:");
                decimal hourlyWage = Convert.ToDecimal(Console.ReadLine());

                decimal salary = employee.CalculateSalary(workingHours,hourlyWage);



                //Read salary information to the file.
                string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), $"{employee.FirstName}_{employee.LastName}");
                Directory.CreateDirectory(directoryPath); // Klasörü oluştur

                string fileName = $"{employee.FirstName}_{employee.LastName}_Salary_{DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")}.json";
                
                string filePath = Path.Combine(directoryPath, fileName); // Dosya yolu oluştur
               

                string json = JsonConvert.SerializeObject(new 
                { 
                    FirstName = employee.FirstName, 
                    LastName = employee.LastName, 
                    WorkingHours = workingHours, 
                    MainSalary = hourlyWage*workingHours, 
                    Shift = (workingHours>180)?((workingHours-180)*workingHours*0.5m) :0,  
                    TotalSalary = salary 
                }, Formatting.Indented);

                File.WriteAllText(filePath, json);
            }
        }

        public static void DisplayReport(List<Employee> employeeList)
        {
            Console.WriteLine("Payroll Report:");
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine($"The salary calculated for {employee.FirstName} {employee.LastName}");
            }
            // Information of personnel working less than 150 hours
            Console.WriteLine("\nEmployees working less than 150 hours:");
            foreach (Employee employee in employeeList)
            {
                if (employee.WorkingHours < 150)
                {
                    Console.WriteLine($"- {employee.FirstName} {employee.LastName}");
                }
            }
        }
    }
}
