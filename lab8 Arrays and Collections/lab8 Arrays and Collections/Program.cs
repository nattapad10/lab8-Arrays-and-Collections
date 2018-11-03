using System;

namespace lab8_Arrays_and_Collections
{
    class Program
    {

        static void Main(string[] args)
        {

            string[] array1 = { " January", "February", "March", "April", "May ",
                " June", " July ", "August" , "September", "October", "November", "December"};

            string[] array2 = Array.FindAll(array1,
                   element => element.Length > 10);         
            Console.WriteLine(string.Join(",", array2));

            string[] array3 = { " January", " June", " July ", };
            Console.WriteLine(string.Join(",", array3));

            Console.ReadLine();

        }


    }
        
}


