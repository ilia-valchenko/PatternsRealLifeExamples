using System;
using Adapter.Example2.Interfaces;

namespace Adapter.Example2
{
    public class SimpleHunter : IHunter
    {
        public void Hunt(ILion lion)
        {
            throw new NotImplementedException();
        }
    }
}
