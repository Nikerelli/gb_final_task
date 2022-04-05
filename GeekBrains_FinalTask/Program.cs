using System;
using System.Linq;

namespace GeekBrains_FinalTask
{
    class Program
    {
        private static string[] _defaultArray =
        {
            "some",
            "default",
            "strings",
            "is",
            "here",
            "lol"
        };
        
        static void Main()
        {
            Console.WriteLine("To exit program type 'z' or close it manually");
            Console.WriteLine("Would u like to enter string array manually? [y|n]");
            ConsoleKeyInfo symb;
            do
            {
                symb = Console.ReadKey();
            } while (symb.Key != ConsoleKey.Z  && symb.Key != ConsoleKey.Y && symb.Key != ConsoleKey.N);

            if (symb.Key == ConsoleKey.Z)
            {
                Console.WriteLine("\nApp has been exited with staus code 0");
                Environment.Exit(0);
            }
            
            var arr = (symb.Key == ConsoleKey.Y
                    ? GetFromKeyBoard()
                    : _defaultArray)
                .Where(x => x.Length <= 3);

            Console.WriteLine();
            if (symb.Key == ConsoleKey.N)
            {
                Console.WriteLine("Default array is:");
                Console.WriteLine(string.Join(' ', _defaultArray));
                
            }
            
            Console.WriteLine();
            Console.WriteLine("Result:");
            foreach (var str in arr)
            {
                Console.WriteLine(str);
            }
        }

        static string[] GetFromKeyBoard()
        {
            Console.WriteLine();
            Console.WriteLine("Write down any strings delimited by space ' '");
            return Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
        }
    }
}
