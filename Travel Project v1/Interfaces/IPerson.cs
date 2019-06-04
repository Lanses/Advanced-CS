using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IPerson
    {
        string Name { get;}
        string LastName { get;}
        void Status();
        void Salary();
    }
}
