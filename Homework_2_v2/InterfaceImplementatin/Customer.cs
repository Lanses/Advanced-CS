using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceImplementatin
{
    public abstract class Customer : IPerson
    {

        public abstract string Name { get; }

        public abstract string LastName { get; }


        public virtual void Status()
        {
            Console.WriteLine("I'm a novice in flights");
        }

        public abstract void Salary();

    }
}
