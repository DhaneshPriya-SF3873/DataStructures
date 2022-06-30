using System;
namespace HashTableManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable value=new HashTable(0);
            value.Add(1,"Dhanesh");
            value.Add(2,"Priya");
            value.Add(3,5.5);
            value.Add(4,7);
            value.Add(5,9.555);
          
            
            for (int i=0; i<value.Count; i++)
            {
                if(value!=null)
                {
                 System.Console.WriteLine("Key: "+value[i].Key+"\t"+"Value: "+value[i].Value);
                }
                
            }

            foreach(ObjectArray entry in value.tables)
            {
                if(entry!=null)
                {
               System.Console.WriteLine("Key: "+entry.Key+" "+"Value : "+entry.Value);
                }

                
            }

            


       } 
        
                
    }
    
}