using AbstractFactory.Items.Interfaces;

namespace AbstractFactory.Factories.Interfaces
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();

        ISofa CreateSofa();
    }
}
