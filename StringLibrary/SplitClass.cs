using System;
using System.Collections.Generic;

namespace StringLibrary
{
    public  class SplitClass : ISplitClass
    {
        private double sum = 0;
        private string resultString = "";
        private void SplitMethod (List<string> lunaList){
            var stringList = new List<String>();
            
            var decimalList = new List<double>();
            String[] test = new String[2];
            
            lunaList.ForEach(element =>{ 
                test = element.Split(' ');
                decimalList.Add(Convert.ToDouble(test[1]));
                stringList.Add(test[0]);
            });
            sum = DecimalProcessMethod(decimalList);
            resultString = StringProcessMethod(stringList);
            
        }
        private double DecimalProcessMethod(List<double> decimalList){
            decimalList.ForEach(element => sum += element);
            return sum;
        } 

        private string StringProcessMethod(List<string> stringList){
            stringList.ForEach(element => resultString += element +" ");
            return resultString.Trim();
        }
        public void CallingSplitMethod(List<string> lunaList){
            SplitMethod(lunaList);
        }
        public  string ReturnStringMethod(){
            return resultString;
        }
        public double ReturnCalculatedSum(){
            return sum;
        }
    }
}
