using System;

namespace lab8_Arrays_and_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double[] GPS = new double[9];
            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("Plz input your GPS {0}", i + 1);
                GPS[i] = double.Parse(Console.ReadLine());
                GPS[8] = GPS[8] + GPS[i];
            }

            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("your GPS{0} = {1}", i + 1,GPS[i]);
                if(i==7)
                    Console.WriteLine("your GPA = {0}", GPS[8]/8);

            }
        }
    }
}


