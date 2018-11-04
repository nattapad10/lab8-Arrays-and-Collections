using System;
using System.Collections;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict1 = new Dictionary<string, string>();
            dict1.Add("TH", "Thailand");
            
         
            
                string value = dict1[Console.ReadLine()];
                Console.WriteLine(value);
            
                
            Console.ReadLine();
        }
    }
}



