using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackOpening
{
    internal class Midfielder:Card
    {
        public Midfielder(int cost, int defending, int passing, int shooting) : base(cost, defending, passing, shooting) { }
        public override int Rating()
        {
            return passing;
        }
        public override bool IsMidfielder() { return true; }
        public override void BonusStat()
        {
            passing += cardType.BoostStats(this);
            cost += cardType.BoostStats(this);
        }
    }
}
