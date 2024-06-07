using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackOpening
{
    internal class Player
    {
        public string name;
        public Nation nationality;
        public Player(string name, Nation nationality)
        {
            this.name = name;
            this.nationality = nationality;
        }
    }
}
