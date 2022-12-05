using System;
//using SuperConvert.Extensions;
//using SuperConvert.Files;
using SuperConvert.Files.Extensions;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace Super_Convert_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            CallSuperConvert();
            ConvertToJson();
            
        }

        public static void ConvertToJson()
        {
            var lines = System.IO.File.ReadLines(@"..\sample.csv");
            var csv = new List<string[]>();
            foreach(string line in lines)
            {
                csv.Add(line.Split(','));
            }
            string jsonFromCsv = JsonConvert.SerializeObject(csv, Formatting.Indented);
            

            Console.WriteLine(jsonFromCsv);
        }

        public static void CallSuperConvert()
        {
            string jsonFromCsv = ExcelConverter.CsvToJson(@"..\sample.csv");


            Console.WriteLine(jsonFromCsv);
        }
    }
}
