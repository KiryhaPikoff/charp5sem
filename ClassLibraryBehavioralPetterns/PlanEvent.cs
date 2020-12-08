using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryBehavioralPetterns
{
    public class PlanEvent : EventState
    {
        public PlanEvent(Event Event) : base(Event)
        {
        }

        public override string notify()
        {
            //if (something) { 
            Event.ChangeState(new AdvertiseEvent(Event));
            //}
            return "PLAN event";
        }
    }
}
