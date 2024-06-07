using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackOpening
{
    internal abstract class Card
    {
        public int cost;
        protected int defending;
        protected int passing;
        protected int shooting;
        public Player player;
        public CardType cardType;

        protected Card (int cost, int defending, int passing, int shooting)
        {
            this.cost = cost;   
            this.defending = defending;
            this.passing = passing;
            this.shooting = shooting;
            this.player = null;
            this.cardType = null;
        } 
        public void LinkToPlayer(Player player)
        {
            this.player=player;
        }
        public abstract int Rating();
        public virtual bool IsDefender() {  return false; }
        public virtual bool IsMidfielder() { return false; }
        public virtual bool IsAttacker() { return false; }
        public void SetRarity(CardType cardType) { this.cardType = cardType;}
        public abstract void BonusStat();

    }
}
