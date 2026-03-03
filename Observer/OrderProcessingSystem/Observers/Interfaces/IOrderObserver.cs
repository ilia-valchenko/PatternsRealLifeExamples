using Observer.OrderProcessingSystem.Subject;

namespace Observer.OrderProcessingSystem.Observers.Interfaces
{
    public interface IOrderObserver
    {
        void Update(Order order);
    }
}
