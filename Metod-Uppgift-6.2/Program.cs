using System;

namespace Uppgift_6_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Största(10, 20));
        }

        static int Största(int tal1, int tal2)
        {
            if (tal1 < tal2) return tal2;
            else if (tal1 > tal2) return tal1;
            else return tal1 + tal2;
        }
    }
}