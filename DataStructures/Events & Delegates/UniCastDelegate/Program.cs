using System;
namespace UniCastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            
          //create delegate instances

        //Unicast
         
          NumberChanger nc1= new NumberChanger(TestDelegate.AddNum);
          NumberChanger nc2= new NumberChanger(TestDelegate.MultNum);

         

          //calling the methods using the delegate objects
          nc1(25);
          System.Console.WriteLine("Value of num "+ TestDelegate.getNum());
          nc2(35);
          System.Console.WriteLine("Value of num "+ TestDelegate.getNum());

       //Multicast
           NumberChanger nc;

           NumberChanger nc3= new NumberChanger(TestDelegate.AddNum);
           NumberChanger nc4= new NumberChanger(TestDelegate.MultNum);


          nc=nc3;
          nc+=nc4;
          nc(5);
          System.Console.WriteLine("Value of num "+ TestDelegate.getNum());
         


        
        



       } 
        
                
    }
    
}