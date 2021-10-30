using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm asendab kõik "o" tähed lauses "Hello, world" tärniga (*)

            string helloW = "Hello, World!";

            helloW = helloW.Replace("o", "*");
            Console.WriteLine(helloW);
        }
    }
}
