using System;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            /////Quiz1///////
            /* int a = 0;
             for (int i = 0; i < 1000; i++)
             {
                 if (i % 3 == 0 || i % 5 == 0) a += i;
             }
             Console.WriteLine("{0}", a);
             Console.ReadLine();*/

            /////Quiz2///////
             /*
            int iio = 0, io = 1, r = 0; ;
            for (int i = 2; i < 4000000; i=iio)
            {
                iio = io + i;
                io = i;
                if (i% 2 == 0) r +=i;
                
            }
            Console.WriteLine("{0}", r);
            Console.ReadLine();*/

            /////Quiz3///////
            long a = 600851475143;
            for (int i = 2; i < a; i++)
            {
                while (a % i == 0)a = a / i;
            }
            Console.WriteLine("최대소인수{0}", a);
            Console.ReadLine();
        }
    }
}
