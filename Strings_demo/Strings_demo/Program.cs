using System;

namespace Strings_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string word = "Hello World! How are you today?";

            //char ch = word[0];

            //// but you can't change a char: word[0] = a wouldn't work

            //Console.WriteLine($"word = {word}");
            //Console.WriteLine($"word.Lenght = {word.Length}");

            //for (int i = 0; i < word.Length; i++)
            //{
            //    Console.WriteLine($"word[{i}] = {word[i]}");
            //}

            ////Escaping:

            //Console.WriteLine("The name of the book is \"Lord of the rings\".");

            //string source = "Some source";
            //string assigned = source;
            //source = "something else";

            //Pet kotka = new Pet() { Name = "Gosho", Age = 13 };

            //Pet kotka2 = kotka;

            //kotka.Name = "Pesho";

            //Console.WriteLine(kotka2.Name);
            //Console.WriteLine(assigned); //property of string - can't be changed

            //variations for adding strings: 
            //string hello = "Hello";
            //string world = "World";

            //string firstWay = hello + " " + world;

            //string secondWay = string.Format("{0} {1}", hello, world);

            //string thirdWay = $"{hello} {world}";

            //Console.WriteLine(firstWay);
            //Console.WriteLine(secondWay);
            //Console.WriteLine(thirdWay);

            ////Are two strings equal?

            //string word1 = "C#";
            //string word2 = "c#";

            //Console.WriteLine(word1.Equals("C#"));
            //Console.WriteLine(word1.Equals(word2, 
            //    StringComparison.CurrentCultureIgnoreCase));
            //Console.WriteLine(word1 == "C#");
            //Console.WriteLine(word1 == word2);

            ////lexicographic comparision:

            //string score = "sCore";
            //string scary = "scary";

            //Console.WriteLine(score.CompareTo(scary));
            //Console.WriteLine(scary.CompareTo(score));
            //Console.WriteLine(scary.CompareTo(scary));

            ////search in strings: 

            //string book = "    Lord, of, the, Ring, of";

            //int index = book.IndexOf("of", 6);

            //var subString = book.Substring(5,4);
            //Console.WriteLine(subString);

            //int lastIndex = book.LastIndexOf("of");
            //Console.WriteLine(lastIndex);

            //bool result = book.EndsWith("of");
            //Console.WriteLine(result);

            //bool result1 = book.StartsWith("Lord");
            //Console.WriteLine(result1);

            //Console.WriteLine(book.ToLower());

            //Console.WriteLine(book.ToUpper());

            ////// 1
            ////// 0000000001 / 04.05.2020

            ////string invoiceNum = "356";

            ////string invoiceNumPadded = invoiceNum.PadRight(10, '0');

            ////Console.WriteLine(invoiceNumPadded);

            //string[] words = book.Split(new char[] { ' ',',' }, 
            //    StringSplitOptions.RemoveEmptyEntries);

            //Console.WriteLine(string.Join(",", words));

            //Console.WriteLine(book.Trim());

            //Console.WriteLine(book.Replace('o', 'h'));
            //Console.WriteLine(book.Replace("Lord", "Short"));

            //char[] charArray = book.ToCharArray();

            //Console.WriteLine(string.Join(", ", charArray));





        }
    }

    public class Pet
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
