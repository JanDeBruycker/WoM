using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WorldOfMagic.Classes;

namespace WorldOfMagic
{
    public partial class InterfaceWorld : Form
    {
        public string ReasonOfClose = "Quit";
        public Player Player;

        List<Building> BuildingList = new List<Building>();     // Buildings Data
        List<Item> ItemList = new List<Item>();                 // Items Data
        List<Opponent> OpponentList = new List<Opponent>();     // Opponents Data

        List<PictureBox> Portals = new List<PictureBox>();      // Portal (Next Zone)
        List<PictureBox> Walls = new List<PictureBox>();        // Obstacle (Wall)
        List<PictureBox> Buildings = new List<PictureBox>();    // Obstacle (Building)
        List<PictureBox> Items = new List<PictureBox>();        // Obstacle (Item)
        List<PictureBox> Opponents = new List<PictureBox>();    // Obstacle (Opponent)
        List<PictureBox> Grass = new List<PictureBox>();        // Grass (Random Spawn Possible)

        public InterfaceWorld()
        {
            InitializeComponent();
        }
        private void InterfaceWorld_Load(object sender, EventArgs e)
        {
            LoadInterface();
        }
        private void InterfaceWorld_KeyDown(object sender, KeyEventArgs e)
        {
            MovementKeys(e);
        }

        // Load Map + Objects
        private void LoadInterface()
        {
            LoadPanels();
            LoadMap();
            LoadBuildings();
            LoadItems();
            LoadOpponents();
            LoadPlayer();
            Focus();
        }
        private void LoadPanels()
        {
            // Set Form Size & Children
            int sizeX = 14; int sizeY = 14;

            gpbControls.Location = new Point(5, sizeY * 25 + 30);
            gpbInteractions.Location = new Point(5, sizeY * 25 + 80);
            gpbMenu.Location = new Point(5, sizeY * 25 + 130);

            pnlFieldHolder.Location = new Point(0, 0);
            pnlFieldHolder.Size = new Size(sizeX * 25 + 25, sizeY * 25 + 25);

            this.Size = new Size(sizeX * 25 + 42, sizeY * 25 + 225);
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }
        private void LoadMap()
        {
            int sizeX = 14; int sizeY = 14;

            if (Player.MapId == "A1")
            {
                for (int x = 0; x <= sizeX; x++)
                {
                    for (int y = 0; y <= sizeY; y++)
                    {
                        PictureBox field = new PictureBox();
                        field.Size = new Size(25, 25);
                        field.Location = new Point(x * 25, y * 25);
                        field.Image = Data.FieldImages()[0]; // 'Dirt' Field
                        field.SizeMode = PictureBoxSizeMode.StretchImage;
                        field.Margin = new Padding(0);

                        // Walls
                        if (x == 0)
                        {
                            if (y >= 0 && y <= 14) // Bounds (inclusive) >= =< ; Exceptions != ;
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }
                        if (y == 0)
                        {
                            if (x >= 0 && x <= 14)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }
                        if (x == 14)
                        {
                            if (y >= 0 && y <= 5)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                            if (y >= 7 && y <= 14)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }
                        if (y == 14)
                        {
                            if (x >= 0 && x <= 2)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                            if (x >= 12 && x <= 14)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }

                        // Grass
                        if (y >= 1 && y <= 2) // Location + Size Y
                        {
                            if (x >= 1 && x <= 13) // Location + Size X
                            {
                                Grass.Add(field);
                                field.Image = Data.FieldImages()[1];
                            }
                        }
                        if (y >= 3 && y <= 12 && y != 4)
                        {
                            if (x >= 1 && x <= 3)
                            {
                                Grass.Add(field);
                                field.Image = Data.FieldImages()[1];
                            }
                        }
                        if (y >= 3 && y <= 12 && y != 6)
                        {
                            if (x >= 11 && x <= 13)
                            {
                                Grass.Add(field);
                                field.Image = Data.FieldImages()[1];
                            }
                        }
                        if (y >= 10 && y <= 12)
                        {
                            if (x >= 4 && x <= 5)
                            {
                                Grass.Add(field);
                                field.Image = Data.FieldImages()[1];
                            }
                        }
                        if (y >= 10 && y <= 12)
                        {
                            if (x >= 9 && x <= 10)
                            {
                                Grass.Add(field);
                                field.Image = Data.FieldImages()[1];
                            }
                        }
                        if (y == 13)
                        {
                            if (x >= 1 && x <= 2)
                            {
                                Grass.Add(field);
                                field.Image = Data.FieldImages()[1];
                            }
                            if (x >= 12 && x <= 13)
                            {
                                Grass.Add(field);
                                field.Image = Data.FieldImages()[1];
                            }
                        }

                        // Portals
                        if (x == 14)
                        {
                            if (y == 6)
                            {
                                Portals.Add(field);
                                field.Image = Data.FieldImages()[3];
                            }
                        }
                        if (y == 14)
                        {
                            if (x >= 3 && x <= 11)
                            {
                                Portals.Add(field);
                                field.Image = Data.FieldImages()[3];
                            }
                        }

                        pnlFieldHolder.Controls.Add(field);
                    }
                }
            }

            if (Player.MapId == "A2")
            {
                for (int x = 0; x <= sizeX; x++)
                {
                    for (int y = 0; y <= sizeY; y++)
                    {
                        PictureBox field = new PictureBox();
                        field.Size = new Size(25, 25);
                        field.Location = new Point(x * 25, y * 25);
                        field.Image = Data.FieldImages()[0]; // 'Dirt' Field
                        field.SizeMode = PictureBoxSizeMode.StretchImage;
                        field.Margin = new Padding(0);

                        // Walls
                        if (x == 0)
                        {
                            if (y >= 0 && y <= 14) // Bounds (inclusive) >= =< ; Exceptions != ;
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }
                        if (y == 0)
                        {
                            if (x >= 0 && x <= 2)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                            if (x >= 12 && x <= 14)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }
                        if (x == 14)
                        {
                            if (y >= 0 && y <= 14)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }
                        if (y == 14)
                        {
                            if (x >= 0 && x <= 2)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                            if (x >= 5 && x <= 14)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }

                        // Grass
                        if (y == 1)
                        {
                            if (x >= 1 && x <= 2)
                            {
                                Grass.Add(field);
                                field.Image = Data.FieldImages()[1];
                            }
                        }
                        if (y >= 2 && y <= 3)
                        {
                            if (x >= 1 && x <= 12)
                            {
                                Grass.Add(field);
                                field.Image = Data.FieldImages()[1];
                            }
                        }
                        if (y >= 5 && y <= 6)
                        {
                            if (x >= 2 && x <= 13)
                            {
                                Grass.Add(field);
                                field.Image = Data.FieldImages()[1];
                            }
                        }
                        if (y >= 8 && y <= 9)
                        {
                            if (x >= 1 && x <= 12)
                            {
                                Grass.Add(field);
                                field.Image = Data.FieldImages()[1];
                            }
                        }
                        if (y >= 11 && y <= 12)
                        {
                            if (x >= 2 && x <= 13)
                            {
                                Grass.Add(field);
                                field.Image = Data.FieldImages()[1];
                            }
                        }
                        if (y == 13)
                        {
                            if (x >= 5 && x <= 13)
                            {
                                Grass.Add(field);
                                field.Image = Data.FieldImages()[1];
                            }
                        }

                        // Portals
                        if (y == 0)
                        {
                            if (x >= 3 && x <= 11)
                            {
                                Portals.Add(field);
                                field.Image = Data.FieldImages()[3];
                            }
                        }
                        if (y == 14)
                        {
                            if (x >= 3 && x <= 4)
                            {
                                Portals.Add(field);
                                field.Image = Data.FieldImages()[3];
                            }
                        }

                        pnlFieldHolder.Controls.Add(field);
                    }
                }
            }

            if (Player.MapId == "A3")
            {
                for (int x = 0; x <= sizeX; x++)
                {
                    for (int y = 0; y <= sizeY; y++)
                    {
                        PictureBox field = new PictureBox();
                        field.Size = new Size(25, 25);
                        field.Location = new Point(x * 25, y * 25);
                        field.Image = Data.FieldImages()[0]; // 'Dirt' Field
                        field.SizeMode = PictureBoxSizeMode.StretchImage;
                        field.Margin = new Padding(0);

                        // Walls
                        if (x == 0)
                        {
                            if (y >= 0 && y <= 14) // Bounds (inclusive) >= =< ; Exceptions != ;
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }
                        if (y == 0)
                        {
                            if (x >= 0 && x <= 2)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                            if (x >= 5 && x <= 14)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }
                        if (x == 14)
                        {
                            if (y >= 0 && y <= 10)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                            if (y >= 12 && y <= 14)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }
                        if (y == 14)
                        {
                            if (x >= 0 && x <= 14)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }

                        // Grass
                        if (y >= 4 && y <= 7) // Location + Size Y
                        {
                            if (x >= 1 && x <= 13) // Location + Size X
                            {
                                Grass.Add(field);
                                field.Image = Data.FieldImages()[1];
                            }
                        }
                        if (y >= 9 && y <= 13) // Location + Size Y
                        {
                            if (x >= 7 && x <= 13) // Location + Size X
                            {
                                Grass.Add(field);
                                field.Image = Data.FieldImages()[1];
                            }
                        }

                        // Extra Walls
                        if (y == 3)
                        {
                            if (x >= 1 && x <= 8)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                            if (x >= 12 && x <= 13)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }

                        if (y == 8)
                        {
                            if (x == 1)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                            if (x >= 5 && x <= 13)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }
                        if (x == 6)
                        {
                            if (y >= 8 && y <= 9)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                            if (y == 13)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }

                        if (x == 10)
                        {
                            if (y >= 10 && y <= 12)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }

                        // Portals
                        if (y == 0)
                        {
                            if (x >= 3 && x <= 4)
                            {
                                Portals.Add(field);
                                field.Image = Data.FieldImages()[3];
                            }
                        }
                        if (x == 14)
                        {
                            if (y == 11)
                            {
                                Portals.Add(field);
                                field.Image = Data.FieldImages()[3];
                            }
                        }

                        pnlFieldHolder.Controls.Add(field);
                    }
                }
            }

            if (Player.MapId == "B3")
            {
                for (int x = 0; x <= sizeX; x++)
                {
                    for (int y = 0; y <= sizeY; y++)
                    {
                        PictureBox field = new PictureBox();
                        field.Size = new Size(25, 25);
                        field.Location = new Point(x * 25, y * 25);
                        field.Image = Data.FieldImages()[0]; // 'Dirt' Field
                        field.SizeMode = PictureBoxSizeMode.StretchImage;
                        field.Margin = new Padding(0);

                        // Walls
                        if (x == 0)
                        {
                            if (y >= 0 && y <= 10)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                            if (y >= 12 && y <= 14)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }
                        if (y == 0)
                        {
                            if (x >= 0 && x <= 6)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                            if (x >= 9 && x <= 14)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }
                        if (x == 14)
                        {
                            if (y >= 0 && y <= 9)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                            if (y >= 13 && y <= 14)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }
                        if (y == 14)
                        {
                            if (x >= 0 && x <= 14)
                            {
                                Walls.Add(field);
                                field.Image = Data.FieldImages()[2];
                            }
                        }

                        // Grass
                        if (y >= 2 && y <= 3) // Location + Size Y
                        {
                            if (x >= 6 && x <= 8) // Location + Size X
                            {
                                Grass.Add(field);
                                field.Image = Data.FieldImages()[1];
                            }
                        }


                        // Extra Walls


                        // Portals
                        if (x == 0)
                        {
                            if (y == 11)
                            {
                                Portals.Add(field);
                                field.Image = Data.FieldImages()[3];
                            }
                        }
                        if (y == 0)
                        {
                            if (x >= 7 && x <= 8)
                            {
                                Portals.Add(field);
                                field.Image = Data.FieldImages()[3];
                            }
                        }
                        if (x == 14)
                        {
                            if (y >= 10 && y <= 12)
                            {
                                Portals.Add(field);
                                field.Image = Data.FieldImages()[3];
                            }
                        }

                        pnlFieldHolder.Controls.Add(field);
                    }
                }
            }

        }
        private void LoadBuildings()
        {
            if (Player.MapId == "A1")
            {
                // Type: Hospital
                Building building = Data.Buildings()[0];

                pcbBuilding0.Size = new Size(5 * 25, 5 * 25);
                pcbBuilding0.Location = new Point(5 * 25, 4 * 25);
                pcbBuilding0.Image = Data.BuildingImages()[0];
                pcbBuilding0.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbBuilding0.BringToFront();

                Buildings.Add(pcbBuilding0);
                BuildingList.Add(building);
            }

            if (Player.MapId == "A2")
            {
                // No Buildings
            }

            if (Player.MapId == "A3")
            {
                // Type: MagicShop
                Building building = Data.Buildings()[2];

                pcbBuilding0.Size = new Size(3 * 25, 3 * 25);
                pcbBuilding0.Location = new Point(2 * 25, 10 * 25);
                pcbBuilding0.Image = Data.BuildingImages()[2];
                pcbBuilding0.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbBuilding0.BringToFront();

                Buildings.Add(pcbBuilding0);
                BuildingList.Add(building);
            }

            if (Player.MapId == "B3")
            {
                // Type: ItemShop
                Building building = Data.Buildings()[1];

                pcbBuilding0.Size = new Size(5 * 25, 5 * 25);
                pcbBuilding0.Location = new Point(5 * 25, 5 * 25);
                pcbBuilding0.Image = Data.BuildingImages()[1];
                pcbBuilding0.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbBuilding0.BringToFront();

                Buildings.Add(pcbBuilding0);
                BuildingList.Add(building);
            }

        }
        private void LoadItems()
        {
            ItemList = DataControl.LoadItems(Player.MapId);

            if (ItemList.Count > 0)
            {
                pcbItem0.Size = new Size(25, 25);
                pcbItem0.Location = new Point(ItemList[0].LocX * 25, ItemList[0].LocY * 25);
                pcbItem0.Image = Data.ItemImages()[ItemList[0].ImageId];
                pcbItem0.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbItem0.BringToFront();

                Items.Add(pcbItem0);
            }
            if (ItemList.Count > 1)
            {
                pcbItem1.Size = new Size(25, 25);
                pcbItem1.Location = new Point(ItemList[1].LocX * 25, ItemList[1].LocY * 25);
                pcbItem1.Image = Data.ItemImages()[ItemList[1].ImageId];
                pcbItem1.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbItem1.BringToFront();

                Items.Add(pcbItem1);
            }


        }
        private void LoadOpponents()
        {
            OpponentList = DataControl.LoadOpponents(Player.MapId);

            if (OpponentList.Count > 0)
            {
                pcbOpp0.Size = new Size(25, 25);
                pcbOpp0.Location = new Point(OpponentList[0].LocX * 25, OpponentList[0].LocY * 25);
                pcbOpp0.Image = Data.OpponentImages()[OpponentList[0].ImageId];
                pcbOpp0.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbOpp0.BringToFront();

                Opponents.Add(pcbOpp0);
            }
            if (OpponentList.Count > 1)
            {
                pcbOpp1.Size = new Size(25, 25);
                pcbOpp1.Location = new Point(OpponentList[1].LocX * 25, OpponentList[1].LocY * 25);
                pcbOpp1.Image = Data.OpponentImages()[OpponentList[1].ImageId];
                pcbOpp1.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbOpp1.BringToFront();

                Opponents.Add(pcbOpp1);
            }
            if (OpponentList.Count > 2)
            {
                pcbOpp1.Size = new Size(25, 25);
                pcbOpp1.Location = new Point(OpponentList[1].LocX * 25, OpponentList[1].LocY * 25);
                pcbOpp1.Image = Data.OpponentImages()[OpponentList[1].ImageId];
                pcbOpp1.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbOpp1.BringToFront();

                Opponents.Add(pcbOpp1);
            }

        }
        private void LoadPlayer()
        {
            pcbPlayer.Size = new Size(25, 25);
            pcbPlayer.Location = new Point(Player.LocX * 25, Player.LocY * 25);
            pcbPlayer.Image = Data.PlayerImages()[Player.ImageId];
            pcbPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbPlayer.BringToFront();
        }

        // Player Controls
        private void MovementKeys(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Z)
            {
                Movement("UP");
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                Movement("DOWN");
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Q)
            {
                Movement("LEFT");
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                Movement("RIGHT");
            }
            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                Interact();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                ShowMenu();
            }
        }
        private void Movement(string direction)
        {
            // Create Player as field
            PictureBox pf = new PictureBox();
            pf.Size = new Size(25, 25); pf.Location = new Point(Player.LocX * 25, Player.LocY * 25);

            // Move (Check for Border/Spawn/Fight)
            int oppId = Player.Move(direction, Portals, Walls, Buildings, Items, Opponents, Grass, OpponentList);
            // if oppId == -3 => Change Map; if oppId == -2 => noOpp; if oppId == -1 => randomOpp; if oppId >= 0 => fixedOpp

            // Change PlayerBG to FieldBG
            pcbPlayer.Location = new Point(Player.LocX * 25, Player.LocY * 25);
            pcbPlayer.Image = Data.PlayerImages()[Player.ImageId];

            // Result 
            if (oppId == -3)
            {
                // PUT THIS IN SEPERATE METHOD
                if (Player.MapId == "A1" && Player.LocY == 13)
                {
                    Player.MapId = "A2";
                    Player.LocY = 1;

                    DataControl.SaveGame(Player, OpponentList, ItemList);

                    ReasonOfClose = "Portal";
                    Close();
                }
                else if (Player.MapId == "A1" && Player.LocX == 13)
                {
                    Player.MapId = "B1";
                    Player.LocX = 1;

                    DataControl.SaveGame(Player, OpponentList, ItemList);

                    ReasonOfClose = "Portal";
                    Close();
                }

                else if (Player.MapId == "A2" && Player.LocY == 1)
                {
                    Player.MapId = "A1";
                    Player.LocY = 13;

                    DataControl.SaveGame(Player, OpponentList, ItemList);

                    ReasonOfClose = "Portal";
                    Close();
                }
                else if (Player.MapId == "A2" && Player.LocY == 13)
                {
                    Player.MapId = "A3";
                    Player.LocY = 1;

                    DataControl.SaveGame(Player, OpponentList, ItemList);

                    ReasonOfClose = "Portal";
                    Close();
                }

                else if (Player.MapId == "A3" && Player.LocY == 1)
                {
                    Player.MapId = "A2";
                    Player.LocY = 13;

                    DataControl.SaveGame(Player, OpponentList, ItemList);

                    ReasonOfClose = "Portal";
                    Close();
                }
                else if (Player.MapId == "A3" && Player.LocX == 13)
                {
                    Player.MapId = "B3";
                    Player.LocX = 1;

                    DataControl.SaveGame(Player, OpponentList, ItemList);

                    ReasonOfClose = "Portal";
                    Close();
                }

                else if (Player.MapId == "B3" && Player.LocX == 1)
                {
                    Player.MapId = "A3";
                    Player.LocX = 13;

                    DataControl.SaveGame(Player, OpponentList, ItemList);

                    ReasonOfClose = "Portal";
                    Close();
                }

                // ADD NEWS MAPS HERE

            }
            else if (oppId == -1) // RandomOpp
            {
                if (Attempt() < 10)
                {
                    int rndOppId = GetRandomOpponentId();
                    string combatResult = Player.Fight(rndOppId, "RANDOM");
                    if (combatResult == "LOSS")
                    {
                        MoveDefeatedPlayer();
                    }
                }
            }
            else if (oppId == 6 || oppId == 7 || oppId == 8) // BossOpp (All Ids)
            {
                string combatResult = Player.Fight(oppId, "BOSS");
                if (combatResult == "WIN")
                {
                    ChangeDefeatedOpponent(oppId);
                }
                else
                {
                    MoveDefeatedPlayer();
                }
            }
            else if (oppId >= 0) // FixedOpp
            {
                string combatResult = Player.Fight(oppId, "FIXED");
                if (combatResult == "WIN")
                {
                    ChangeDefeatedOpponent(oppId);
                }
                else
                {
                    MoveDefeatedPlayer();
                }
            }

        }
        private void Interact()
        {
            int oppId = Player.Interact(Buildings, Items, Opponents, BuildingList, ItemList);

            if (oppId == 10) // BossOpp (All Ids)
            {
                string combatResult = Player.Fight(oppId, "BOSS");
                if (combatResult == "WIN")
                {
                    ChangeDefeatedOpponent(oppId);
                }
                else
                {
                    MoveDefeatedPlayer();
                }
            }
            else if (oppId >= 0 && oppId < Data.FixedOpponents().Count) // FixedOpp
            {
                string combatResult = Player.Fight(oppId, "FIXED");
                if (combatResult == "WIN")
                {
                    ChangeDefeatedOpponent(oppId); ;
                }
                else
                {
                    MoveDefeatedPlayer();
                }
            }
            else if (oppId > 999) // RemoveItem (can be done cleaner)
            {
                oppId -= 1000;
                RemoveItem(oppId);
            }

        }
        private void ShowMenu()
        {
            string command = Player.ShowMenu();

            if (command == "Load")
            {
                ReasonOfClose = "Load";
                Close();
            }
            else if (command == "Save")
            {
                DataControl.SaveGame(Player, OpponentList, ItemList);
            }
            else if (command == "Quit")
            {
                Close();
            }
        }

        // Fight Results
        private void MoveDefeatedPlayer()
        {
            ReasonOfClose = "Dead";
            Close();
        }
        /// <summary>
        /// -----------CHANGEDEFEATEDOPPP SOMETHING GOES WRONG (NOT FOR MAP == A1)
        /// ID DOES NOT MATCH WITH ZEROBASED VALUE FOR LIST
        /// </summary>
        /// <param name="id"></param>
        private void ChangeDefeatedOpponent(int id)
        {
            OpponentList[id].ChangeImageId(3);
            OpponentList[id].ChangeStatus();

            switch (id)
            {
                case 0:
                    pcbOpp0.Image = Data.OpponentImages()[3];
                    break;
                case 1:
                    pcbOpp1.Image = Data.OpponentImages()[3];
                    break;
                case 2:
                    pcbOpp2.Image = Data.OpponentImages()[3];
                    break;
                case 3:
                    pcbOpp3.Image = Data.OpponentImages()[3];
                    break;
                case 4:
                    pcbOpp4.Image = Data.OpponentImages()[3];
                    break;
                case 5:
                    pcbOpp5.Image = Data.OpponentImages()[3];
                    break;
                default:
                    break;
            }

            DataControl.SaveGame(Player, OpponentList, ItemList);
        }

        // Interact Results
        private void RemoveItem(int itemId)
        {
            // Remove from Obstacle
            Items.RemoveAt(itemId);

            // Remove from Map
            switch (itemId)
            {
                case 0:
                    pcbItem0.Location = new Point(-25, -25);
                    break;
                default:
                    break;
            }
        }

        // Calculations
        private int Attempt()
        {
            Random rnd = new Random();
            return rnd.Next(100);
        }
        private int GetRandomOpponentId()
        {
            int number = 0;
            while (number == 0)
            {
                Random rnd = new Random();
                int maxVal = Data.RandomOpponents().Count + 1;
                number = rnd.Next(0, maxVal);
            }
            return number - 1;
            // Before the While() this always returned 0. (DO NOT CHANGE BACK)
        }

    }
}
