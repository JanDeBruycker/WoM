using System;
using System.Collections.Generic;
using System.Text;

namespace ElementalWar.Classes
{
    public class MovementData
    {
        public string OpponentSort { get; private set; }
        public int OpponentId { get; private set; }
        
        public MovementData()
        {
            OpponentSort = "Unknown";
            OpponentId = -1;
        }

        public void ChangeRandomId(int id)
        {
            OpponentSort = "Random";
            OpponentId = id;
        }
        public void ChangeFixedId(int id)
        {
            OpponentSort = "Fixed";
            OpponentId = id;
        }

    }
}
