using AbstractFactory.Items.Interfaces;

namespace AbstractFactory.Items
{
    public class LeatherSofa : ISofa
    {
        public int NumberOfSeats => 4;

        public string Description => "Luxury leather sofa";
    }
}
