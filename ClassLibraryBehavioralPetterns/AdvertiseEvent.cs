using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryBehavioralPetterns
{
    public class AdvertiseEvent : EventState
    {
        public AdvertiseEvent(Event Event) : base(Event)
        {
        }

        public override string notify()
        {
            //if (something) { 
            Event.ChangeState(new DoneEvent(Event));
            //}
            return "ADVERTISE event";
        }
    }
}
