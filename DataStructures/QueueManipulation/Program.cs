using System;
namespace QueueManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue <int> q= new Queue<int>(10);
            


            for(int i=0; i<q.Items.Length; i++)
            {
                System.Console.WriteLine("Enter the"+" "+i+" "+"Value: ");
                q.Enqueue(Convert.ToInt16(Console.ReadLine()));
              
            }

        System.Console.WriteLine("Values in Queue");
        foreach(int value in q.Items)
        {
            System.Console.WriteLine(value+" ");
        }


        System.Console.WriteLine("Element from queue "+q.Dequeue());
        System.Console.WriteLine("Element from queue "+q.Dequeue());

       
            


            


       } 
        
                
    }
    
}