using System;
using dotnet.src.Entities;

class Program
    {
        static void Main(string[] args)
        {
            Luffy pirate = new Luffy("Luffy", "Gomu Gomu no mi ", "Gatling Gun ", "Pistol ", "Gear 5");

            System.Console.WriteLine(pirate);
            System.Console.WriteLine(pirate.Gear());
            System.Console.WriteLine(pirate.Attack());

        }
    }

