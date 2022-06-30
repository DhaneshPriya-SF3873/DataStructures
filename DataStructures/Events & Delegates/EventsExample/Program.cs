using System;
namespace EventsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EventsExample event1= new EventsExample("Quiz");
            EventsExample event2= new EventsExample("Debugging");
            EventsExample event3= new EventsExample("Presentation");
            EventsExample event4= new EventsExample("Games");


            //Event registration by management
            //Subscribe to events
            EventsExample.eventlink += new EventManager(event1.ShowEvent);
            EventsExample.eventlink += new EventManager(event2.ShowEvent);
            EventsExample.eventlink += new EventManager(event3.ShowEvent);
            EventsExample.eventlink += new EventManager(event4.ShowEvent);

            //Process initiation
            EventsExample.EventStarter(); //Indirectly using a method
            // EventsExample.eventlink(); // Directly using event trigger/Invoking // (another method) eventlink?.Invoke();


            //Event Cancellation/Deregistration
            //Unsubcribe from event
            EventsExample.eventlink -= new EventManager(event4.ShowEvent);
            EventsExample.EventStarter();
            



            


       } 
        
                
    }
    
}
