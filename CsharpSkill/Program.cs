using System;

namespace CsharpSkill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i = 3;
            Console.WriteLine(i);
            Console.WriteLine(i++);
            Console.WriteLine(i);
            Console.ReadLine();

            double a = 1.5;
            Console.WriteLine(a);   // output: 1.5
            Console.WriteLine(++a); // output: 2.5
            Console.WriteLine(a);   // output: 2.5
            Console.WriteLine(16.8m / 4.1m);

            int x = 5;
            x += 5;
            Console.WriteLine(x);
            x -= 3;
            Console.WriteLine(x);

            int t = 0b_0000_1111_0000_1111;
            int b = ~t;
            Console.WriteLine(Convert.ToString(b, toBase: 2));

            //uint a = 60;            /* 60 = 0011 1100 */
            //int b = 13;            /* 13 = 0000 1101 */
            //int c = 0;

            //c = a & b;             /* 12 = 0000 1100 */
            //Console.WriteLine("Line 1 - Value of c is {0}", c);

            uint a1 = 0b_1111_1000;
            uint b1 = 0b_1001_1101;
            uint c1 = a1 & b1;
            //Console.WriteLine(c1);
            Console.WriteLine(Convert.ToString(c1, toBase: 2));






        }
    }
}
