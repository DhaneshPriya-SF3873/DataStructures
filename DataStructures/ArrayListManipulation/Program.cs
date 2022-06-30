using System;
namespace ArrayListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
           ArrayList v=new ArrayList(0);
           v.Add(5);
           v.Add(10.5);
           v.Add("Dhanesh");
           v.Add(3);
           v.Add("Priya");
           v.Add("Anupriya");
          

             for(int i=0; i<5; i++)
             {
                 if(v[i]!=null)
                 {
                     System.Console.WriteLine("Value is: "+v[i]);
                 }
             }
             foreach(var value in v.Array)
             {
                 if(value!=null)
                 {
                     System.Console.WriteLine("Value of Array are: "+value.ToString());
                 }
             }



       } 
        
                
    }
    
}