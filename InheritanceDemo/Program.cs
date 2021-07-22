using System;
using System.Collections.Generic;

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

            Console.WriteLine("emp.GetHashCode: " + emp.GetHashCode());
            Console.WriteLine("emp.GetType: " + emp.GetType());
            Console.WriteLine("emp.ToString " + emp.ToString());


            HourlyEmployee hourEmp = new HourlyEmployee();
            hourEmp.EmpNum = 2;
            hourEmp.FirstName = "Bill";
            hourEmp.LastName = " Gates";
            hourEmp.HourlyRate = 15.00M;

            Console.WriteLine("hourEmp.GetHashCode: " + hourEmp.GetHashCode());
            Console.WriteLine("hourEmp.GetType: " + hourEmp.GetType());
            Console.WriteLine("hourEmp.ToString " + hourEmp.ToString());

            Console.WriteLine("emp Get Pay Summary: " + emp.GetPaySummary);

            Console.WriteLine("hour Emp Get Pay Summary: " + hourEmp.GetPaySummary);

            Employee emp2 = hourEmp;
            Console.WriteLine("emp2 Get Pay Summary: " + emp2.GetPaySummary);

            object athing = hourEmp;
            Employee athingTreatedLekeAnEmplyee = athing as Employee;

            List<Employee> list = new List<Employee>();
            list.Add(emp);
            list.Add(hourEmp);

            Console.WriteLine(list);

            Console.WriteLine(athingTreatedLekeAnEmplyee.GetPaySummary); //I didn't do the hours part...              
            Console.WriteLine("Hello! " + hourEmp);
        }
    }
}
