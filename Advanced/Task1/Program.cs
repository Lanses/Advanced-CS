using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            var result = new Class1();
            Handling showresult = new Handling();
            showresult.ShowResult(x,y);
            
            //result.NumbersMultiplied -= HandleMultiplying;
            result.Multiplying(x,y);

        }
    }
}
