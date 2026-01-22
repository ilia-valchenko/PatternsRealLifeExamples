namespace Iterator
{
    public class MenuItem
    {
        public string Name { get; }

        public decimal Price { get; }

        public string Description { get; }

        public bool IsVegetarian { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItem"/> class.
        /// </summary>
        public MenuItem(string name, decimal price, string description = null, bool isVegetarian = false)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.IsVegetarian = isVegetarian;
        }

        public override string ToString() =>
            $"Menu item. Name: '{this.Name}'. Description: '{this.Description}'. Price: '{this.Price}'. IsVegetarian: '{this.IsVegetarian}'.";
    }
}
