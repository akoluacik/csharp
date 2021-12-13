using System;

namespace Inheritance
{
    class Person
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        
        public virtual void displayPerson() // child classes do not have overried this, unlike abstract methods
        {
            Console.WriteLine($"Name : {this.Name} Surname : {this.Surname}");
        }
    }

    class Student : Person
    {
        private int StudentNumber { get; set; }
        /* Ctor has to take same arguments, base function handles setting things */
        public Student(string name, string surname, int studentnumber): base(name, surname)
        {
            this.StudentNumber = studentnumber;
            Console.WriteLine("Student Ctor");
        }
        public override void displayPerson()
        {
            Console.WriteLine($"Name : {this.Name} Surname : {this.Surname} Student Number : {this.StudentNumber}");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("John", "Doe");
            var s = new Student("Arthur", "Doe", 120);
            
            p.displayPerson();
            s.displayPerson();

        }
    }
}
