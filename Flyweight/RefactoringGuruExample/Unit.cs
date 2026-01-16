using System;
using Flyweight.RefactoringGuruExample.Interfaces;

namespace Flyweight.RefactoringGuruExample
{
    public class Unit : IUnit
    {
        public void FireAt(IUnit target)
        {
            throw new NotImplementedException();
        }
    }
}