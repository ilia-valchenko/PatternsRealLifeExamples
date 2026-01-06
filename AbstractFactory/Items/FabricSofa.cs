using AbstractFactory.Items.Interfaces;

namespace AbstractFactory.Items
{
    public class FabricSofa : ISofa
    {
        public int NumberOfSeats => 3;

        public string Description => "Simple fabric sofa";
    }
}
