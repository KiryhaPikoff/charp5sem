using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryBehavioralPetterns
{
    public abstract class EventState
    {
        public Event Event { get; }

        public EventState(Event Event) {
            this.Event = Event;
        }

        public abstract string notify();
    }
}
