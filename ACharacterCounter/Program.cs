using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada ees- ja perekonnanime
            //programm kuvab, mitu 'a' tähte on kasutaja ees- ja perekonnanimes kokku

            Console.WriteLine("Siseta oma eesnimi:");
            string firstName = Console.ReadLine().ToLower();

            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine().ToLower();

            string fullName = $"{firstName}{lastName}".ToLower();

            Console.WriteLine(fullName);

            int aCounter = 0;

            for(int i = 0; i < firstName.Length; i++)
            {
                if(fullName[i] == 'a')
                {
                    aCounter++;
                }
            }

            if (aCounter != 1)
            {
                Console.WriteLine($"Sinu täisnimes {fullName} on {aCounter} 'a' tähte.");
            }

            else
            {
                Console.WriteLine($"Sinu täisnimes {fullName} on {aCounter} 'a' täht.");
            }
        }
    }
}
 