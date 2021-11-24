using System;
using System.Drawing;
using System.Windows.Forms;
using WorldOfMagic.Classes;

namespace WorldOfMagic
{
    public class Ability
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }

        public int Moves { get; set; }
        public int TotalMoves { get; private set; }

        public int Power { get; private set; }
        public int Accuracy { get; private set; }

        public int RequiredLevel { get; private set; }

        public void Set(int id, string name, string type, int mvs, int tmvs, int pwr, int acc, int reqLvl)
        {
            Id = id;
            Name = name;
            Type = type;
            Moves = mvs;
            TotalMoves = tmvs;
            Power = pwr;
            Accuracy = acc;
            RequiredLevel = reqLvl;
        }

        public CombatData Use(CombatData data)
        {
            data.AbilityName = Name;
            data.AbilityType = Type;

            if (Moves > 0)
            {
                Moves--;

                if (Attempt() < Accuracy + (data.PlayerSpeed / 10))
                {
                    data.AbilityDamage = Power * data.PlayerSpeed / 100 - data.OpponentDefense / 10;

                    if (data.AbilityType == "Arcane" && data.OpponentType == "Frost")
                    {
                        data.AbilityDamage /= 2;
                    }
                    else if (data.AbilityType == "Arcane" && data.OpponentType == "Fire")
                    {
                        data.AbilityDamage *= 3 / 2;
                    }
                    else if (data.AbilityType == "Frost" && data.OpponentType == "Fire")
                    {
                        data.AbilityDamage /= 2;
                    }
                    else if (data.AbilityType == "Frost" && data.OpponentType == "Arcane")
                    {
                        data.AbilityDamage *= 3 / 2;
                    }
                    else if (data.AbilityType == "Fire" && data.OpponentType == "Arcane")
                    {
                        data.AbilityDamage /= 2;
                    }
                    else if (data.AbilityType == "Fire" && data.OpponentType == "Frost")
                    {
                        data.AbilityDamage *= 3 / 2;
                    }

                    if (data.AbilityDamage <= 0)
                    {
                        data.AbilityDamage = 1;
                    }
                }
                else
                {
                    data.AbilityType = "Miss";
                }        
            }
            else
            {
                Messages.CombatOutOfMoves();
            }
            return data;
        }
        private int Attempt()
        {
            Random rnd = new Random();
            return rnd.Next(100);
        }

    }
}
