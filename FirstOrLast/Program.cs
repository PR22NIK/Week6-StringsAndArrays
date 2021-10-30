using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada ees- ja perekonnanimi
            //Programm kontrollib andmete pikkust
            //Programm kuvab kumb on nendest pikem, kas ees - või perekonnanimi

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            int lastNameLength = lastName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLength} sümbolit.");
            Console.WriteLine($"Sinu perekonnanimes on {lastNameLength} sümbolit.");

            if (firstNameLength > lastNameLength)
            {
                Console.WriteLine("Sinu eesnimi on pikem, kui perekonnanimi");
            }
            if (firstNameLength < lastNameLength)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem, kui eesnimi");
            }
            else
            {
                Console.WriteLine("Sinu ees - ja perekonnanimi on sama pikad");
            }
        }
    }
}
