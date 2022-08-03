using System;

namespace min
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] litt = new int[] {17 , 23, 15, 47, 7, 49 };
            int min = litt[0];
            for (int i = 0; i < litt.Length; i++)
            {
                if (min<=litt[i])
                {

                }
                else
                {
                    min = litt[i];
                }
            }
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
