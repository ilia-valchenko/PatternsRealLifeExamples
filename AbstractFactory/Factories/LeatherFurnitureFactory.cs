using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Items;
using AbstractFactory.Items.Interfaces;

namespace AbstractFactory.Factories
{
    public class LeatherFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new LeatherChair();
        }

        public ISofa CreateSofa()
        {
            return new LeatherSofa();
        }
    }
}
