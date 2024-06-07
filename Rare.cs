using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackOpening
{
    internal class Rare:CardType
    {
        private static Rare? instance = null;
        private Rare()
        {

        }
        public static Rare Instance()
        {
            if (instance == null) { instance = new Rare(); }
            return instance;
        }
        public override int BoostStats(Defender defender)
        {
            return 1;
        }
        public override int BoostStats(Midfielder midfielder)
        {
            return 2;
        }
        public override int BoostStats(Attacker attacker)
        {
            return 1;
        }
    }
}
