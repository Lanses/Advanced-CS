using Event;
using InterfaceImplementation;
using Interfaces;
using SomeStuff;
using System;

namespace Travel_Project_v1
{
    class Program
    {

        //Dictionary
        static void Main(string[] args)
        {

            //Event

            double d = double.Parse(Console.ReadLine());
            var priceFlight = new EventLogic();
            EventHandling showPrice = new EventHandling();
            showPrice.ShowTotalFlightPrice(d);
            priceFlight.PriceOfFlight(d);

            IPerson owner = new CompanyOwner("Bill", "Rogers");
            IPerson secreatry = new Secretary("Sofia", "Blanc");
            owner.Status();
            owner.Status();
            secreatry.Status();


            var information = new Info();
            information.InfoMessage();

            Console.WriteLine("Please enter your name and last name: ");
            var customerName = Console.ReadLine();
            var customerLastName = Console.ReadLine();
            Console.WriteLine(value: $"Hello, {customerName} {customerLastName}");
            Console.WriteLine("\n");


            Console.WriteLine("Please fill departure country: ");
            var departureCountry = Console.ReadLine();
            Console.WriteLine("\n");



            Console.WriteLine("Please fill destination country: ");
            var destinationCountry = Console.ReadLine();
            Console.WriteLine("\n");



            Console.WriteLine("Please enter number of persons: ");
            var numberOfPersons = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            if (numberOfPersons <= 1)
            {
                Console.WriteLine($"Hello, total price of your ticket is: ");
            }
            else
            {
                Console.WriteLine($"Hello, total price of your tickets is: ");
            }
            Console.ReadLine();


        }
    }
}
