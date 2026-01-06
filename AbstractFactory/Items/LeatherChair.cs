using AbstractFactory.Items.Interfaces;

namespace AbstractFactory.Items
{
    public class LeatherChair : IChair
    {
        public int NumberOfLegs => 3;

        public string Description => "Luxury leather chair";
    }
}
