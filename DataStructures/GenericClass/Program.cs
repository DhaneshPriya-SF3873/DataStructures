using System;
namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Array<int>value1=new Array<int>();
          //Assinging values using Indexers
            value1.ArrayInfo=new int[5];
            value1[0]=12;
            value1[1]=13;
            value1[2]=14;
            value1[3]=15;
            for(int i=0; i<4; i++)
            {
                System.Console.WriteLine(value1[i]);
            }
            /*value1.ArrayInfo=new int[]{1,2,3,4,5,6,7};
        

            foreach(int value in value1.ArrayInfo)
            {
                System.Console.WriteLine(value);
            }*/



       } 
        
                
    }
    
}