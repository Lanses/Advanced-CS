using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task2
{
    public class Person
    {
        
        public string Id { get; }
        public string Name { get; }
        public string Surname { get; }

        public Person(string id, string name, string sname)
        {
            Id = id;
            Name = name;
            Surname = sname;
        }


        public override string ToString()
        {
            return $"Id = {Id} Name = {Name} Surname = {Surname}";

        }


        
    }
}
