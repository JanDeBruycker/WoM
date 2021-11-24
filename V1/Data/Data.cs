using System.Collections.Generic;
using System.Drawing;
using WorldOfMagic.Classes;
using WorldOfMagic.Classes.Data;

namespace WorldOfMagic
{
    public class Data
    {
        public static List<Ability> Abilities()
        {
            List<Ability> abilities = new List<Ability>();

            Ability ability0 = new Ability(); ability0.Set(0, "-", "-", 0, 0, 0, 0, 0);
            Ability ability1 = new Ability(); ability1.Set(1, "Cower", "NoType", 30, 30, 0, 100, 1);
            Ability ability2 = new Ability(); ability2.Set(2, "Wait", "NoType", 30, 30, 0, 100, 1);
            Ability ability3 = new Ability(); ability3.Set(3, "Punch", "Physical", 30, 30, 20, 100, 2);
            Ability ability4 = new Ability(); ability4.Set(4, "Kick", "Physical", 30, 30, 20, 100, 2);

            Ability ability5 = new Ability(); ability5.Set(5, "Tackle", "Physical", 30, 30, 25, 95, 5);
            Ability ability6 = new Ability(); ability6.Set(6, "Arcane Shock", "Arcane", 25, 25, 35, 90, 5);
            Ability ability7 = new Ability(); ability7.Set(7, "Frost Bolt", "Frost", 25, 25, 45, 85, 5);
            Ability ability8 = new Ability(); ability8.Set(8, "Fire Ball", "Fire", 25, 25, 55, 80, 5);

            Ability ability9 = new Ability(); ability9.Set(9, "Arcane Wave", "Arcane", 20, 20, 50, 85, 10);
            Ability ability10 = new Ability(); ability10.Set(10, "Frost Ray", "Frost", 20, 20, 60, 80, 10);
            Ability ability11 = new Ability(); ability11.Set(11, "Fire Blast", "Fire", 20, 20, 70, 75, 10);

            Ability ability12 = new Ability(); ability12.Set(12, "Arcane Spike", "Arcane", 15, 15, 65, 80, 15);
            Ability ability13 = new Ability(); ability13.Set(13, "Frost Spear", "Frost", 15, 15, 75, 75, 15);
            Ability ability14 = new Ability(); ability14.Set(14, "Fire Lance", "Fire", 15, 15, 85, 70, 15);

            Ability ability15 = new Ability(); ability15.Set(15, "Arcane Bomb", "Arcane", 10, 10, 100, 70, 20);
            Ability ability16 = new Ability(); ability16.Set(16, "Blizzard", "Frost", 10, 10, 125, 60, 20);
            Ability ability17 = new Ability(); ability17.Set(17, "Inferno", "Fire", 10, 10, 150, 50, 20);

            abilities.Add(ability0); abilities.Add(ability1); abilities.Add(ability2); abilities.Add(ability3);
            abilities.Add(ability4); abilities.Add(ability5); abilities.Add(ability6); abilities.Add(ability7);
            abilities.Add(ability8); abilities.Add(ability9); abilities.Add(ability10); abilities.Add(ability11);
            abilities.Add(ability12); abilities.Add(ability13); abilities.Add(ability14); abilities.Add(ability15);
            abilities.Add(ability16); abilities.Add(ability17);

            return abilities;
        }
        public static List<Building> Buildings()
        {
            List<Building> buildings = new List<Building>();

            Building building0 = new Building();
            building0.Set(0, "Hospital", "Hospital");

            Building building1 = new Building();
            building1.Set(1, "ItemShop", "ItemShop");

            Building building2 = new Building();
            building2.Set(2, "MagicShop", "MagicShop");

            Building building3 = new Building();
            building3.Set(3, "Dungeon", "Dungeon");

            buildings.Add(building0); buildings.Add(building1); buildings.Add(building2); buildings.Add(building3);

            return buildings;
        }
        public static List<Item> Items()
        {
            List<Item> items = new List<Item>();

                Item item0 = new Item();
                item0.Set(0, 0, "Empty", "-", 0, 0);
                items.Add(item0);

                Item item1 = new Item();
                item1.Set(1, 1, "Potion", "Potion", 20, 20);
                items.Add(item1);

                Item item2 = new Item();
                item2.Set(2, 2, "Rune", "Rune", 10, 50);
                items.Add(item2);

                Item item3 = new Item();
                item3.Set(3, 10, "Potion", "Potion", 20, 20, "A2", 13, 13, "Live");
                items.Add(item3);

            return items;
        }
        public static List<Opponent> FixedOpponents()
        {
            List<Opponent> allOpponents = new List<Opponent>();

            Opponent opp0 = new Opponent();
            opp0.Set(0, 7, "Scaredy-Cat", "NoType", 1, "A1", 1, 4, "Live");
            allOpponents.Add(opp0);

            Opponent opp1 = new Opponent();
            opp1.Set(1, 7, "Item Guru", "NoType", 3, "A3", 9, 3, "Live");
            allOpponents.Add(opp1);

            Opponent opp2 = new Opponent();
            opp2.Set(2, 6, "Magic Guru", "NoType", 3, "A3", 4, 8, "Live");
            allOpponents.Add(opp2);

            Opponent opp3 = new Opponent();
            opp3.Set(3, 7, "Sprinter", "Arcane", 4, "B3", 1, 1, "Live"); // Sprinter == spd (arcane) :: Blocker == def (frost) :: Fighter == atk (fire)
            allOpponents.Add(opp3);
    
            return allOpponents;
        }
        public static List<Opponent> RandomOpponents()
        {
            List<Opponent> allOpponents = new List<Opponent>();

            Opponent opp0 = new Opponent();
            opp0.Set(0, 14, "Rookie", "NoType", 2, "", 0, 0, ""); // Random Lvl 2
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
        public static List<Speech> Speech(string mapId)
        {
            List<Speech> speech = new List<Speech>();

            if (mapId == "A1")
            {
                Speech speech0 = new Speech();
                speech0.Set(0, "W-w-who are you?", "Heeelp!!");
                speech.Add(speech0);
            }

            if (mapId == "A2")
            {
                // No Speech
            }

            if (mapId == "A3")
            {
                Speech speech0 = new Speech();
                speech0.Set(0, "Items can be used in combat.", "Some are very powerful!");
                speech.Add(speech0);

                Speech speech1 = new Speech();
                speech1.Set(1, "Abilities have different Types.", "Each has its own strength and weakness.");
                speech.Add(speech1);
            }

            return speech;
        }

        public static List<Bitmap> AbilityImages()
        {
            List<Bitmap> abilities = new List<Bitmap>();

            Bitmap ability00 = Properties.Resources.AbilityEmpty;
            Bitmap ability01 = Properties.Resources.AbilityEmpty;
            Bitmap ability02 = Properties.Resources.AbilityEmpty;
            Bitmap ability03 = Properties.Resources.AbilityPunch;
            Bitmap ability04 = Properties.Resources.AbilityKick;
            Bitmap ability05 = Properties.Resources.AbilityTackle;
            Bitmap ability06 = Properties.Resources.AbilityArcaneShock;
            Bitmap ability07 = Properties.Resources.AbilityFrostBolt;
            Bitmap ability08 = Properties.Resources.AbilityFireBall;
            Bitmap ability09 = Properties.Resources.AbilityArcaneWave;
            Bitmap ability10 = Properties.Resources.AbilityFrostRay;
            Bitmap ability11 = Properties.Resources.AbilityFireBlast;
            Bitmap ability12 = Properties.Resources.AbilityArcaneSpike;
            Bitmap ability13 = Properties.Resources.AbilityFrostSpear;
            Bitmap ability14 = Properties.Resources.AbilityFireLance;

            abilities.Add(ability00); abilities.Add(ability01); abilities.Add(ability02); abilities.Add(ability03);
            abilities.Add(ability04); abilities.Add(ability05); abilities.Add(ability06); abilities.Add(ability07);
            abilities.Add(ability08); abilities.Add(ability09); abilities.Add(ability10); abilities.Add(ability11);
            abilities.Add(ability12); abilities.Add(ability13); abilities.Add(ability14);

            return abilities;
        }
        public static List<Bitmap> BuildingImages()
        {
            List<Bitmap> buildings = new List<Bitmap>();

            Bitmap img0 = Properties.Resources.BuildingHospital;
            Bitmap img1 = Properties.Resources.BuildingItemShop;
            Bitmap img2 = Properties.Resources.BuildingMagicShop;

            buildings.Add(img0); buildings.Add(img1); buildings.Add(img2);

            return buildings;
        }
        public static List<Bitmap> ItemImages()
        {
            List<Bitmap> items = new List<Bitmap>();

            Bitmap img0 = Properties.Resources.ItemEmpty;
            Bitmap img1 = Properties.Resources.ItemPotion;
            Bitmap img2 = Properties.Resources.ItemRune;
            Bitmap img3 = Properties.Resources.ItemEmptyUnselected;
            Bitmap img4 = Properties.Resources.ItemPotionUnselected;
            Bitmap img5 = Properties.Resources.ItemRuneUnselected;
            Bitmap img6 = Properties.Resources.ItemEmptySelected;
            Bitmap img7 = Properties.Resources.ItemPotionSelected;
            Bitmap img8 = Properties.Resources.ItemRuneSelected;

            // Map
            Bitmap img9 = Properties.Resources.ItemDirt;
            Bitmap img10 = Properties.Resources.ItemGrass;

            items.Add(img0); items.Add(img1); items.Add(img2); items.Add(img3); items.Add(img4); items.Add(img5);
            items.Add(img6); items.Add(img7); items.Add(img8); items.Add(img9); items.Add(img10);

            return items;
        }

        public static List<Bitmap> FieldImages()
        {
            List<Bitmap> items = new List<Bitmap>();

            Bitmap img0 = Properties.Resources.Dirt;
            Bitmap img1 = Properties.Resources.Grass;
            Bitmap img2 = Properties.Resources.Stone;
            Bitmap img3 = Properties.Resources.Portal;

            items.Add(img0); items.Add(img1); items.Add(img2); items.Add(img3);

            return items;
        }
        public static List<Bitmap> PlayerImages()
        {
            List<Bitmap> items = new List<Bitmap>();

            Bitmap img0 = Properties.Resources.PlayerWorldDirtUp;
            Bitmap img1 = Properties.Resources.PlayerWorldDirtDown;
            Bitmap img2 = Properties.Resources.PlayerWorldDirtLeft;
            Bitmap img3 = Properties.Resources.PlayerWorldDirtRight;
            Bitmap img4 = Properties.Resources.PlayerWorldGrassUp;
            Bitmap img5 = Properties.Resources.PlayerWorldGrassDown;
            Bitmap img6 = Properties.Resources.PlayerWorldGrassLeft;
            Bitmap img7 = Properties.Resources.PlayerWorldGrassRight;
            Bitmap img8 = Properties.Resources.PlayerWorldPortalUp;
            Bitmap img9 = Properties.Resources.PlayerWorldPortalDown;
            Bitmap img10 = Properties.Resources.PlayerWorldPortalLeft;
            Bitmap img11 = Properties.Resources.PlayerWorldPortalRight;
            Bitmap img12 = Properties.Resources.PlayerCombat;

            items.Add(img0); items.Add(img1); items.Add(img2); items.Add(img3); items.Add(img4); items.Add(img5); items.Add(img6);
            items.Add(img7); items.Add(img8); items.Add(img9); items.Add(img10); items.Add(img11); items.Add(img12);

            return items;
        }
        public static List<Bitmap> OpponentImages()
        {
            List<Bitmap> items = new List<Bitmap>();

            Bitmap img0 = Properties.Resources.CpuBossWorldDirt;
            Bitmap img1 = Properties.Resources.CpuBossWorldGrass;
            Bitmap img2 = Properties.Resources.CpuBossCombat;

            Bitmap img3 = Properties.Resources.CpuFixedWorldDirt;
            Bitmap img4 = Properties.Resources.CpuFixedWorldDirtUp;
            Bitmap img5 = Properties.Resources.CpuFixedWorldDirtDown;
            Bitmap img6 = Properties.Resources.CpuFixedWorldDirtLeft;
            Bitmap img7 = Properties.Resources.CpuFixedWorldDirtRight;
            Bitmap img8 = Properties.Resources.CpuFixedWorldGrass;
            Bitmap img9 = Properties.Resources.CpuFixedWorldGrassUp;
            Bitmap img10 = Properties.Resources.CpuFixedWorldGrassDown;
            Bitmap img11 = Properties.Resources.CpuFixedWorldGrassLeft;
            Bitmap img12 = Properties.Resources.CpuFixedWorldGrassRight;
            Bitmap img13 = Properties.Resources.CpuFixedCombat;

            Bitmap img14 = Properties.Resources.CpuRandomCombat;

            items.Add(img0); items.Add(img1); items.Add(img2); items.Add(img3); items.Add(img4); items.Add(img5); items.Add(img6);
            items.Add(img7); items.Add(img8); items.Add(img9); items.Add(img10); items.Add(img11); items.Add(img12); items.Add(img13);
            items.Add(img14);

            return items;
        }

    }
}
