using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackOpening
{
    internal class Defender : Card
    {
        public Defender(int cost, int defending, int passing, int shooting):base(cost, defending, passing, shooting) { }
        public override int Rating()
        {
            return defending;
        }
        public override bool IsDefender() {  return true; }
        public override void BonusStat()
        {
            defending += cardType.BoostStats(this);
            cost += cardType.BoostStats(this);
        }
    }
}
