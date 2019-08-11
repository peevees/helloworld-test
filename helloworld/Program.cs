using System;

namespace helloworld
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello World! arguments: {args.Length}");
            throw new Exception("Test Exception");
        }
    }
}
