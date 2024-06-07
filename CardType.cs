using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackOpening
{
    internal abstract class CardType
    {
        public virtual int BoostStats(Defender defender) { return 0; }
        public virtual int BoostStats(Midfielder midfielder) { return 0; }
        public virtual int BoostStats(Attacker attacker) { return 0; }
    }
}
