using System;
using System.Text;

namespace String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); //You can change the objects (with string you can't)

            Console.WriteLine("Do you want to include second phrase");
            string response = Console.ReadLine();

            string firstPhrase = "Lord of the ring";
            string secondPhrase = "Is my favourite book";
            string thirdPhrase = "Its Author is";

            sb.AppendLine(firstPhrase);
            if (response == "yes")
            {
                sb.AppendLine(secondPhrase);
            }
            sb.AppendLine(thirdPhrase);

            Console.WriteLine(sb.ToString());

            Console.WriteLine(sb.Length);
        }
    }
}
