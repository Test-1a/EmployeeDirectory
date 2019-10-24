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
            payroll.Add("Lisa", 14000);

            //Employee kalle = new Employee("Kalle", 20000);
            //string name = kalle.Name;
            //kalle.SetName("Nisse");

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
            Employee[] emplopyeess = payroll.GetEmployees();
            foreach (Employee emp in emplopyeess)
            {
                //Console.Writeline() method does a .ToString() on every employee in payroll
                Console.WriteLine(emp);

                if (emp.SalaryLevel.Equals(SalaryLevel.Junior))
                {
                    Console.WriteLine(DoJuniorWork());
                } 
                if (emp.SalaryLevel.Equals(SalaryLevel.Senior))
                {
                    Console.WriteLine(DoSeniorWork());
                }

                switch (emp.SalaryLevel)
                {
                    case SalaryLevel.Junior:
                        Console.WriteLine(DoJuniorWork());
                        break;
                    case SalaryLevel.Senior:
                        Console.WriteLine(DoSeniorWork());
                        break;
                    default:
                        break;
                }

                Console.WriteLine(emp.SalaryLevel.Equals(SalaryLevel.Junior) ? DoJuniorWork() : DoSeniorWork());
               

                 string workResult = 
                    emp.SalaryLevel == SalaryLevel.Junior ? 
                    DoJuniorWork() 
                    : DoSeniorWork();


                Console.WriteLine();
                Console.WriteLine("-----------------");
            }

        }

        private static string DoSeniorWork()
        {
            return "DoSeniorWork";
        }

        private static string DoJuniorWork()
        {
            return "DoJuniorWork";
        }
    }
}
