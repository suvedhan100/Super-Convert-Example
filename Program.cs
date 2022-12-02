using System;
//using SuperConvert.Extensions;
//using SuperConvert.Files;
using SuperConvert.Files.Extensions;

namespace Super_Convert_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string jsonFromCsv = ExcelConverter.CsvToJson("D:\\Projects\\Superconvertexample\\Super-Convert-Example\\sample.csv");
            

            Console.WriteLine(jsonFromCsv);
        }
    }
}
