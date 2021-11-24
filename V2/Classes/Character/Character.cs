using System;
using System.Windows.Controls;
using static ElementalWar.Classes.Data.Data;

namespace ElementalWar.Classes.Character
{
    public class Character
    {
        public int Id { get; private set; }
        public int ImageId { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int Level { get; private set; }

        public int HitPoints { get; set; }
        public int TotalHitPoints { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

        public Ability Ability1 { get; set; }
        public Ability Ability2 { get; set; }
        public Ability Ability3 { get; set; }
        public Ability Ability4 { get; set; }

        public Item Item1 { get; set; }
        public Item Item2 { get; set; }
        public Item Item3 { get; set; }

        public string MapId { get; private set; }
        public int Row { get; private set; }
        public int Column { get; private set; }

        public void Create(int id, string name, string type, int lvl, string mapId, int row, int column)
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
                    case "Physical":
                        specialAbility = Abilities()[5];
                        break;
                    case "Arcane":
                        specialAbility = Abilities()[6];
                        break;
                    case "Frost":
                        specialAbility = Abilities()[7];
                        break;
                    case "Fire":
                        specialAbility = Abilities()[8];
                        break;
                    default:
                        break;
                }
            }
            else if (Level >= 10 && Level < 15)
            {
                switch (Type)
                {
                    case "Physical":
                        specialAbility = Abilities()[5];
                        break;
                    case "Arcane":
                        specialAbility = Abilities()[9];
                        break;
                    case "Frost":
                        specialAbility = Abilities()[10];
                        break;
                    case "Fire":
                        specialAbility = Abilities()[11];
                        break;
                    default:
                        break;
                }
            }
            else if (Level >= 15 && Level < 20)
            {
                switch (Type)
                {
                    case "Physical":
                        specialAbility = Abilities()[5];
                        break;
                    case "Arcane":
                        specialAbility = Abilities()[12];
                        break;
                    case "Frost":
                        specialAbility = Abilities()[13];
                        break;
                    case "Fire":
                        specialAbility = Abilities()[14];
                        break;
                    default:
                        break;
                }
            }

            Ability1 = Abilities()[3];
            Ability2 = Abilities()[4];
            Ability3 = specialAbility;
            Ability4 = Abilities()[2];

            Item item1 = Items()[0]; Item item2 = Items()[0]; Item item3 = Items()[0];
            if (Level >= 10)
            {
                item1 = Items()[1];
            }
            if (Level >= 15)
            {
                item2 = Items()[2];
            }
            if (Level >= 20)
            {
                item3 = Items()[2];
            }

            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            
            MapId = mapId;
            Row = row;
            Column = column;
        }
        public void ChangeImageId(int id)
        {
            ImageId = id;
        }
        public void ChangeMapId(string id)
        {
            MapId = id;
        }
        public void ChangePosition(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public void MoveCharacter(string direction, Grid myGrid)
        {
            switch (direction)
            {
                case "Up":
                    ImageId = 0;
                    Row--;
                    break;
                case "Down":
                    ImageId = 1;
                    Row++;
                    break;
                case "Left":
                    ImageId = 2;
                    Column--;
                    break;
                case "Right":
                    ImageId = 3;
                    Column++;
                    break;
                default:
                    break;
            }

            if (CheckWalls(myGrid))
            {
                switch (direction)
                {
                    case "Up":
                        Row++;
                        break;
                    case "Down":
                        Row--;
                        break;
                    case "Left":
                        Column++;
                        break;
                    case "Right":
                        Column--;
                        break;
                    default:
                        break;
                }
            }

            if (CheckBuildings(myGrid))
            {
                switch (direction)
                {
                    case "Up":
                        Row++;
                        break;
                    case "Down":
                        Row--;
                        break;
                    case "Left":
                        Column++;
                        break;
                    case "Right":
                        Column--;
                        break;
                    default:
                        break;
                }
            }

            if (CheckItems(myGrid))
            {
                switch (direction)
                {
                    case "Up":
                        Row++;
                        break;
                    case "Down":
                        Row--;
                        break;
                    case "Left":
                        Column++;
                        break;
                    case "Right":
                        Column--;
                        break;
                    default:
                        break;
                }
            }

            if (CheckOpponents(myGrid))
            {
                switch (direction)
                {
                    case "Up":
                        Row++;
                        break;
                    case "Down":
                        Row--;
                        break;
                    case "Left":
                        Column++;
                        break;
                    case "Right":
                        Column--;
                        break;
                    default:
                        break;
                }
            }

            if (Row < 0)
            {
                Row = 0;
            }
            else if (Row > 14)
            {
                Row = 14;
            }
            if (Column < 0)
            {
                Column = 0;
            }
            else if (Column > 14)
            {
                Column = 14;
            }
        }
        private bool CheckWalls(Grid myGrid)
        {
            foreach (Image img in myGrid.Children)
            {
                if (img.Name == $"Wall_{Row}_{Column}")
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckBuildings(Grid myGrid)
        {
            int buildingSize = 3;
            foreach (Image img in myGrid.Children)
            {
                for (int row = 0; row < buildingSize; row++)
                {
                    for (int column = 0; column < buildingSize; column++)
                    {
                        if (img.Name == $"Recovery_{Row - row}_{Column - column}" || img.Name == $"Shopping_{Row - row}_{Column - column}"
                            || img.Name == $"Training_{Row - row}_{Column - column}")
                        {
                            return true;
                        }
                    }  
                }  
            }
            return false;
        }
        private bool CheckItems(Grid myGrid)
        {
            foreach (Image img in myGrid.Children)
            {
                if (img.Name == $"Item_{Row}_{Column}")
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckOpponents(Grid myGrid)
        {
            foreach (Image img in myGrid.Children)
            {
                if (img.Name == $"Opponent_{Row}_{Column}")
                {
                    return true;
                }
            }
            return false;
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
