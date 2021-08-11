using System;

namespace AugThird
{
    class Program
    {
        private const string V = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("\n\nRead n number of values in an array and display it in reverse order:\n");
            Console.Write("------------------------------------------------------------------------\n");
            Console.WriteLine("Input the number of elements to store in the array :");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[100];

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nThe stored array\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.Write("\nThe reverse array\n");
            for (int i = n-1; i>=0 ; i--)
            {
                Console.Write(a[i]+" ");
            }
        }
    }
}
