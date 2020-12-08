using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryBehavioralPetterns
{
    public class DoneEvent : EventState
    {
        public DoneEvent(Event Event) : base(Event)
        {
        }

        public override string notify()
        {
            //if (something) { 
           
            //}
            return "DONE event";
        }
    }
}
