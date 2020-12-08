using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryBehavioralPetterns
{
    public class NewEvent : EventState
    {
        public NewEvent(Event Event) : base(Event)
        {
        }

        public override string notify()
        {
            //if (something) { 
                Event.ChangeState(new PlanEvent(Event));
            //}
            return "NEW event";
        }
    }
}
