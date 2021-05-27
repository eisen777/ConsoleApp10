using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] shuffle = new int[source.Length];
            int j;
            int t = 0;
            int i = 0;
            Random rand = new Random();
            while (t < source.Length)
            {
                j = rand.Next(10);
                if (shuffle[j] == 0)
                {
                    shuffle[j] = source[i];
                    i++;
                    t++;
                }
            }
            for (int k = 0; k < shuffle.Length; k++)
            {
                Console.WriteLine(shuffle[k]);
            }
        }
        //static int GenerateDigit(Random rng)
        //{
            
           // return rng.Next(10);
        //}
    }
}
