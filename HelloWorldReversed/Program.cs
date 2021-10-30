using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm kuvab "Hello, world!" tagurpidi

            for (int i = "Hello World!".Length - 1; i >= 0; i--)
            {
                Console.Write("Hello World!"[i]);
            }
        }
    }
}
