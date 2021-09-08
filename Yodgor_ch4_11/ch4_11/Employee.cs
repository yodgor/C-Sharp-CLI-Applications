namespace ch4_11
{
    class Employee
    {
        //creating variables
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        private decimal _msalary;

        public Employee(string fname, string lname, decimal msalary)
        {
            FirstName = fname;
            LastName = lname;
            MonthlySalary = msalary;
        }

        public decimal MonthlySalary
        {
            get
            {
                return _msalary;
            }
            set
            {
                if (value > 0)
                {
                    _msalary = value;
                }
                else
                {
                    _msalary = 1; 
                }
            }
        }
    }
}