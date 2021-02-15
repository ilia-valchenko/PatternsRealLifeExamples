namespace Flyweight.RefactoringGuruExample.After
{
    public class MainApp
    {
        public void Main()
        {
            var game = new Game();

            for (int i = 0; i < 10000; i++)
            {
                game.AddParticle(new Particle
                {
                    Color = new Color(12, 200, 150),
                    Coordinates = new Coordinates(20, 0, 200),
                    Speed = 120,
                    Sprite = new Sprite(),
                    Vector = new Vector()
                }); ;
            }
        }
    }
}