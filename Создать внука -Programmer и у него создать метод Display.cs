using System;

namespace Создать_внука__Programmer_и_у_него_создать_метод_Display
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }

        public Employee(string name, string company)
                    : base(name)
        {
            Company = company;
        }
        public override sealed void Display()
        {
            Console.WriteLine($"{Name} работает в {Company}");
        }
    }
    class Programmer : Employee
    {
        public string Number { get; set; }

        public Programmer(string name, string company, string number)
                   : base(name, company)
        {
            //Company = company;
           // Name = name;
            Number = number;
        }
        public new void Display()//
        {
            Console.WriteLine($"{Name} работает в {Company} номер {Number}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Bill");
            p.Display();

            Employee emp = new Employee("Tom", "Microsoft");
            emp.Display();

            //Employee p1 = new Person("Tom");
           //p1.Display();

            Programmer prog = new Programmer("Meow", "purr", "101");
            prog.Display();

            Person emp1 = new Employee("Mark", "Nike");
            emp1.Display();

            Person prog1 = new Programmer("Jack", "Sweet", "3");
            prog1.Display();

            Employee prog2 = new Programmer("Kit", "Cat", "77");
            prog2.Display();

            Console.Read();
        }
    }
}
