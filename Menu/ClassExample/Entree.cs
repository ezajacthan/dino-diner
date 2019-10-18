using System;
using System.Collections.Generic;
using System.Text;

namespace DDExample
{
    public abstract class Entree
    {
        public double Price { get; protected set; }
        public uint Calories { get; protected set; }
        public abstract List<string> Ingredients { get; }

    }
}
