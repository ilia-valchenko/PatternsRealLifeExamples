using Adapter.Example2.Interfaces;

namespace Adapter.Example2
{
    public class MainApp
    {
        public void Main()
        {
            WildDog wildDog = new WildDog();
            IHunter hunter = new SimpleHunter();
            WildDogAdapter wildDogAdapter = new WildDogAdapter(wildDog);

            hunter.Hunt(wildDogAdapter);
        }
    }
}
