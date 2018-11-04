using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplyTable = new int[12, 12];

            int a, b;
            for (a = 0, b = 2; a < 13 && b < 14; a++, b++)
            {
            multiplyTable[0, a] = b * 1;       
            multiplyTable[1, a] = b * 2;
            multiplyTable[2, a] = b * 3;
            multiplyTable[3, a] = b * 4;
            multiplyTable[4, a] = b * 5;
            multiplyTable[5, a] = b * 6;
            multiplyTable[6, a] = b * 7;
            multiplyTable[7, a] = b * 8;
            multiplyTable[8, a] = b * 9;
            multiplyTable[9, a] = b * 10;
            multiplyTable[10, a] = b * 11;
            multiplyTable[11, a] = b * 12;

            }
               



            for (int row = 0; row < multiplyTable.GetLength(0); row++)
            {
                for (int col = 0; col < multiplyTable.GetLength(1); col++)
                {
                    
                    Console.Write("{0,5}", multiplyTable[row, col]);
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}




