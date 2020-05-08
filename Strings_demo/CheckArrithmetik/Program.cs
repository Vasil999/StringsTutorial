using System;

namespace CheckArrithmetik
{
    class Program
    {
        static void Main(string[] args)
        {
            string arithmetic = Console.ReadLine();

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < arithmetic.Length; i++)
            {
                if (arithmetic[i] == ')')
                {
                    sum1++;
                }
                else if (arithmetic[i] == '(')
                {
                    sum2++;
                }
            }

            if (sum1 != sum2)
            {
                Console.WriteLine("Invalid");
                return;
            }

            int openIndex = arithmetic.IndexOf('(');
            int closeIndex = arithmetic.IndexOf(')');

            if (openIndex > closeIndex)
            {
                Console.WriteLine("Invalid");
                return;
            }

            for (int i = 0; i < arithmetic.Length; i++)
            {
                if (arithmetic[i] == '(')
                {
                    int isThereClosing = arithmetic.IndexOf(')', i);

                    if (isThereClosing == 0)
                    {
                        Console.WriteLine("Invalid");
                        return;
                    }
                }

            }
            Console.WriteLine("Valid");
        }
    }
}
