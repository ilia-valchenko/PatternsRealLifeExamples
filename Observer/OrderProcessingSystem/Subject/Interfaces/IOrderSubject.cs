using Observer.OrderProcessingSystem.Observers.Interfaces;

namespace Observer.OrderProcessingSystem.Subject.Interfaces
{
    public interface IOrderSubject
    {
        void Attach(IOrderObserver observer);
        void Detach(IOrderObserver observer);
        void Notify();
    }
}
