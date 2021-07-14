using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpNum = 1;
            emp.FirstName = "Steve";
            emp.LastName = "Jobs";

            HourlyEmployee hourEmp = new HourlyEmployee();
            hourEmp.EmpNum = 2;
            hourEmp.FirstName = "Bill";
            hourEmp.LastName = " Gates";
            hourEmp.HourlyRate = 15.00M;

            Console.WriteLine("emp Get Pay Summary: " + emp.GetPaySummary);

            Console.WriteLine("hour Emp Get Pay Summary: " + hourEmp.GetPaySummary);

            Employee emp2 = hourEmp;
            Console.WriteLine("emp2 Get Pay Summary: " + emp2.GetPaySummary);

            
        }
    }
}
