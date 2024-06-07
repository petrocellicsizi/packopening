using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackOpening
{
    internal class MyClub
    {
        private List<Card> cards;
        public MyClub() {  cards = new List<Card>(); }
        public void JoinMyClub(Card card)
        {
            cards.Add(card);
        }
        public int AverageRating()
        {
            if (cards.Count == 0) return 0;
            int s = 0;
            foreach (Card card in cards) { s += card.Rating(); }
            return (s/ cards.Count);
        }
        public int EnglishPlayersCount()
        {
            int s = 0;
            foreach (Card card in cards)
            {
                if (card.player.nationality == Nation.ENGLAND) { s++; }
            }
            return s;
        }
        public List<string> AllEnglishDefenders()
        {
            List<string> jo=new List<string>();
            foreach (Card card in cards)
            {
                if(card.player.nationality == Nation.ENGLAND && card.IsDefender() == true)
                {
                    jo.Add(card.player.name);
                }
            }
            return jo;
        }
        public bool BestSpanishPlayer(out string bestplayername)
        {
            bool l = false;
            int max = 0;
            string bestname = "";
            foreach (Card card in cards)
            {
                if (card.player.nationality == Nation.SPAIN)
                {
                    l = true;
                    if (max < card.Rating()) 
                    { 
                        max = card.Rating(); 
                        bestname = card.player.name;
                    }
                }

            }
            bestplayername = bestname;
            return l;
        }
        public bool MostExpensiveDefenderPrice(out int max)
        {
            int m = 0;
            bool l = false;
            foreach (Card card in cards)
            {
                if (m < card.cost && card.IsDefender())
                {
                    m= card.cost;
                    l=true;
                }
            }
            max = m; return l;

        }
        public bool BestRarePlayerName(out string bestplayername)
        {
            bool l = false;
            int max = 0;
            string bestname = "";
            foreach (Card card in cards)
            {
                if (card.cardType == Rare.Instance())
                {
                    l = true;
                    if (max < card.Rating())
                    {
                        max = card.Rating();
                        bestname = card.player.name;
                    }
                }

            }
            bestplayername = bestname;
            return l;

        }
        public bool MostExpensiveSpecialCardCost(out int max)
        {
            int m = 0;
            bool l = false;
            foreach (Card card in cards)
            {
                if (m < card.cost && card.cardType != Rare.Instance())
                {
                    m = card.cost;
                    l = true;
                }
            }
            max = m; return l;

        }
    }
}
