using ElementalWar.UI;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace ElementalWar.Classes.Character
{
    public class Player : Character
    {
        public int Experience { get; private set; }
        public int Money { get; private set; }

        public void Set(int imgId, string type, int lvl, int hp, Ability[] abilities, Item[] items, string mapId, int row, int column,
    int exp, int money)
        {
            Create(1, "Player", type, lvl, "A1", 4, 7);
            ChangeImageId(imgId);

            HitPoints = hp;

            Ability1 = abilities[0];
            Ability2 = abilities[1];
            Ability3 = abilities[2];
            Ability4 = abilities[3];

            Item1 = items[0];
            Item2 = items[1];
            Item3 = items[2];

            ChangeMapId(mapId);
            ChangePosition(row, column);

            Experience = exp;
            Money = money;
        }

        public void Move(string direction, Grid myGrid, List<Opponent> opponentList)
        {
            MoveCharacter(direction, myGrid);

            MovementData md = new MovementData();

            md.ChangeRandomId(CheckGrass(myGrid));
            md.ChangeFixedId(CheckOpponentsVision(opponentList));

            if (md.OpponentId != -1)
            {
                string result = Fight(md.OpponentSort, md.OpponentId);
                if (result == "Win" && md.OpponentSort == "Fixed")
                {
                    ChangeOpponent(myGrid, md.OpponentId, opponentList);
                }
                else if (result == "Loss")
                {
                    // Set to fixed position + map?
                }
            }          

            if (CheckPortals(myGrid))
            {
                // TELEPORT
            }
        }
        private bool CheckPortals(Grid myGrid)
        {
            foreach (Image img in myGrid.Children)
            {
                if (img.Name == $"Portal_{Row}_{Column}")
                {
                    return true;
                }
            }
            return false;
        }
        private int CheckGrass(Grid myGrid)
        {
            foreach (Image img in myGrid.Children)
            {
                if (img.Name == $"Grass_{Row}_{Column}")
                {
                    if (RandomSpawn())
                    {
                        return RandomId();
                    }
                }
            }
            return -1;
        }
        private int CheckOpponentsVision(List<Opponent> opponentList)
        {
            foreach (Opponent opp in opponentList)
            {
                int incrRow = 0; int incrColumn = 0;
                switch (opp.ImageId)
                {
                    case 2:
                        incrRow++;
                        break;
                    case 3:
                        incrRow--;
                        break;
                    case 4:
                        incrColumn++;
                        break;
                    case 5:
                        incrColumn--;
                        break;
                    default:
                        break;
                }

                if ((Row + incrRow == opp.Row && Column + incrColumn == opp.Column) || (Row + incrRow * 2 == opp.Row && Column + incrColumn * 2 == opp.Column))
                {
                    return opp.Id;
                }
            }
            return -1;
        }

        public void Interact(Grid myGrid, List<Item> itemList, List<Opponent> opponentList)
        {
            int incrRow = 0; int incrColumn = 0;

            switch (ImageId)
            {
                case 0:
                    incrRow--;
                    break;
                case 1:
                    incrRow++;
                    break;
                case 2:
                    incrColumn--;
                    break;
                case 3:
                    incrColumn++;
                    break;
                default:
                    break;
            }

            for (int id = 0; id < itemList.Count; id++)
            {
                if (Row + incrRow == itemList[id].Row && Column + incrColumn == itemList[id].Column)
                {
                    PickUpItem(id, itemList);
                    RemoveItem(myGrid, id, itemList);
                }
            }

            for (int id = 0; id < opponentList.Count; id++)
            {
                if (Row + incrRow == opponentList[id].Row && Column + incrColumn == opponentList[id].Column)
                {
                    string result = Fight("Fixed", opponentList[id].Id);
                    if (result == "Win")
                    {
                        ChangeOpponent(myGrid, id, opponentList);
                    }
                }
            }
        }
        private void PickUpItem(int id, List<Item> itemList)
        {
            if (Item1.Id == 0)
            {
                Item1 = itemList[id];
            }
            else if (Item2.Id == 0)
            {
                Item2 = itemList[id];
            }
            else if (Item3.Id == 0)
            {
                Item3 = itemList[id];
            }
        }
        private void RemoveItem(Grid myGrid, int itemId, List<Item> itemList)
        {
            // Set Inactive in List
            itemList[itemId].ChangeStatus();

            // Remove from Screen
            for (int i = 0; i < myGrid.Children.Count; i++)
            {
                Image img = (Image)myGrid.Children[i];
                if (img.Name == $"Item_{itemList[itemId].Row}_{itemList[itemId].Column}")
                {
                    myGrid.Children.Remove(img);
                }
            }
        }
        private void ChangeOpponent(Grid myGrid, int oppId, List<Opponent> opponentList)
        {
            // Set Inactive in List
            opponentList[oppId].ChangeStatus();

            // Change ImageId
            opponentList[oppId].ChangeImageId(1);

            // Change Image on Screen
            for (int i = 0; i < myGrid.Children.Count; i++)
            {
                Image img = (Image)myGrid.Children[i];
                if (img.Name == $"Opponent_{opponentList[oppId].Row}_{opponentList[oppId].Column}")
                {
                    img.Source = Data.Images.OpponentImages()[1].Source;
                }
            }

            /* this isn't needed yet, will only be needed for some opponents
             * 
             * 
            // Set new Position in List
            opponentList[oppId].ChangePosition(newRow, newColumn);

            // Set new Position on Screen
            for (int i = 0; i < myGrid.Children.Count; i++)
            {
                Image img = (Image)myGrid.Children[i];
                if (img.Name == $"Opponent_{opponentList[oppId].Row}_{opponentList[oppId].Column}")
                {
                    //
                }
            }
            */
        }

        public void Control() // AKA Menu
        { 
            
        }

        public string Fight(string oppSort, int oppId)
        {
            Combat combat = new Combat(this, Data.DataControl.LoadOpponents(MapId)[oppId], oppSort);
            combat.ShowDialog();

            return combat.state;
        }
        private bool RandomSpawn()
        {
            Random rng = new Random();
            if (rng.Next(100) < 10)
            {
                return true;
            }
            return false;
        }
        private int RandomId()
        {
            Random rng = new Random();
            return rng.Next(Data.Data.RandomOpponents().Count);
        }
    }
}
