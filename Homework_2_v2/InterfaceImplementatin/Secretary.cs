using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceImplementatin
{
    public class Secretary : CompanyOwner
    {

        public Secretary(string name, string lastName) : base(name, lastName)
        {
        }

        public override void Salary()
        {
            Console.WriteLine("My salary is 500$");
        }

    }
}
