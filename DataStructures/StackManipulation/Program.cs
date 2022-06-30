using System;
namespace StackManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack <int> p=new Stack<int>(5);

            p.Push(10);
            p.Push(20);
            p.Push(30);
           p.PrintStack();
         System.Console.WriteLine("Value poped is "+p.Pop());
         System.Console.WriteLine("Value poped is "+p.Pop());
         System.Console.WriteLine("Value poped is "+p.Pop());

         Stack <char> q=new Stack<char>(5);
         q.Push('a');
         q.Push('b');
         q.Push('c');
         q.PrintStack();
         System.Console.WriteLine("Value poped is "+q.Pop());
         System.Console.WriteLine("Value poped is "+q.Pop());
         System.Console.WriteLine("Value poped is "+q.Pop());




 



       } 
        
                
    }
    
}
