using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees-ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem, kas ees-või perekonnanimi


            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("sisesta perekonnanimi:");
            string lastName = Console.ReadLine();


            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("sinu eesnimi on pikem kui perekonnanimi");
            }
            else if(firstName.Length < lastName.Length)
            {
                Console.WriteLine("sinu perekonnanimi on pikem kui eesnimi");
            }
            else if(firstName.Length == lastName.Length)
            {
                Console.WriteLine("sinu ees-ja perekonnanimi on sama pikkusega!");
            }
        }
    }
}
