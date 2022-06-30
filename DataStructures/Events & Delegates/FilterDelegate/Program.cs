using System;
using System.Collections.Generic;
namespace FilterDelegate
{
    public delegate bool Filter(Person p);
    class Program
    {
        static void Main(string[] args)
        {
            
           Person person1= new Person(){Name="Dhanesh",Age=23};
           Person person2= new Person(){Name="Priya",Age=40};
           Person person3= new Person(){Name="Anu",Age=12};

           //create a list of person objects and filli it
           List<Person> people=new List<Person>(){person1,person2,person3};

           //Invoke Displaypeople using appropiate delegate
           DisplayPeople("Children:",people, IsChild);
           DisplayPeople("Adults:",people, IsAdult);
            DisplayPeople("Seniors:",people, IsSenior);
             DisplayPeople("Voters:",people, IsVoter);





       } 
        static void DisplayPeople(string title,List<Person> people,Filter filter)
        {
            System.Console.WriteLine(title);
        

        foreach (Person p in people)
        {
            if(filter (p))
            {
                System.Console.WriteLine("Years old: "+p.Name+" "+p.Age);
            }
        }
        }
      static bool IsChild(Person p){ return p.Age<15;}
      static bool IsVoter(Person p){ return p.Age>=18;}
      static bool IsAdult(Person p){ return p.Age>=18;}
      static bool IsSenior(Person p){ return p.Age>=65;}


                
    }
    
}