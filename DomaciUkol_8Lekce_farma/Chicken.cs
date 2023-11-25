using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_8Lekce_farma
{
    public class Chicken : Animal
    {

        public override string Sound()
        {
            return "kokodák";
        }

        public override string LookAtSky()
        {
            return "umím se podívat na oblohu";
        }

        public override string Food()
        {
            return "jsem všežravec."; ;
        }
    }
}
