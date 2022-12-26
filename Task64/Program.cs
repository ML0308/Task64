using System;


namespace Task64
{
    class Program
    {
        public static void NaturalNumbers(int n)
        {
            if (n > 0)
            {
                Console.Write("{0} ", n);
                NaturalNumbers(n - 1);
            }
        }

        static void Main(string[] args)
        {
            NaturalNumbers(8);
            Console.Read();
        }
    }
}
