using ElementalWar.Classes;
using ElementalWar.Classes.Character;
using ElementalWar.Classes.Data;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ElementalWar.UI
{
    /// <summary>
    /// Represents a piece of the Map, with its functions
    /// </summary>
    public partial class World : Window
    {
        Player player = new Player();
        List<Item> itemList = new List<Item>();
        List<Opponent> opponentList = new List<Opponent>();

        public World()
        {
            InitializeComponent();

            DataControl.CreateGame(); // Move this to login screen

            LoadPlayer(); // Why here? I want it to be last ...

            LoadMap();
            LoadBuildings();
            LoadItems();
            LoadOpponents();
            
        }
        private void LoadMap()
        {
            if (player.MapId == "A1")
            {
                for (int row = 0; row < 15; row++)
                {
                    for (int column = 0; column < 15; column++)
                    {
                        Image field = new Image();
                        field.Name = $"Dirt_{row}_{column}";
                        field.Source = Images.FieldImages()[0].Source;
                        field.Stretch = Stretch.Fill;

                        // Roads
                        if (column >= 3 && column <= 11)
                        {
                            if (row >= 3 && row <= 7)
                            {
                                field.Name = $"Road_{row}_{column}";
                                field.Source = Images.FieldImages()[2].Source;
                            }
                        }
                        if (column >= 6 && column <= 8)
                        {
                            if (row >= 8 && row <= 14)
                            {
                                field.Name = $"Road_{row}_{column}";
                                field.Source = Images.FieldImages()[2].Source;
                            }
                        }

                        // Grass
                        if (row >= 0 && row <= 1)
                        {
                            field.Name = $"Grass_{row}_{column}";
                            field.Source = Images.FieldImages()[1].Source;

                        }
                        if (column >= 0 && column <= 1)
                        {

                            field.Name = $"Grass_{row}_{column}";
                            field.Source = Images.FieldImages()[1].Source;
                        }
                        if (column >= 13 && column <= 14)
                        {
                            if (row != 6)
                            {
                                field.Name = $"Grass_{row}_{column}";
                                field.Source = Images.FieldImages()[1].Source;
                            }
                        }
                        if (column >= 2 && column <= 3)
                        {
                            if (row >= 9 && row <= 14)
                            {
                                field.Name = $"Grass_{row}_{column}";
                                field.Source = Images.FieldImages()[1].Source;
                            }
                        }
                        if (column >= 11 && column <= 12)
                        {
                            if (row >= 9 && row <= 14)
                            {
                                field.Name = $"Grass_{row}_{column}";
                                field.Source = Images.FieldImages()[1].Source;
                            }
                        }
                        if (column == 4)
                        {
                            if (row == 9)
                            {
                                field.Name = $"Grass_{row}_{column}";
                                field.Source = Images.FieldImages()[1].Source;
                            }
                            if (row >= 13 && row <= 14)
                            {
                                field.Name = $"Grass_{row}_{column}";
                                field.Source = Images.FieldImages()[1].Source;
                            }
                        }
                        if (column == 10)
                        {
                            if (row == 9)
                            {
                                field.Name = $"Grass_{row}_{column}";
                                field.Source = Images.FieldImages()[1].Source;
                            }
                            if (row >= 13 && row <= 14)
                            {
                                field.Name = $"Grass_{row}_{column}";
                                field.Source = Images.FieldImages()[1].Source;
                            }
                        }

                        // Walls
                        if (row == 2)
                        {
                            if (column >= 2 && column <= 12)
                            {
                                field.Name = $"Wall_{row}_{column}";
                                field.Source = Images.FieldImages()[3].Source;
                            }
                        }
                        if (row == 8)
                        {
                            if (column >= 2 && column <= 5)
                            {
                                field.Name = $"Wall_{row}_{column}";
                                field.Source = Images.FieldImages()[3].Source;
                            }
                            if (column >= 9 && column <= 12)
                            {
                                field.Name = $"Wall_{row}_{column}";
                                field.Source = Images.FieldImages()[3].Source;
                            }
                        }
                        if (column == 2)
                        {
                            if (row >= 2 && row <= 8)
                            {
                                field.Name = $"Wall_{row}_{column}";
                                field.Source = Images.FieldImages()[3].Source;
                            }
                        }
                        if (column == 12)
                        {
                            if (row >= 2 && row <= 5)
                            {
                                field.Name = $"Wall_{row}_{column}";
                                field.Source = Images.FieldImages()[3].Source;
                            }
                            if (row >= 7 && row <= 8)
                            {
                                field.Name = $"Wall_{row}_{column}";
                                field.Source = Images.FieldImages()[3].Source;
                            }
                        }
                        if (column == 5)
                        {
                            if (row >= 8 && row <= 14 && row != 11)
                            {
                                field.Name = $"Wall_{row}_{column}";
                                field.Source = Images.FieldImages()[3].Source;
                            }
                        }
                        if (column == 9)
                        {
                            if (row >= 8 && row <= 14 && row != 11)
                            {
                                field.Name = $"Wall_{row}_{column}";
                                field.Source = Images.FieldImages()[3].Source;
                            }
                        }

                        // Portals
                        if (row == 6 && column == 14)
                        {
                            field.Name = $"Portal_{row}_{column}";
                            field.Source = Images.FieldImages()[4].Source;
                        }
                        if (row == 14)
                        {
                            if (column >= 6 && column <= 8)
                            {
                                field.Name = $"Portal_{row}_{column}";
                                field.Source = Images.FieldImages()[4].Source;
                            }
                        }

                        RegisterName(field.Name, field);
                        myGrid.Children.Add(field);

                        Grid.SetRow(field, row);
                        Grid.SetColumn(field, column);
                        Grid.SetZIndex(field, 0);
                    }
                }
            }
        }
        private void LoadBuildings()
        {
            if (player.MapId == "A1")
            {
                // Create Building (Item_Center)
                Image itemCenter = new Image();
                itemCenter.Name = "Shopping_3_4";
                itemCenter.Source = Images.BuildingImages()[1].Source;
                itemCenter.Stretch = Stretch.Fill;

                // Add Building to Grid (+ Register Name)
                RegisterName(itemCenter.Name, itemCenter);
                myGrid.Children.Add(itemCenter);

                // Set Building on Grid
                Grid.SetRow(itemCenter, 3);
                Grid.SetColumn(itemCenter, 4);
                Grid.SetRowSpan(itemCenter, 3);
                Grid.SetColumnSpan(itemCenter, 3);
                Grid.SetZIndex(itemCenter, 1);


                // Create Building (HP_Center)
                Image hpCenter = new Image();
                hpCenter.Name = "Recovery_3_8";
                hpCenter.Source = Images.BuildingImages()[0].Source;
                hpCenter.Stretch = Stretch.Fill;

                // Add Building to Grid (+ Register Name)
                RegisterName(hpCenter.Name, hpCenter);
                myGrid.Children.Add(hpCenter);

                // Set Building on Grid
                Grid.SetRow(hpCenter, 3);
                Grid.SetColumn(hpCenter, 8);
                Grid.SetRowSpan(hpCenter, 3);
                Grid.SetColumnSpan(hpCenter, 3);
                Grid.SetZIndex(hpCenter, 1);
            }
        }
        private void LoadItems()
        {
            if (player.MapId == "A1")
            {
                // Get Item's Position
                string mapId = Data.Items()[3].MapId;
                int row = Data.Items()[3].Row;
                int column = Data.Items()[3].Column;

                // Create Item (Item Guru)
                Image potion = new Image();
                potion.Name = $"Item_{row}_{column}";
                potion.Source = Images.ItemImages()[Data.Items()[3].ImageId].Source;
                potion.Stretch = Stretch.Fill;

                // Add Item to List
                itemList.Add(Data.Items()[3]);

                // Add Item to Grid (+ Register Name)
                RegisterName(potion.Name, potion);
                myGrid.Children.Add(potion);

                // Set Item on Grid
                Grid.SetRow(potion, row);
                Grid.SetColumn(potion, column);
                Grid.SetZIndex(potion, 2);
            }
        }
        private void LoadOpponents()
        {
            if (player.MapId == "A1")
            {
                // Get Opponent's Position
                string mapId = Data.FixedOpponents()[0].MapId;
                int row = Data.FixedOpponents()[0].Row;
                int column = Data.FixedOpponents()[0].Column;

                // Create Opponent (Item Guru)
                Image itemGuru = new Image();
                itemGuru.Name = $"Opponent_{row}_{column}";
                itemGuru.Source = Images.OpponentImages()[Data.FixedOpponents()[0].ImageId].Source;
                itemGuru.Stretch = Stretch.Fill;

                // Add Opponent to List
                opponentList.Add(Data.FixedOpponents()[0]);

                // Add Opponent to Grid (+ Register Name)
                RegisterName(itemGuru.Name, itemGuru);
                myGrid.Children.Add(itemGuru);

                // Set Opponent on Grid
                Grid.SetRow(itemGuru, row);
                Grid.SetColumn(itemGuru, column);
                Grid.SetZIndex(itemGuru, 2);


                // Get Opponent's Position
                row = Data.FixedOpponents()[1].Row;
                column = Data.FixedOpponents()[1].Column;

                // Create Opponent (Item Guru)
                Image healthGuru = new Image();
                healthGuru.Name = $"Opponent_{row}_{column}";
                healthGuru.Source = Images.OpponentImages()[Data.FixedOpponents()[1].ImageId].Source;
                healthGuru.Stretch = Stretch.Fill;

                // Add Opponent to List
                opponentList.Add(Data.FixedOpponents()[1]);

                // Add Opponent to Grid (+ Register Name)
                RegisterName(healthGuru.Name, healthGuru);
                myGrid.Children.Add(healthGuru);

                // Set Opponent on Grid
                Grid.SetRow(healthGuru, row);
                Grid.SetColumn(healthGuru, column);
                Grid.SetZIndex(healthGuru, 2);


                // Get Opponent's Position
                row = Data.FixedOpponents()[2].Row;
                column = Data.FixedOpponents()[2].Column;

                // Create Opponent (Item Guru)
                Image guard = new Image();
                guard.Name = $"Opponent_{row}_{column}";
                guard.Source = Images.OpponentImages()[Data.FixedOpponents()[2].ImageId].Source;
                guard.Stretch = Stretch.Fill;

                // Add Opponent to List
                opponentList.Add(Data.FixedOpponents()[2]);

                // Add Opponent to Grid (+ Register Name)
                RegisterName(guard.Name, guard);
                myGrid.Children.Add(guard);

                // Set Opponent on Grid
                Grid.SetRow(guard, row);
                Grid.SetColumn(guard, column);
                Grid.SetZIndex(guard, 2);
            }
        }
        private void LoadPlayer()
        {
            // CHANGE THIS WHEN PLAYER IS LOADED FROM FILE 
            Ability[] abilities = new Ability[4];
            abilities[0] = Data.Abilities()[5];
            abilities[1] = Data.Abilities()[6];
            abilities[2] = Data.Abilities()[7];
            abilities[3] = Data.Abilities()[8];

            Item[] items = new Item[3];
            items[0] = Data.Items()[1];
            items[1] = Data.Items()[2];
            items[2] = Data.Items()[0];

            // Set Player Properties
            player.Set(1, "Physical", 5, 25, abilities, items, "A1", 4, 7, 0, 50);
            SetImageId();

            // Set Player on Grid
            Grid.SetRow(imgPlayer, player.Row);
            Grid.SetColumn(imgPlayer, player.Column);
            Grid.SetZIndex(imgPlayer, 3);
        }

        private void Movement(string direction)
        {
            player.Move(direction, myGrid, opponentList);
            
            SetPlayer();
        }
        private void OpponentMovement()
        {
            opponentList[0].MoveCharacter("Down", myGrid);

            // SetOpponent();
        }
        private void Interaction()
        {
            player.Interact(myGrid, itemList, opponentList);

            SetPlayer();
        }
        private void Controls()
        {
            // player.ShowMenu();

            SetPlayer();
        }

        private void SetPlayer()
        {
            SetImageId();
            SetGridPosition();
        }
        private void SetImageId()
        {
            switch (player.ImageId)
            {
                case 0:
                    imgPlayer.Source = Images.PlayerImages()[0].Source;
                    break;
                case 1:
                    imgPlayer.Source = Images.PlayerImages()[1].Source;
                    break;
                case 2:
                    imgPlayer.Source = Images.PlayerImages()[2].Source;
                    break;
                case 3:
                    imgPlayer.Source = Images.PlayerImages()[3].Source;
                    break;
                default:
                    break;
            }
        }
        private void SetGridPosition()
        {
            Grid.SetRow(imgPlayer, player.Row);
            Grid.SetColumn(imgPlayer, player.Column);
        }

        private void World_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "Up" || e.Key.ToString() == "Down" || e.Key.ToString() == "Left" || e.Key.ToString() == "Right")
            {
                Movement(e.Key.ToString());
            }
            else if (e.Key.ToString() == "Enter" || e.Key.ToString() == "Return")
            {
                Interaction();
            }
            else if (e.Key.ToString() == "Escape")
            {
                Controls();
            }
        }
    }
}
