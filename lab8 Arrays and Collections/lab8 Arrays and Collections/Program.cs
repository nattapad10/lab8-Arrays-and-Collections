using System;


namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayA = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] ArrayB = new int[6];
            ArrayB = ArrayA;
            Console.WriteLine("*** Array copy by operator = ***");
            Console.WriteLine("===== Before =====");
            int i;
            for (i = 0; i < 6; i++)
            {
                Console.WriteLine("arrayA[{0}] = {1}, ArrayB[{0}] = {2}",i, ArrayA[i], ArrayB[i]);
            }
            // change element 0 of ArrayA
            ArrayA[0] = 9;
            Console.WriteLine("===== After ======");
            for (i = 0; i < ArrayA.Length; i++)
            {
                Console.WriteLine("ArrayA[{0}] = {1}, ArrayB[{0}] = {2}", i, ArrayA[i], ArrayB[i]);
            }

            int[] ArrayC = new int[6];
            Array.Copy(ArrayA, ArrayC, ArrayA.Length);
            Console.WriteLine("*** Array copy by method Array.Copy() ***");
            Console.WriteLine("===== Before =====");
            for (i = 0; i < ArrayA.Length; i++)
            {
                Console.WriteLine("ArrayA[{0}] = {1}, ArrayC[{0}] = {2}", i, ArrayA[i], ArrayC[i]);
            }
            // change element 0 of ArrayA
            ArrayA[0] = 1;
            Console.WriteLine("===== After =====");
            for (i = 0; i < ArrayA.Length; i++)
            {
                Console.WriteLine("ArrayA[{0}] = {1}, ArrayC[{0}] = {2}", i, ArrayA[i], ArrayC[i]);
            }

            Console.ReadLine();
        }
    }

}
    


