using System.Collections.Generic;

namespace Flyweight.RefactoringGuruExample
{
    public class Game
    {
        private readonly Canvas canvas;
        private readonly List<IParticle> particles;

        public Game()
        {
            this.canvas = new Canvas();
            this.particles = new List<IParticle>();
        }

        public Game(Canvas canvas)
        {
            this.canvas = canvas;
        }

        public void AddParticle(IParticle particle)
        {
            this.particles.Add(particle);
        }

        public void Draw()
        {
            foreach (var item in this.particles)
            {
                item.Draw(this.canvas);
            }
        }
    }
}