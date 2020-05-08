using System;

namespace SplitTextByCherta
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Hello\World\How\Are\you";

            string[] words = text.Split('\\');

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
