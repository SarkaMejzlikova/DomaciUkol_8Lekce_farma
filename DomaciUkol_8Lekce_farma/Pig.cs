using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_8Lekce_farma
{
    public class Pig : Animal
    {
        public override string Food()
        {
            return "jsem všežravec."; ;
        }

        public override string LookAtSky()
        {
            return "neumím se podívat na oblohu"; ;
        }

        public override string Sound()
        {
            return "chro chro";
        }

    }
}
