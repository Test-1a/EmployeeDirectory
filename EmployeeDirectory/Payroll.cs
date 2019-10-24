using System;
using System.Collections.Generic;

namespace EmployeeDirectory
{
    public class Payroll
    {
        //Private collection of employee objects
        //Only accessable from inside this class
        private List<Employee> employees;

        //Construktor runs when a payroll is created ( new Payroll() )
        public Payroll()
        {
            //Initializes a new List
            employees = new List<Employee>();
        }

        internal void Add(string name, int salary)
        {
            //New instance of employee
            Employee emp = new Employee(name, salary);
            //Add emplyee to list
            employees.Add(emp);
        }

        internal Employee[] GetEmployees()
        {
            //Returns a copy of emplyee list
            return employees.ToArray();
        }
    }
}