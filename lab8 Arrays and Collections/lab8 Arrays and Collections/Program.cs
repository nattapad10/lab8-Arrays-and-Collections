using System;

namespace lab8_Arrays_and_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            //data[-1] = 0;
            data[1] = 1;
            data[9] = 9;
            //data[10] = 10;
            //Console.WriteLine(data[-1]);
            Console.WriteLine(data[1]);
            Console.WriteLine(data[9]);
            //Console.WriteLine(data[10]);
            Console.WriteLine("............................");
            Console.WriteLine(data[7]);
            Console.WriteLine("............................");
            Console.WriteLine(data[4]+ data[9]);
            Console.WriteLine("............................");
            if (data[2]==data[6])
                Console.WriteLine("data[2]=data[6]");
            if (data[2] != data[6])
                Console.WriteLine("data[2]=!data[6]");
            Console.WriteLine("............................");
            int i,n ;
            n = 0;
            for (i = 0; i < 10; i++)
            {
                n = n + data[i];
                
            }
            Console.WriteLine("sum = {0}", i);
            Console.WriteLine("............................");
            for (i=0;i<10;i++)
            {
                Console.WriteLine("arry{0}={1}",i,data[i]);
            }
            Console.ReadLine();

        }
    }
}
