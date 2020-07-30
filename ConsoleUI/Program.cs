using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            var decimalList = new List<double>();
            String[] test = new String[2];
            string resultString = "";
            double sum = 0;
            var stringList = new List<String>();
            var lunaList = new List<string>(){
                {"Candy 24.00"},
                {"Shoes 100.00"},
                {"MiniDragon 50.4"}
            };
            lunaList.ForEach(element =>{ 
                test = element.Split(' ');
                decimalList.Add(Convert.ToDouble(test[1]));
                stringList.Add(test[0]);
            });
            decimalList.ForEach(element => sum += element);
            stringList.ForEach(element => resultString += element +" ");
            Console.WriteLine($"Sum - {sum}");
            Console.WriteLine($"Result String - {resultString.Trim()}" );
        }
    }
}
