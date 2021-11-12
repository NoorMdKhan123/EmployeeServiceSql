using System;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Service Program");
            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel model = new EmployeeModel();

            repo.GetAllEmployee();
        }
    }
}
