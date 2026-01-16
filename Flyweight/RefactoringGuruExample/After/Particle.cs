using System;
using Flyweight.RefactoringGuruExample.Interfaces;

namespace Flyweight.RefactoringGuruExample.After
{
    public class Particle : IParticle
    {
        // 8B
        public Coordinates Coordinates { get; set; }

        // 16B
        public Vector Vector { get; set; }

        // 4B
        public Color Color { get; set; }

        // 4B
        public int Speed { get; set; }

        // 20KB
        public Sprite Sprite { get; set; }

        public void Draw(Canvas canvas)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}