using System.Collections.Generic;
using ElementalWar.Classes.Character;

namespace ElementalWar.Classes.Data
{
    class Data
    {
        public static List<Ability> Abilities()
        {
            List<Ability> abilities = new List<Ability>();

            Ability ability0 = new Ability(); 
            ability0.Set(0, "-", "-", 0, 0, 0, 0, 0);
            abilities.Add(ability0);

            Ability ability1 = new Ability(); 
            ability1.Set(1, "Cower", "NoType", 30, 30, 0, 100, 1);
            abilities.Add(ability1);

            Ability ability2 = new Ability(); 
            ability2.Set(2, "Wait", "NoType", 30, 30, 0, 100, 1);
            abilities.Add(ability2);

            Ability ability3 = new Ability(); 
            ability3.Set(3, "Punch", "Physical", 30, 30, 20, 100, 2);
            abilities.Add(ability3);

            Ability ability4 = new Ability(); 
            ability4.Set(4, "Kick", "Physical", 30, 30, 20, 100, 2);
            abilities.Add(ability4);

            Ability ability5 = new Ability(); 
            ability5.Set(5, "Tackle", "Physical", 25, 25, 35, 95, 5);
            abilities.Add(ability5);

            Ability ability6 = new Ability(); 
            ability6.Set(6, "Arcane Shock", "Arcane", 25, 25, 35, 90, 5);
            abilities.Add(ability6);

            Ability ability7 = new Ability(); 
            ability7.Set(7, "Frost Bolt", "Frost", 25, 25, 45, 85, 5);
            abilities.Add(ability7);

            Ability ability8 = new Ability(); 
            ability8.Set(8, "Fire Ball", "Fire", 25, 25, 55, 80, 5);
            abilities.Add(ability8);

            Ability ability9 = new Ability();
            ability9.Set(9, "Slam", "Physical", 20, 20, 50, 90, 10);
            abilities.Add(ability9);

            Ability ability10 = new Ability(); 
            ability10.Set(10, "Arcane Wave", "Arcane", 20, 20, 50, 85, 10);
            abilities.Add(ability10);

            Ability ability11 = new Ability(); 
            ability11.Set(11, "Frost Ray", "Frost", 20, 20, 60, 80, 10);
            abilities.Add(ability11);

            Ability ability12 = new Ability(); 
            ability12.Set(12, "Fire Blast", "Fire", 20, 20, 70, 75, 10);
            abilities.Add(ability12);

            Ability ability13 = new Ability();
            ability13.Set(13, "Takedown", "Physical", 15, 15, 65, 85, 15);
            abilities.Add(ability13);

            Ability ability14 = new Ability(); 
            ability14.Set(14, "Arcane Spike", "Arcane", 15, 15, 65, 80, 15);
            abilities.Add(ability14);

            Ability ability15 = new Ability(); 
            ability15.Set(15, "Frost Spear", "Frost", 15, 15, 75, 75, 15);
            abilities.Add(ability15);

            Ability ability16 = new Ability(); 
            ability16.Set(16, "Fire Lance", "Fire", 15, 15, 85, 70, 15);
            abilities.Add(ability16);

            Ability ability17 = new Ability(); 
            ability17.Set(17, "Arcane Bomb", "Arcane", 10, 10, 100, 70, 20);
            abilities.Add(ability17);

            Ability ability18 = new Ability(); 
            ability18.Set(18, "Blizzard", "Frost", 10, 10, 125, 60, 20);
            abilities.Add(ability18);

            Ability ability19 = new Ability(); 
            ability19.Set(19, "Inferno", "Fire", 10, 10, 150, 50, 20);
            abilities.Add(ability19);

            return abilities;
        }
        public static List<Building> Buildings()
        {
            List<Building> buildings = new List<Building>();

            Building building0 = new Building();
            building0.Set(0, "HP_Center", "Recovery");
            buildings.Add(building0);

            Building building1 = new Building();
            building1.Set(1, "Item_Center", "Shopping");
            buildings.Add(building1);

            Building building2 = new Building();
            building2.Set(2, "Ability_Center", "Training");
            buildings.Add(building2);

            Building building3 = new Building();
            building3.Set(3, "Dungeon", "Dungeon");
            buildings.Add(building3);

            return buildings;
        }
        public static List<Item> Items()
        {
            List<Item> items = new List<Item>();

            Item item0 = new Item();
            item0.Set(0, 0, "Empty", "-", 0, 0, "", 0, 0, "");
            items.Add(item0);

            Item item1 = new Item();
            item1.Set(1, 1, "Potion", "Potion", 20, 20, "", 0, 0, "");
            items.Add(item1);

            Item item2 = new Item();
            item2.Set(2, 2, "Rune", "Rune", 10, 50, "", 0, 0, "");
            items.Add(item2);

            // Map Items
            Item item3 = new Item();
            item3.Set(3, 1, "Potion", "Potion", 20, 20, "A1", 13, 1, "Live");
            items.Add(item3);

            return items;
        }
        public static List<Opponent> FixedOpponents()
        {
            List<Opponent> allOpponents = new List<Opponent>();

            Opponent opp0 = new Opponent();
            opp0.Set(0, 1, "Item Guru", "Physical", 3, "A1", 3, 3, "Live");
            allOpponents.Add(opp0);

            Opponent opp1 = new Opponent();
            opp1.Set(1, 1, "Health Guru", "Physical", 3, "A1", 3, 11, "Live");
            allOpponents.Add(opp1);

            Opponent opp2 = new Opponent();
            opp2.Set(2, 4, "Guard", "Frost", 10, "A1", 6, 14, "Live");
            allOpponents.Add(opp2);

            Opponent opp3 = new Opponent();
            opp3.Set(3, 6, "Ability Guru", "Physical", 3, "A2", 11, 5, "Live");
            allOpponents.Add(opp3);

            Opponent opp4 = new Opponent();
            opp4.Set(4, 7, "Sprinter", "Arcane", 4, "B3", 1, 1, "Live"); // Sprinter == spd (arcane) :: Blocker == def (frost) :: Fighter == atk (fire)
            allOpponents.Add(opp4);

            return allOpponents;
        }
        public static List<Opponent> RandomOpponents()
        {
            List<Opponent> allOpponents = new List<Opponent>();

            Opponent opp0 = new Opponent();
            opp0.Set(0, 14, "Rookie", "Physical", 2, "", 0, 0, ""); // Random Lvl 2
            allOpponents.Add(opp0);

            Opponent opp1 = new Opponent();
            opp1.Set(1, 14, "Rookie", "Arcane", 2, "", 0, 0, ""); // Random Lvl 2
            allOpponents.Add(opp1);

            Opponent opp2 = new Opponent();
            opp2.Set(2, 14, "Rookie", "Frost", 2, "", 0, 0, ""); // Random Lvl 2
            allOpponents.Add(opp2);

            Opponent opp3 = new Opponent();
            opp3.Set(3, 14, "Rookie", "Fire", 2, "", 0, 0, ""); // Random Lvl 2
            allOpponents.Add(opp3);

            return allOpponents;
        }

    }
}
