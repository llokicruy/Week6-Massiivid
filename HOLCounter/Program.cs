using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mittu 'h', 'o' ja 'l' tahte on lauses "Hello World!";



            string helloWorld = "Hello World!".ToLower();

            Console.WriteLine(helloWorld);

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'h')
                {
                    hCounter++;
                }
                else if (helloWorld[i] == 'o')
                {
                    oCounter++;
                }
                else if (helloWorld[i] == 'l')
                {
                    lCounter++;
                }
            }

            Console.WriteLine($"Lauses {helloWorld} on {hCounter} -'h', {oCounter} - 'o' ja {lCounter} - 'l' tähte.");
        }
    }
}
