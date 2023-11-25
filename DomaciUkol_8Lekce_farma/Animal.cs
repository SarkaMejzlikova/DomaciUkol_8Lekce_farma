using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_8Lekce_farma
{
    public abstract class Animal : IFood, ISky, ISound
    {
        // properties
        public string Type;
        public string Gender;
        public int Age;
        public double Weight;

        // methods
        public abstract string Sound();

        public abstract string LookAtSky();

        public abstract string Food();

    }
}
