namespace EmployeeDirectory
{
    internal class Employee
    {
        //prop
        private string name;

        public string Name { get; set; }
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        if (value != null)
        //        {
        //            name = value;
        //        }
        //    }
        //}

        public int Salary { get; set; }

        public Employee(string name, int salary)  
        {
            Name = name;
            Salary = salary;
        }


        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }

        //propfull
        //private string name;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}


        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

        //public string GetName()
        //{
        //    return this.name;
        //}

    }
}