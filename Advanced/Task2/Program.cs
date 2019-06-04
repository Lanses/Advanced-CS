using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var _filePath = @"C:\Users\Alexander\Desktop\ITEA_C-\Advanced\Person.txt";
            //var person = new Person("555","John","Thomson");

            Person[] h = new Person[5];
            h[0] = new Person("1", "John", "Thomson");
            h[1] = new Person("2", "John", "Thomson");
            h[1] = new Person("3", "John", "Thomson");
            h[1] = new Person("4", "John", "Thomson");
            h[1] = new Person("5", "John", "Thomson");
            //for (int i = 0; i < h.Length; i++)
            //{
                
            //}

            using (var stream = new StreamWriter(_filePath))
            {
                for (int i = 0; i < h.Length; i++)
                {
                    stream.WriteLine(h[4]);
                }
            }


            //using (var stream = new StreamWriter(_filePath))
            //{
            //    stream.WriteLine(person.ToString());
            //}


        }
    }
}
