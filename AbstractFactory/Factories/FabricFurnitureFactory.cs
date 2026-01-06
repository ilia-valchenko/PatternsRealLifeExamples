using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Items;
using AbstractFactory.Items.Interfaces;

namespace AbstractFactory.Factories
{
    public class FabricFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new FabricChair();
        }

        public ISofa CreateSofa()
        {
            return new FabricSofa();
        }
    }
}
