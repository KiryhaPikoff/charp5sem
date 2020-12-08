using System;

namespace ClassLibraryBehavioralPetterns
{
    public class Event
    {
        private EventState _eventState;
        public EventState EventState { get { return _eventState; } }

        public void ChangeState(EventState EventState) {
            _eventState = EventState;
        }
        public string notify()
        {
            return _eventState.notify();
        }
    }
}
