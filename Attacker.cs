using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackOpening
{
    internal class Attacker:Card
    {
        public Attacker(int cost, int defending, int passing, int shooting) : base(cost, defending, passing, shooting) { }
        public override int Rating()
        {
            return shooting;
        }
        public override bool IsAttacker() { return true; }
        public override void BonusStat()
        {
            shooting += cardType.BoostStats(this);
            cost += cardType.BoostStats(this);
        }
    }
}
