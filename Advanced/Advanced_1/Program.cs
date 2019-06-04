using System;
using System.Collections;

namespace Advanced_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList objectList = new ArrayList() { 1, 2, "string", "string1" };

            object obj = 5;

            objectList.Add(obj);
            objectList.Add("string2");
            objectList.RemoveAt(0);
            foreach (object o in objectList)
            {
                Console.WriteLine(o);
            }
        }



    }
}
