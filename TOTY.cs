using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackOpening
{
    internal class TOTY : CardType
    {
        private static TOTY? instance = null;
        private TOTY()
        {

        }
        public static TOTY Instance()
        {
            if (instance == null) { instance = new TOTY(); }
            return instance;
        }
        public override int BoostStats(Defender defender)
        {
            return 4;
        }
        public override int BoostStats(Midfielder midfielder)
        {
            return 6;
        }
        public override int BoostStats(Attacker attacker)
        {
            return 7;
        }
    }
}
