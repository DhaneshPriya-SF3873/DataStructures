using System;
namespace DictionaryManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryDS<int,string> value=new DictionaryDS<int,string>(0);
            value.Add(1,"Dhanesh");
            value.Add(2,"Priya");
          
            
            
            for (int i=0; i<value.Count; i++)
            {
                if(value!=null)
                {
                 System.Console.WriteLine("Key: "+value[i].Key+"\t"+"Value: "+value[i].Value);
                }
                
            }

            foreach(var entry in value.Array)
            {
                if(entry!=null)
                {
               System.Console.WriteLine("Key: "+entry.Key+" "+"Value : "+entry.Value);
                }

                
            }


       } 
        
                
    }
    
}