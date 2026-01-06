using AbstractFactory.Items.Interfaces;

namespace AbstractFactory.Items
{
    public class FabricChair : IChair
    {
        public int NumberOfLegs => 4;

        public string Description => "Simple fabric chair";
    }
}
