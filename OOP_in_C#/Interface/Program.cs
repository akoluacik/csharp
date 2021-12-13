using System;

namespace Interface
{
    
    class Manager : IPersonel , IBeings
    {
        public Manager(string _fullName, string _address, string _department, double _wage)
        {
            this.FullName = _fullName;
            this.Address = _address;
            this.Department = _department;
            this.Wage = _wage;
        }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public double Wage { get; set; }
        public void Info()
        {
            Console.WriteLine($"The personel named {this.FullName} is manager of {this.Department}");
        }
    }

    class Worker : IPersonel , IBeings
    {
        public Worker(string _fullName, string _address, string _department, double _wage)
        {
            this.FullName = _fullName;
            this.Address = _address;
            this.Department = _department;
            this.Wage = _wage;
        }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public double Wage { get; set; }
        public void Info()
        {
            Console.WriteLine($"The personel named {this.FullName} is worker of {this.Department}");
        }
    }

    class Robot : IBeings
    {
        public string Department { get; set; }
        public Robot(string _department)
        {
            this.Department = _department;
        }
        public void Info()
        {
            Console.WriteLine($"This is a robot of {this.Department}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Manager m = new Manager();
            // Worker w = new Worker();

            var personels = new IBeings[4];
            personels[0] = new Manager("John", "Doe", "IT", 10000);
            personels[1] = new Worker("Catherine", "Doe", "Production", 3000);
            personels[2] = new Worker("Max", "Doe", "Quality&Inspection", 2750);
            personels[3] = new Robot("Production");

            foreach (var personel in personels)
            {
                personel.Info();
            }
        }
    }
}
