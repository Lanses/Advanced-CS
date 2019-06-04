using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new Counter();
            counter.HundredReached += HandleHundredReached;
            counter.HundredReached -= HandleHundredReached;
            counter.Count();
        }


        public static void HandleHundredReached() { 
        Console.WriteLine("Hundred reached");
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
        }
    }
}
