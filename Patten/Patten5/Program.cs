using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 3;
            int l = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (l == 1)
                    {
                        Console.Write(k);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    k++;
                    l = k % 2;
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }

    }
}