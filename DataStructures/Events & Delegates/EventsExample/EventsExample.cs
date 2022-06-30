namespace EventsExample;
using System;
  public delegate void EventManager(); //uesr defined delegates
    public class EventsExample
    {
        private string _eventName;
        public static event EventManager eventlink=null; //user defined event
        static int i;
        public EventsExample(string eventName)
        {
            _eventName=eventName;
        }
        public static void EventStarter()
        {
          i=0;
          System.Console.WriteLine("User Registration");
          HandleEvent();  //calling event trigerring method
        }
        public static void HandleEvent() //Event Trigerring method
        {
          System.Console.WriteLine("Starting the following Events");
          eventlink();   //Event trigger->Like clicking a button 
        }
        public void ShowEvent()  //Explanation about the button click action
        {
          ++i;
          System.Console.WriteLine("Event: "+i+" "+"is"+" "+_eventName+" "+"started");
        }
    }
