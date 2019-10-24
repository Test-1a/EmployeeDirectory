namespace EmployeeDirectory
{
    internal class Employee
    {
        public SalaryLevel SalaryLevel
        {
            get
            {
                if (Salary < 15000)
                {
                    return SalaryLevel.Junior;
                }
                else
                {
                    return SalaryLevel.Senior;
                }
            }
        }

        //Property
        //prop shortcut
        public string Name { get; set; }

        //Property
        public int Salary { get; set; }

        //Constructor requires name and salary, removes the empty constructor
        //ctor shortcut
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        //This method runs when you call ToString() on a employee instance
        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary} SalaryLevel: {SalaryLevel}";
        }

        //propfull shortcut
        //private string name;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}


        public void SetName(string name)
        {
            Name = name;
        }

        //public string GetName()
        //{
        //    return this.name;
        //}

    }

    public enum SalaryLevel
    {
        Junior,
        Senior
    }
}