using System;
using System.Collections.Generic;

namespace EmployeeDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Payroll payroll = new Payroll();

            payroll.Add("Kalle", 10000);
            payroll.Add("Nisse", 20000);
            payroll.Add("Anna", 25000);
            payroll.Add("Lisa", 18000);

            Console.WriteLine("Enter a new employee, Quit with Q");

            do
            {
                string name = Util.AskForString("Name: ");
                if (name == "Q") break;

                int salary = Util.AskForInt("Salary: ");

                payroll.Add(name, salary);



            }
            while (true);


            //Employee[] employees = payroll.GetEmployees();
            //Console.WriteLine(employees[0].Name);
            //employees[0] = null;
            //var emp2 = payroll.GetEmployees();
            //Console.WriteLine(emp2[0].Name);

            foreach (var emp in payroll.GetEmployees())
            {
                Console.WriteLine(emp);
            }

        }
    }
}
