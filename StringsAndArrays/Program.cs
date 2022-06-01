using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm kuvab kasutaja essnime pikkust

            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();

            //int firstNameLength = firstName.Length;
            Console.WriteLine($"sinu eesnimes on {firstName.Length} sümbolit.");
        }
    }
}
