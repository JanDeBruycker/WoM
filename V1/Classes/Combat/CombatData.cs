using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfMagic.Classes
{
    public class CombatData
    {
        public string PlayerType { get; set; }
        public int PlayerAttack { get; set; }
        public int PlayerSpeed { get; set; }

        public string OpponentType { get; set; }
        public int OpponentAttack { get; set; }
        public int OpponentDefense { get; set; }
        public int OpponentSpeed { get; set; }

        public string AbilityName { get; set; }
        public string AbilityType { get; set; }
        public int AbilityDamage { get; set; }
        public int AbilityHealing { get; set; }
        public int AbilityReduction { get; set; }

        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public int ItemDamage { get; set; }
        public int ItemHealing { get; set; }

    }
}
