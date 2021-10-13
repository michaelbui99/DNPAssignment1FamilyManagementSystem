namespace DNPAssignment1FamilyManagementSystem.Models
{
    /// <summary>
    /// Coordinates events between Components. Is used for giving Parent Components updates
    /// when a Child Component has done an operation on a shared object.
    /// e.g. Child Component has deleted an element from an list and the Parent component must update it's state.   
    /// </summary>
    public interface IEventCoordinator
    {
        void Notify();
        void Attach(IEventListener listener);
        void Detach(IEventListener listener);
    }
}