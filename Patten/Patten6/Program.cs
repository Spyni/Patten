using System;

class Program
{
    static void Main(string[] args)
    {
        int k = 1;
       
        for (int i = 1; i <= 4; i++)
        {
            for (int l = 4;l>i;l--)
            {
                Console.Write("*");
            }
            
                int m = i + k - 1;
                for(int j =0;j<i;j++)
                {
                    Console.Write(m--);
                    k++;
                }
            
           
            Console.WriteLine();
        }
        Console.ReadLine();

    }

}