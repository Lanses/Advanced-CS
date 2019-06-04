using Disposable;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var example = new FileExample();
            example.WriteToFile("Hello");
            var fileContent = example.ReadFromFile();
        }

    }
}
