using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WorldOfMagic.Classes;
using WorldOfMagic.Interfaces.World;

namespace WorldOfMagic
{
    public class Player : Character
    {
        public int Experience { get; private set; }
        public int Money { get; private set; }

        // Set Player from Save;
        public void Set(int imgId, string type, int lvl, int hp, Ability[] abilities, Item[] items, string mapId, int locX, int locY, 
            int exp, int money)
        {
            Create(1, "Player", type, lvl, "A1", 1, 1);
            ChangeImageId(imgId);

            HitPoints = hp;

            Ability1 = abilities[0];
            Ability2 = abilities[1];
            Ability3 = abilities[2];
            Ability4 = abilities[3];

            Item1 = items[0];
            Item2 = items[1];
            Item3 = items[2];

            MapId = mapId;
            LocX = locX;
            LocY = locY;

            Experience = exp;
            Money = money;
        }

        // Selection Controls
        public static void NewGame(string playerType)
        {
            DataControl.CreateDirectory();
            DataControl.CreatePlayer(playerType);
            DataControl.CreateOpponents();
            DataControl.CreateItems();
        }
        public void Play()
        {
            InterfaceWorld world = new InterfaceWorld();
            world.Player = this;
            world.ShowDialog();
          
            if (world.ReasonOfClose != "Quit")
            {
                if (world.ReasonOfClose == "Portal")
                {
                    Play();
                }

                if (world.ReasonOfClose == "Dead")
                {
                    HitPoints = TotalHitPoints;

                    ChangeImageId(1);

                    ChangeMapId("A1");
                    ChangeLocation(7, 9);

                    Play();
                }

                if (world.ReasonOfClose == "Load")
                {
                    Player loadFile = DataControl.LoadPlayer();

                    ChangeImageId(loadFile.ImageId);
                    Level = loadFile.Level;

                    HitPoints = loadFile.HitPoints;
                    TotalHitPoints = loadFile.TotalHitPoints;
                    Attack = loadFile.Attack;
                    Defense = loadFile.Defense;
                    Speed = loadFile.Speed;

                    Ability1 = loadFile.Ability1;
                    Ability2 = loadFile.Ability2;
                    Ability3 = loadFile.Ability3;
                    Ability4 = loadFile.Ability4;

                    Item1 = loadFile.Item1;
                    Item2 = loadFile.Item2;
                    Item3 = loadFile.Item3;

                    MapId = loadFile.MapId;
                    LocX = loadFile.LocX;
                    LocY = loadFile.LocY;

                    Experience = loadFile.Experience;
                    Money = loadFile.Money;

                    Play();
                }
            }
        }

        // World Controls
        public int Move(string direction, List<PictureBox> portals, List<PictureBox> walls, List<PictureBox> buildings, List<PictureBox> items, List<PictureBox> opponents, List<PictureBox> grass, List<Opponent> opponentList)
        {
            switch (direction)
            {
                case "UP":
                    if (ImageId == 0 || ImageId == 1 || ImageId == 2 || ImageId == 3)
                    {
                        ChangeImageId(0);
                    }
                    else
                    {
                        ChangeImageId(4);
                    }
                    break;
                case "DOWN":
                    if (ImageId == 0 || ImageId == 1 || ImageId == 2 || ImageId == 3)
                    {
                        ChangeImageId(1);
                    }
                    else
                    {
                        ChangeImageId(5);
                    }
                    break;
                case "LEFT":
                    if (ImageId == 0 || ImageId == 1 || ImageId == 2 || ImageId == 3)
                    {
                        ChangeImageId(2);
                    }
                    else
                    {
                        ChangeImageId(6);
                    }
                    break;
                case "RIGHT":
                    if (ImageId == 0 || ImageId == 1 || ImageId == 2 || ImageId == 3)
                    {
                        ChangeImageId(3);
                    }
                    else
                    {
                        ChangeImageId(7);
                    }
                    break;
                default:
                    break;
            } // Change Player Direction (Dirt)

            if (CheckPortals(portals))
            {
                return -3;
            }

            if (CheckWalls(walls))
            {
                return -2; // CANNOT MOVE
            }

            if (CheckBuildings(buildings))
            {
                return -2; // CANNOT MOVE
            }

            if (CheckItems(items))
            {
                return -2; // CANNOT MOVE
            }

            if (CheckOpponents(opponents))
            {
                return -2; // CANNOT MOVE
            }

            if (CheckGrass(grass))
            {
                switch (direction)
                {
                    case "UP":
                        ChangeImageId(4);
                        break;
                    case "DOWN":
                        ChangeImageId(5);
                        break;
                    case "LEFT":
                        ChangeImageId(6);
                        break;
                    case "RIGHT":
                        ChangeImageId(7);
                        break;
                    default:
                        break;
                }

                if (GetChanceRandomFight() < 10)
                {
                    return -1;
                }
            }
            else
            {
                switch (direction)
                {
                    case "UP":
                        ChangeImageId(0);
                        break;
                    case "DOWN":
                        ChangeImageId(1);
                        break;
                    case "LEFT":
                        ChangeImageId(2);
                        break;
                    case "RIGHT":
                        ChangeImageId(3);
                        break;
                    default:
                        break;
                }
            }// Change Player Background; Check for Random Fight

            switch (direction)
            {
                case "UP":
                    LocY -= 1;
                    break;
                case "DOWN":
                    LocY += 1;
                    break;
                case "LEFT":
                    LocX -= 1;
                    break;
                case "RIGHT":
                    LocX += 1;
                    break;
                default:
                    break;
            } // Move

            int oppId = CheckOpponentsRange(opponentList);
            if (oppId != -2)
            {
                return oppId;
            }

            return -2;
        }
        public int Interact(List<PictureBox> buildings, List<PictureBox> items, List<PictureBox> opponents, List<Building> buildingList, List<Item> itemList)
        {
            string buildingName = CheckBuilding(buildings, buildingList);
            switch (buildingName)
            {
                case "Hospital":
                    EnterHospital();
                    return -1;
                case "ItemShop":
                    EnterItemShop();
                    return -1;
                case "MagicShop":
                    EnterMagicShop();
                    return -1;
                default:
                    break;
            }

            int itemId = CheckItem(items);
            if (itemId != -1)
            {
                PickUpItem(itemList[itemId]);
                return itemId + 1000;
            }

            int oppId = CheckOpponent(opponents);
            if (oppId != -1)
            {
                return oppId;
            }

            return -1;
        }

        // Interact Controls
        private void EnterHospital()
        {
            Hospital hospital = new Hospital();
            hospital.Player = this;
            hospital.ShowDialog();
        }
        private void EnterMagicShop()
        {
            MagicShop shop = new MagicShop();
            shop.Player = this;
            shop.ShowDialog();
        }
        private void EnterItemShop()
        {
            ItemShop shop = new ItemShop();
            shop.Player = this;
            shop.ShowDialog();
        }
        public void PickUpItem(Item item)
        {
            Item assignItem = new Item();

            switch (item.Name)
            {
                case "Potion":
                    assignItem = Data.Items()[1];
                    break;
                case "Rune":
                    assignItem = Data.Items()[2];
                    break;
                default:
                    break;
            }

            if (Item1.Id == 0)
            {
                Item1 = assignItem;

                item.ChangeStatus();
                Messages.ItemPickUpSucces(item.Name);
            }
            else if (Item2.Id == 0)
            {
                Item2 = assignItem;

                item.ChangeStatus();
                Messages.ItemPickUpSucces(item.Name);
            }
            else if (Item3.Id == 0)
            {
                Item3 = assignItem;

                item.ChangeStatus();
                Messages.ItemPickUpSucces(item.Name);
            }
            else
            {
                Messages.ItemPickUpFailure();
            }
        }

        // Combat Controls
        public string Fight(int oppId, string oppType)
        {
            InterfaceCombat combat = new InterfaceCombat();
            combat.Player = this;
            combat.CpuId = oppId;
            combat.CpuType = oppType;
            combat.ShowDialog();

            return combat.State;
        }
        public bool Escape()
        {
            if (AttemptEscape())
            {
                Messages.CombatEscapeSucces();
                return true;
            }
            else
            {
                Messages.CombatEscapeFailure();
                return false;
            }
        }

        // CombatResults
        public void GainMoney(int cpuLevel)
        {
            Money += cpuLevel;

            Messages.MoneyUp(cpuLevel);
        }
        public void GainExp(int cpuLevel)
        {
            Experience += cpuLevel * 4;

            Messages.ExpUp(cpuLevel * 4);

            if (Experience >= Level * 20)
            {
                LevelUp();
            }
        }

        // Building Controls
        public void BuyAbility(int id)
        {
            Ability ability = Data.Abilities()[id];

            if (Level >= ability.RequiredLevel)
            {
                MagicShopAbilitySelector selector = new MagicShopAbilitySelector();
                selector.Player = this;
                selector.ShowDialog();

                int abilityToReplace = selector.AbilityId;

                switch (abilityToReplace)
                {
                    case 1:
                        Ability1 = ability;
                        break;
                    case 2:
                        Ability2 = ability;
                        break;
                    case 3:
                        Ability3 = ability;
                        break;
                    case 4:
                        Ability4 = ability;
                        break;
                    default:
                        break;
                }
                Messages.MagicShopSucces(ability.Name);
            }
            else
            {
                Messages.MagicShopFailure();
            }
        }
        public void BuyItem(int id)
        {
            Item item = Data.Items()[id];

            if (Money >= item.Price)
            {
                if (Item1.Id == 0)
                {
                    Money -= item.Price;
                    Item1 = item;
                    Messages.ItemShopSucces(item.Name);
                }
                else if (Item2.Id == 0)
                {
                    Money -= item.Price;
                    Item2 = item;
                    Messages.ItemShopSucces(item.Name);
                }
                else if (Item3.Id == 0)
                {
                    Money -= item.Price;
                    Item3 = item;
                    Messages.ItemShopSucces(item.Name);
                }
                else
                {
                    Messages.ItemShopFailureSlots();
                }
            }
            else
            {
                Messages.ItemShopFailureMoney();
            }
        }

        // Menu Controls
        public string ShowMenu()
        {
            Menu menu = new Menu();
            menu.Player = this;
            menu.ShowDialog();

            return menu.Command;
        }
        public void ShowStats()
        {
            Stats stats = new Stats();
            stats.Player = this;
            stats.ShowDialog();
        }
        public void ShowItems()
        {
            Items items = new Items();
            items.Player = this;
            items.ShowDialog();
        }

        // Movement Checks
        private bool CheckWalls(List<PictureBox> walls)
        {
            foreach (PictureBox wall in walls)
            {
                PictureBox pf = new PictureBox();
                pf.Size = new Size(25, 25);
                pf.Location = new Point(LocX * 25, LocY * 25);

                Rectangle fieldToCheck = new Rectangle();
                fieldToCheck.Size = wall.Size;
                fieldToCheck.Location = wall.Location;

                if (ImageId == 0 || ImageId == 4) // Looking UP
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y - 25);
                }
                else if (ImageId == 1 || ImageId == 5) // Looking DOWN
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y + 25);
                }
                else if (ImageId == 2 || ImageId == 6) // Looking LEFT
                {
                    pf.Location = new Point(pf.Location.X - 25, pf.Location.Y);
                }
                else if (ImageId == 3 || ImageId == 7) // Looking RIGHT
                {
                    pf.Location = new Point(pf.Location.X + 25, pf.Location.Y);
                }

                if (pf.Bounds.IntersectsWith(fieldToCheck))
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckPortals(List<PictureBox> portals)
        {
            foreach (PictureBox portal in portals)
            {
                PictureBox pf = new PictureBox();
                pf.Size = new Size(25, 25);
                pf.Location = new Point(LocX * 25, LocY * 25);

                Rectangle fieldToCheck = new Rectangle();
                fieldToCheck.Size = portal.Size;
                fieldToCheck.Location = portal.Location;

                if (ImageId == 0 || ImageId == 4)
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y - 25);
                }
                else if (ImageId == 1 || ImageId == 5)
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y + 25);
                }
                else if (ImageId == 2 || ImageId == 6)
                {
                    pf.Location = new Point(pf.Location.X - 25, pf.Location.Y);
                }
                else if (ImageId == 3 || ImageId == 7)
                {
                    pf.Location = new Point(pf.Location.X + 25, pf.Location.Y);
                }

                if (pf.Bounds.IntersectsWith(fieldToCheck))
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckBuildings(List<PictureBox> buildings)
        {
            foreach (PictureBox building in buildings)
            {
                PictureBox pf = new PictureBox();
                pf.Size = new Size(25, 25);
                pf.Location = new Point(LocX * 25, LocY * 25);

                Rectangle fieldToCheck = new Rectangle();
                fieldToCheck.Size = building.Size;
                fieldToCheck.Location = building.Location;

                if (ImageId == 0 || ImageId == 4)
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y - 25);
                }
                else if (ImageId == 1 || ImageId == 5)
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y + 25);
                }
                else if (ImageId == 2 || ImageId == 6)
                {
                    pf.Location = new Point(pf.Location.X - 25, pf.Location.Y);
                }
                else if (ImageId == 3 || ImageId == 7)
                {
                    pf.Location = new Point(pf.Location.X + 25, pf.Location.Y);
                }

                if (pf.Bounds.IntersectsWith(fieldToCheck))
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckItems(List<PictureBox> items)
        {
            foreach (PictureBox item in items)
            {
                PictureBox pf = new PictureBox();
                pf.Size = new Size(25, 25);
                pf.Location = new Point(LocX * 25, LocY * 25);

                Rectangle fieldToCheck = new Rectangle();
                fieldToCheck.Size = item.Size;
                fieldToCheck.Location = item.Location;

                if (ImageId == 0 || ImageId == 4)
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y - 25);
                }
                else if (ImageId == 1 || ImageId == 5)
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y + 25);
                }
                else if (ImageId == 2 || ImageId == 6)
                {
                    pf.Location = new Point(pf.Location.X - 25, pf.Location.Y);
                }
                else if (ImageId == 3 || ImageId == 7)
                {
                    pf.Location = new Point(pf.Location.X + 25, pf.Location.Y);
                }

                if (pf.Bounds.IntersectsWith(fieldToCheck))
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckOpponents(List<PictureBox> opponents)
        {
            foreach (PictureBox opponent in opponents)
            {
                PictureBox pf = new PictureBox();
                pf.Size = new Size(25, 25);
                pf.Location = new Point(LocX * 25, LocY * 25);

                Rectangle fieldToCheck = new Rectangle();
                fieldToCheck.Size = opponent.Size;
                fieldToCheck.Location = opponent.Location;

                if (ImageId == 0 || ImageId == 4)
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y - 25);
                }
                else if (ImageId == 1 || ImageId == 5)
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y + 25);
                }
                else if (ImageId == 2 || ImageId == 6)
                {
                    pf.Location = new Point(pf.Location.X - 25, pf.Location.Y);
                }
                else if (ImageId == 3 || ImageId == 7)
                {
                    pf.Location = new Point(pf.Location.X + 25, pf.Location.Y);
                }

                if (pf.Bounds.IntersectsWith(fieldToCheck))
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckGrass(List<PictureBox> grass)
        {
            foreach (PictureBox field in grass) // Grass Fields
            {
                PictureBox pf = new PictureBox();
                pf.Size = new Size(25, 25);
                pf.Location = new Point(LocX * 25, LocY * 25);

                Rectangle fieldToCheck = new Rectangle();
                fieldToCheck.Size = field.Size;
                fieldToCheck.Location = field.Location;

                if (ImageId == 0 || ImageId == 4)
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y - 25);
                }
                else if (ImageId == 1 || ImageId == 5)
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y + 25);
                }
                else if (ImageId == 2 || ImageId == 6)
                {
                    pf.Location = new Point(pf.Location.X - 25, pf.Location.Y);
                }
                else if (ImageId == 3 || ImageId == 7)
                {
                    pf.Location = new Point(pf.Location.X + 25, pf.Location.Y);
                }

                if (pf.Bounds.IntersectsWith(fieldToCheck))
                {
                    return true;
                }
            }
            return false;
        }
        private int CheckOpponentsRange(List<Opponent> opponentList)
        {
            foreach (Opponent opponent in opponentList)
            {
                PictureBox pf = new PictureBox();
                pf.Size = new Size(25, 25);
                pf.Location = new Point(LocX * 25, LocY * 25);

                Rectangle fieldToCheck1 = new Rectangle();
                Rectangle fieldToCheck2 = new Rectangle();
                fieldToCheck1.Size = new Size(25, 25);
                fieldToCheck2.Size = new Size(25, 25);

                if (opponent.ImageId == 4 || opponent.ImageId == 9)
                {
                    fieldToCheck1.Location = new Point(opponent.LocX * 25, opponent.LocY * 25 - 25);
                    fieldToCheck2.Location = new Point(opponent.LocX * 25, opponent.LocY * 25 - 50);
                }
                else if (opponent.ImageId == 5 || opponent.ImageId == 10)
                {
                    fieldToCheck1.Location = new Point(opponent.LocX * 25, opponent.LocY * 25 + 25);
                    fieldToCheck2.Location = new Point(opponent.LocX * 25, opponent.LocY * 25 + 50);
                }
                else if (opponent.ImageId == 6 || opponent.ImageId == 11)
                {
                    fieldToCheck1.Location = new Point(opponent.LocX * 25 - 25, opponent.LocY * 25);
                    fieldToCheck2.Location = new Point(opponent.LocX * 25 - 50, opponent.LocY * 25);
                }
                else if (opponent.ImageId == 7 || opponent.ImageId == 12)
                {
                    fieldToCheck1.Location = new Point(opponent.LocX * 25 + 25, opponent.LocY * 25);
                    fieldToCheck2.Location = new Point(opponent.LocX * 25 + 50, opponent.LocY * 25);
                }
                else
                {
                    fieldToCheck1.Location = new Point(-25, -25);
                    fieldToCheck2.Location = new Point(-25, -25);
                }

                if (opponent.Status == "Live")
                {
                    if (pf.Bounds.IntersectsWith(fieldToCheck1) || pf.Bounds.IntersectsWith(fieldToCheck2))
                    {
                        return opponent.Id;
                    }
                }
            }
            return -2;
        }

        // Interaction Checks
        private string CheckBuilding(List<PictureBox> buildings, List<Building> buildingList)
        {
            foreach (PictureBox building in buildings)
            {
                PictureBox pf = new PictureBox();
                pf.Size = new Size(25, 25);
                pf.Location = new Point(LocX * 25, LocY * 25);

                Rectangle fieldToCheck = new Rectangle();
                fieldToCheck.Size = building.Size;
                fieldToCheck.Location = building.Location;

                if (ImageId == 0 || ImageId == 4)
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y - 25);
                }
                else if (ImageId == 1 || ImageId == 5)
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y + 25);
                }
                else if (ImageId == 2 || ImageId == 6)
                {
                    pf.Location = new Point(pf.Location.X - 25, pf.Location.Y);
                }
                else if (ImageId == 3 || ImageId == 7)
                {
                    pf.Location = new Point(pf.Location.X + 25, pf.Location.Y);
                }

                if (pf.Bounds.IntersectsWith(fieldToCheck))
                {
                    return buildingList[buildings.IndexOf(building)].Name;
                }
            }
            return "";
        }
        private int CheckItem(List<PictureBox> items)
        {
            foreach (PictureBox item in items)
            {
                PictureBox pf = new PictureBox();
                pf.Size = new Size(25, 25);
                pf.Location = new Point(LocX * 25, LocY * 25);

                Rectangle fieldToCheck = new Rectangle();
                fieldToCheck.Size = item.Size;
                fieldToCheck.Location = item.Location;

                if (ImageId == 0 || ImageId == 4)
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y - 25);
                }
                else if (ImageId == 1 || ImageId == 5)
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y + 25);
                }
                else if (ImageId == 2 || ImageId == 6)
                {
                    pf.Location = new Point(pf.Location.X - 25, pf.Location.Y);
                }
                else if (ImageId == 3 || ImageId == 7)
                {
                    pf.Location = new Point(pf.Location.X + 25, pf.Location.Y);
                }

                if (pf.Bounds.IntersectsWith(fieldToCheck))
                {
                    return items.IndexOf(item);
                }
            }
            return -1;
        }
        private int CheckOpponent(List<PictureBox> opponents)
        {
            foreach (PictureBox opponent in opponents)
            {
                PictureBox pf = new PictureBox();
                pf.Size = new Size(25, 25);
                pf.Location = new Point(LocX * 25, LocY * 25);

                Rectangle fieldToCheck = new Rectangle();
                fieldToCheck.Size = opponent.Size;
                fieldToCheck.Location = opponent.Location;

                if (ImageId == 0 || ImageId == 4)
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y - 25);
                }
                else if (ImageId == 1 || ImageId == 5)
                {
                    pf.Location = new Point(pf.Location.X, pf.Location.Y + 25);
                }
                else if (ImageId == 2 || ImageId == 6)
                {
                    pf.Location = new Point(pf.Location.X - 25, pf.Location.Y);
                }
                else if (ImageId == 3 || ImageId == 7)
                {
                    pf.Location = new Point(pf.Location.X + 25, pf.Location.Y);
                }

                if (pf.Bounds.IntersectsWith(fieldToCheck))
                {
                    return opponents.IndexOf(opponent);
                }
            }
            return -1;
        }

        // Calculations
        private int GetChanceRandomFight()
        {
            Random rnd = new Random();
            return rnd.Next(100);
        }
        private string GetRandomStatFocus()
        {
            Random rnd = new Random();
            int statNumber = rnd.Next(5);

            switch (statNumber)
            {
                case 0:
                    return "HP";
                case 1:
                    return "Atk";
                case 2:
                    return "Def";
                case 3:
                    return "Spd";
                default:
                    return "";
            }
        }
        private bool AttemptEscape()
        {
            Random rnd = new Random();
            int attempt = rnd.Next(100);

            if (attempt < 10)
            {
                return false;
            }
            return true;
        }

    }
}
