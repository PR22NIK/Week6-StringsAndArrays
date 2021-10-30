using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm asendab kõik "o" tähed lauses "Don't Panic" nulliga (0)
            //Programm asendab kõik "a" tähed samas lauses neljaga (4)

            string lause = "Don't panic!";

            lause = lause.Replace("o", "0");
            lause = lause.Replace("a", "4");

            Console.WriteLine(lause);
        }
    }
}
