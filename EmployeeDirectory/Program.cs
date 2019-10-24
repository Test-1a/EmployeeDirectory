using System;
using System.Collections.Generic;

namespace EmployeeDirectory
{
    class Program
    {
        //Entry point of application
        static void Main(string[] args)
        {
            //Create a new instance of payroll
            Payroll payroll = new Payroll();

            //Calls Add method on payroll instance with parameters
            //Only for demo purpose to have some data
            payroll.Add("Kalle", 10000);
            payroll.Add("Nisse", 20000);
            payroll.Add("Anna", 25000);
            payroll.Add("Lisa", 18000);

            Console.WriteLine("Enter a new employee, Quit with Q");

            //loop until we press Q
            do
            {
                string name = Util.AskForString("Name: ");
                if (name == "Q") break;             //Break exits the loop

                int salary = Util.AskForInt("Salary: ");

                payroll.Add(name, salary);
            }
            while (true); //Endless loop

            //Employee[] employees = payroll.GetEmployees();
            //Console.WriteLine(employees[0].Name);
            //employees[0] = null;
            //var emp2 = payroll.GetEmployees();
            //Console.WriteLine(emp2[0].Name);

            //loop on all employees in payroll
            foreach (var emp in payroll.GetEmployees())
            {
                //Console.Writeline() method does a .ToString() on every employee in payroll
                Console.WriteLine(emp);
            }

        }
    }
}
