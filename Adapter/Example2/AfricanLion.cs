using System;
using Adapter.Example2.Interfaces;

namespace Adapter.Example2
{
    public class AfricanLion : ILion
    {
        public string Description => "African lion";

        public void Roar()
        {
            throw new NotImplementedException();
        }
    }
}
