using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackOpening
{
    internal class Inform : CardType
    {
        private static Inform ? instance = null;
        private Inform()
        {

        }
        public static Inform Instance()
        {
            if (instance == null) { instance = new Inform(); }
            return instance;
        }
        public override int BoostStats(Defender defender)
        {
            return 2;
        }
        public override int BoostStats(Midfielder midfielder)
        {
            return 3;
        }
        public override int BoostStats(Attacker attacker)
        {
            return 4;
        }
    }
}
