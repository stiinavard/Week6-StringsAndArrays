using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada ees-ja perekonnanime
            //programm kontrollib andmete pikkust eraldi
            //programm kuvab kumb nendest on pikem, kas ees-või perekonnanimi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            int lastNameLength = lastName.Length;

            if (firstNameLength > lastNameLength)
            {
                Console.WriteLine($"Sinu eesnimi on pikem kui perekonnanimi. Selles on {firstNameLength} sümbolit.");
            }
            else if (lastNameLength > firstNameLength)
            {
                Console.WriteLine($"Sinu perekonnanimi on pikem kui eesnimi. Selles on {lastNameLength} sümbolit.");
            }
            else
            {
                Console.WriteLine("Sinu eesnimi ja perekonnanimi on kumbki sama pikad.");
            }


        }
    }
}
