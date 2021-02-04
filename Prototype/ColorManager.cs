using System;
using System.Collections.Generic;

namespace Prototype
{
    public class ColorManager
    {
        private readonly IDictionary<string, BaseColor> colors = new Dictionary<string, BaseColor>();

        public BaseColor this[string key]
        {
            get
            {
                return this.colors[key];
            }
            set
            {
                if (string.IsNullOrWhiteSpace(key))
                {
                    throw new ArgumentException("The key cannot be null or a white-space.");
                }

                this.colors.Add(key, value);
            }
        }
    }
}