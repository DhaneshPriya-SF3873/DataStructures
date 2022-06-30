using System;
namespace FunctionDelegate
{
    class Program
    {
      static double Sum(int a,int b)
      {
          return a+b;
      }
      static double Substract(int a, int b)
      {
          return a-b;
      }
      static double Multiply(int a, int b)
      {
          return a*b;
      }
      static double Divide(int a, int b)
      {
          return (double)a/b;
      }
      static double Calculate(Func<int,int,double>operation,int x, int y)
      {
          return operation(x,y);
      }

        static void Main(string[] args)
        {
            System.Console.WriteLine(Calculate(Divide,10,20));
            System.Console.WriteLine(Calculate(Sum,10,20));
            
            


       } 
        
                
    }
    
}
