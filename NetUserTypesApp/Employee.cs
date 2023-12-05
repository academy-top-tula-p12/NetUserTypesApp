using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NetUserTypesApp
{
    internal class Employee
    {
        public string Name;
        public int Age;

        public Employee() : this("Anonim", 0) { }

        public Employee(string name) : this(name, 0) { }

        public Employee(int age) : this("Anonim", age) { }

        public Employee(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {this.Name}, Age: {this.Age}");
        }
    }

    internal class User(string name, int age)
    {
        public void Print()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    internal class Person
    {
        public string Name;
        public int Age;
        public Company Company;
    }

    internal class Company
    {
        public string Title;
    }

    internal record Account
    {
        public string Login;
        public int Code;
    }
}
