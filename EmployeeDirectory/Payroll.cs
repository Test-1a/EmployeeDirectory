using System;
using System.Collections.Generic;

namespace EmployeeDirectory
{
    internal class Payroll
    {
        private List<Employee> employees;
        public Payroll()
        {
            employees = new List<Employee>();
        }

        internal void Add(string name, int salary)
        {
            Employee emp = new Employee(name, salary);
            employees.Add(emp);
        }

        internal Employee[] GetEmployees()
        {
            return employees.ToArray();
        }
    }
}