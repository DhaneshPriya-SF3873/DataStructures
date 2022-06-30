using System;
namespace ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> aList=new List<int>();
            aList.AddElement(12);
            aList.AddElement(32);
            aList.AddElement(35);
            aList.AddElement(47);
            aList.AddElement(87);
            aList.DisplayArray();
            aList.AddElement(45);
            aList.AddElement(58);
            aList.AddElement(74);
            aList.DisplayArray();

            foreach (int number in aList)
            {
                System.Console.WriteLine((number));
            }
            


       } 
        
                
    }
    
}
