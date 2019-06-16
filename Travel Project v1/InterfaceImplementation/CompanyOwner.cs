using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceImplementation
{
    public class CompanyOwner : IPerson
    {

        public string Name { get; }

        public string LastName { get; }

        public CompanyOwner(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public  void Status()
        {
            Console.WriteLine("I'm an owner of flights company!");
        }

        public virtual void Salary()
        {
            Console.WriteLine("My salary is 1000$");
        }
    }
}
