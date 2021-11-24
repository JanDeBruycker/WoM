using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfMagic.Classes;

namespace WorldOfMagic
{
    public class Character
    {
        public int Id { get; private set; }
        public int ImageId { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int Level { get; set; }

        public int HitPoints { get; set; }
        public int TotalHitPoints { get; set; }
        public int Attack { get;  set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

        public Ability Ability1 { get; set; }
        public Ability Ability2 { get; set; }
        public Ability Ability3 { get; set; }
        public Ability Ability4 { get; set; }

        public Item Item1 { get; set; }
        public Item Item2 { get; set; }
        public Item Item3 { get; set; }

        public string MapId { get; set; }
        public int LocX { get; set; }
        public int LocY { get; set; }

        public void Create(int id, string name, string type, int lvl, string mapId, int locX, int locY)
        {
            Id = id;
            Name = name;
            Type = type;
            Level = lvl;

            HitPoints = 10;
            TotalHitPoints = 10;
            Attack = 12;
            Defense = 12;
            Speed = 12;

            for (int i = 1; i < Level; i++)
            {
                int hp = 3; int atk = 2; int def = 2; int spd = 2;
                switch (Type)
                {
                    case "NoType":
                        atk += 1;
                        def += 1;
                        spd += 1;
                        break;
                    case "Arcane":
                        spd += 3;
                        break;
                    case "Frost":
                        def += 3;
                        break;
                    case "Fire":
                        atk += 3;
                        break;
                    default:
                        break;
                }

                HitPoints += hp;
                TotalHitPoints += hp;
                Attack += atk;
                Defense += def;
                Speed += spd;
            }

            Ability specialAbility = new Ability();
            if (Level >= 5 && Level < 10)
            {
                switch (Type)
                {
                    case "NoType":
                        specialAbility = Data.Abilities()[5];
                        break;
                    case "Arcane":
                        specialAbility = Data.Abilities()[6];
                        break;
                    case "Frost":
                        specialAbility = Data.Abilities()[7];
                        break;
                    case "Fire":
                        specialAbility = Data.Abilities()[8];
                        break;
                    default:
                        break;
                }
            }
            else if (Level >= 10 && Level < 15)
            {
                switch (Type)
                {
                    case "NoType":
                        specialAbility = Data.Abilities()[5];
                        break;
                    case "Arcane":
                        specialAbility = Data.Abilities()[9];
                        break;
                    case "Frost":
                        specialAbility = Data.Abilities()[10];
                        break;
                    case "Fire":
                        specialAbility = Data.Abilities()[11];
                        break;
                    default:
                        break;
                }
            }
            else if (Level >= 15 && Level < 20)
            {
                switch (Type)
                {
                    case "NoType":
                        specialAbility = Data.Abilities()[5];
                        break;
                    case "Arcane":
                        specialAbility = Data.Abilities()[12];
                        break;
                    case "Frost":
                        specialAbility = Data.Abilities()[13];
                        break;
                    case "Fire":
                        specialAbility = Data.Abilities()[14];
                        break;
                    default:
                        break;
                }
            }

            Ability1 = Data.Abilities()[3];
            Ability2 = Data.Abilities()[4];
            Ability3 = specialAbility;
            Ability4 = Data.Abilities()[2];

            Item item1 = Data.Items()[0]; Item item2 = Data.Items()[0]; Item item3 = Data.Items()[0];
            if (Level >= 10)
            {
                item1 = Data.Items()[1];
            }
            if (Level >= 15)
            {
                item2 = Data.Items()[2];
            }
            if (Level >= 20)
            {
                item3 = Data.Items()[2];
            }

            Item1 = item1;
            Item2 = item2;
            Item3 = item3;

            MapId = mapId;  
            LocX = locX;
            LocY = locY;
        }
        public void ChangeImageId(int id)
        {
            ImageId = id;
        }
        public void ChangeMapId(string id)
        {
            MapId = id;
        }
        public void ChangeLocation(int locX, int locY)
        {
            LocX = locX;
            LocY = locY;
        }

        public CombatData UseAbility(int number, CombatData data)
        {
            data.PlayerType = Type;
            data.PlayerAttack = Attack;
            data.PlayerSpeed = Speed;

            switch (number)
            {
                case 1:
                    return Ability1.Use(data);
                case 2:
                    return Ability2.Use(data);
                case 3:
                    return Ability3.Use(data);
                case 4:
                    return Ability4.Use(data);
                default:
                    return new CombatData();
            }
        }
        public CombatData UseItem(int number, CombatData data)
        {
            switch (number)
            {
                case 1:
                    return Item1.Use(data);
                case 2:
                    return Item2.Use(data);
                case 3:
                    return Item3.Use(data);
                default:
                    return new CombatData();
            }
        }

        public void LevelUp()
        {
            Level++;

            int hp = 3; int atk = 2; int def = 2; int spd = 2;
            switch (Type)
            {
                case "NoType":
                    atk += 1;
                    def += 1;
                    spd += 1;
                    break;
                case "Arcane":
                    spd += 3;
                    break;
                case "Frost":
                    def += 3;
                    break;
                case "Fire":
                    atk += 3;
                    break;
                default:
                    break;
            }

            HitPoints += hp;
            TotalHitPoints += hp;
            Attack += atk;
            Defense += def;
            Speed += spd;
        }

    }
}
