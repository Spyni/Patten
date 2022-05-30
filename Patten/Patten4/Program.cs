using System;

class Program
{
    static void Main(string[] args)
    {
        int k = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(k);
                k++;
                
            }
            for (int l=3-i+1;l>=1;l--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadLine();

    }

}