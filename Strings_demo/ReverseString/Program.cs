using System;
using System.Linq;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();


            ////Option 1
            //var reversed = word.Reverse();

            ////Option 2
            //char[] wordArr = word.ToCharArray();

            ////Option 3
            StringBuilder sb = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                sb.Append(word[i]);
            }

            Console.WriteLine(String.Join("", sb.ToString( )));


        }
    }
}
