using System;
using Adapter.Example2.Interfaces;

namespace Adapter.Example2
{
    public class AsianLion : ILion
    {
        public string Description => "Asian lion";

        public void Roar()
        {
            throw new NotImplementedException();
        }
    }
}
