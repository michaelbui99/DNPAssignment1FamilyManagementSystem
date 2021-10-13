using System.Collections.Generic;

namespace DNPAssignment1FamilyManagementSystem.Models.Util
{
    public class EventCoordinator : IEventCoordinator
    {
        private List<IEventListener> _listeners = new List<IEventListener>(); 
        
        public void Notify()
        {
            _listeners.ForEach(l => l.Notify());
        }

        public void Attach(IEventListener listener)
        {
            _listeners.Add(listener);
        }

        public void Detach(IEventListener listener)
        {
            _listeners.Remove(listener); 
        }
    }
}