using Interfaces;
using System;

namespace InterfaceImplementation
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
