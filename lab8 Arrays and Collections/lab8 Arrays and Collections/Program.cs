using System;
using System.Collections;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable weeks = new Hashtable();
            weeks.Add("60030029", "nattapad munkid");
            weeks.Add("60030037", "Thanapon Yalan");
            weeks.Add("60030014", "Jimmy");
            weeks.Add("60030049", "nantikan tippawan");
            weeks.Add("60030098", "sittinon tatiyajinda");            
            weeks.Add("60030007", "kasina suksila");
            weeks.Add("60030015", "jinnapat sangasang");
            weeks.Add("60030112", "avirut meechoo");
            weeks.Add("60030041", "thanakorn kodmongkol");
            weeks.Add("60030031", "thanakamon intharasuriyawong");
            weeks.Add("60030089", "sarun chokdurong");
            weeks.Add("60030016", "jirawat chairongsri");

            Console.WriteLine("---- all my friend ----");
            foreach (DictionaryEntry day in weeks)
            {
                Console.WriteLine(day.Key + "   -   " + day.Value);
            }
            Console.WriteLine("---- plz input SID ----");
            Console.WriteLine("" + weeks.ContainsKey(Console.ReadLine()));






            Console.ReadLine();
        }
    }
}



