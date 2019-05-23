using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Player
    {
        private int Player_Type;// 0 repesent humen player , 1,2,3,4,5... repensent robot and their skill level
        public Player(int PlayerType)
        {
            Player_Type = PlayerType;
        }
    }
}
