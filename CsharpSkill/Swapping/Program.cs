using System;

namespace Swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Swapping!");
            //int x, y, t;
            //x = int.Parse(Console.ReadLine());
            //y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Before swapping The value of x: " + x);
            //Console.WriteLine("Before swapping the value of y: " + y);
            //t = x;
            //x = y;
            //Console.WriteLine("Running swapping The value of x: " + x);
            //Console.WriteLine("Running swapping the value of y: " + y);
            //y = t;
            //Console.WriteLine("After swapping The value of x: " + x);
            //Console.WriteLine("after swapping the value of y: " + y);

            int[] bubbleshortarray = { 10, 30, 20, 25, 65 };

            for (int i = 0; i < bubbleshortarray.Length-1; i++)
            {
                if (bubbleshortarray[i+1]>bubbleshortarray[i])
                {
                    int temp = bubbleshortarray[i + 1];
                    bubbleshortarray[i + 1] = bubbleshortarray[i];
                    bubbleshortarray[i] = temp;
                }
            }

            Console.WriteLine("First Swap");

            for (int i = 0; i < bubbleshortarray.Length; i++)
            {
                Console.Write(bubbleshortarray[i] + " ");
            }

            for (int i = 0; i < bubbleshortarray.Length - 1; i++)
            {
                if (bubbleshortarray[i + 1] > bubbleshortarray[i])
                {
                    int temp = bubbleshortarray[i + 1];
                    bubbleshortarray[i + 1] = bubbleshortarray[i];
                    bubbleshortarray[i] = temp;
                }
            }

            Console.WriteLine("Second Swipe");

            for (int i = 0; i < bubbleshortarray.Length; i++)
            {
                Console.Write(bubbleshortarray[i] + " ");
            }


            for (int i = 0; i < bubbleshortarray.Length - 1; i++)
            {
                if (bubbleshortarray[i + 1] > bubbleshortarray[i])
                {
                    int temp = bubbleshortarray[i + 1];
                    bubbleshortarray[i + 1] = bubbleshortarray[i];
                    bubbleshortarray[i] = temp;
                }
            }

            Console.WriteLine("Third Swipe");


            for (int i = 0; i < bubbleshortarray.Length; i++)
            {
                Console.Write(bubbleshortarray[i] + " ");
            }

            Console.ReadLine();

        }
    }
}
