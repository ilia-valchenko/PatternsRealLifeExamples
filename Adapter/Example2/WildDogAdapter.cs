using Adapter.Example2.Interfaces;

namespace Adapter.Example2
{
    public class WildDogAdapter : ILion
    {
        private readonly WildDog _wildDog;

        public string Description => "Not a lion. Just a wild dog.";

        /// <summary>
        /// Initializes a new instance of the <see cref="WildDogAdapter"/> class.
        /// </summary>
        public WildDogAdapter(WildDog wildDog)
        {
            _wildDog = wildDog;
        }

        public void Roar()
        {
            _wildDog.Bark();
        }
    }
}
