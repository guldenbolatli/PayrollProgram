using CSProjeDemo2;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\gulde\OneDrive\Masaüstü\BA_BOOST\11.Case Apps\1.OOP\PayrollProgram\PayrollProgram\Program\employee.json";
            //string filePath = "employee.json";
            List<Employee> employeeList = ReadFile.ReadEmployeeList(filePath);

            Payroll.CreatePayroll(employeeList);
            Payroll.DisplayReport(employeeList);


            Console.ReadLine();
        }
    }
}