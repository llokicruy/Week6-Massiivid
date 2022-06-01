using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi.

            
            string hello = "Hello, World!";

            for (int i = hello.Length - 1; i >= 0; i--)
            {
                Console.Write(hello[i]);
            }
        }
    }
}
