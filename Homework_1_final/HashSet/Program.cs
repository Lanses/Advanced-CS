using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        HashSet<char> hs = new HashSet<char>("Hello Mykhailo");

        Console.WriteLine(hs.Contains('!'));
    }
}