using System;
using System.Collections.Generic;
using StringLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var splitClassObject =  new SplitClass();
            var lunaList = new List<string>(){
                {"Candy 24.00"},
                {"Shoes 100.00"},
                {"MiniDragon 50.4"}
            };
            splitClassObject.CallingSplitMethod(lunaList);
            Console.WriteLine($"Sum - {splitClassObject.ReturnCalculatedSum()}");
            Console.WriteLine($"Result String - {splitClassObject.ReturnStringMethod()}" );
        }
    }
}
