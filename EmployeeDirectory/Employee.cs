namespace EmployeeDirectory
{
    internal class Employee
    {
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
            return $"Name: {Name} Salary: {Salary}";
        }

        //propfull shortcut
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