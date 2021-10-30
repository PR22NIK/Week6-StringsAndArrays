using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada eesnime
            //Programm kuvab kasutaja eesnime pikkuse

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLength} sümbolit.");
        }
    }
}
