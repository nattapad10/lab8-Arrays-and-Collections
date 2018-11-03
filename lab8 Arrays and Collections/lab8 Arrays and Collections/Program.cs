using System;

namespace lab8_Arrays_and_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int d,m,x;           
            int[] Nday = { 0,3,3,6,1,4,6,2,5,0,3,5};
            string[] day = { "sunday", "Monday", "tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };       
            Console.Write("pla input numberday");
            d = int.Parse(Console.ReadLine());
            Console.Write("pla input numberMo");
            m = int.Parse(Console.ReadLine());

            x = ((d + Nday[m -1]) - 1) % 7;
                   
            Console.WriteLine("{0}/{1}/2560 {2}",d,m,day[x]);


        }
    }
}


