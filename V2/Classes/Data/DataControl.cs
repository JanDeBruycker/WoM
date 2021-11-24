using ElementalWar.Classes.Character;
using System;
using System.Collections.Generic;
using System.IO;

namespace ElementalWar.Classes.Data
{
    class DataControl
    {
        public static void CreateGame()
        {
            CreateFolders();
            CreateFiles();
        }
        private static void CreateFolders()
        {
            string path = @"C:\EW\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path = @"C:\EW\Files";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);

                path = @"C:\EW\Files\Items";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                path = @"C:\EW\Files\Opponents";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                path = @"C:\EW\Files\Player";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }

            path = @"C:\EW\Images";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);

                path = @"C:\EW\Images\Field";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                path = @"C:\EW\Images\Ability";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                path = @"C:\EW\Images\Building";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                path = @"C:\EW\Images\Item";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                path = @"C:\EW\Images\Character";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);

                    path = @"C:\EW\Images\Character\Player";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    path = @"C:\EW\Images\Character\Opponent";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                }
            }

        }
        private static void CreateFiles()
        {
            // Create...()
            CreateItems();
            CreateOpponents();
        }

        // SAVE OBJECTS INTO FOLDERS (TO SIMPLIFY LOADS & PREVENT LOADING WRONG ITEMS)
        private static void CreateItems()
        {
            foreach (Item item in Data.Items())
            {
                string path = $@"C:\EW\Files\Items\Item_{item.Id}.txt";
                string data = $"{item.Id};{item.ImageId};{item.Name};{item.Type};{item.Bonus};{item.Price};{item.MapId};{item.Row};{item.Column};{item.Status};";

                File.WriteAllText(path, data);
            }
        }
        private static void CreateOpponents()
        {
            foreach (Opponent opp in Data.FixedOpponents())
            {
                string path = $@"C:\EW\Files\Opponents\Opponent_{opp.Id}.txt";
                string data = $"{opp.Id};{opp.ImageId};{opp.Name};{opp.Type};{opp.Level};{opp.MapId};{opp.Row};{opp.Column};{opp.Status};";

                File.WriteAllText(path, data);

            }    
        }


        // Make "LoadGame()" as base later
        public static List<Opponent> LoadOpponents(string mapId)
        {
            List<Opponent> opponentList = new List<Opponent>();

            foreach (Opponent opp in Data.FixedOpponents())
            {
                string path = $@"C:\EW\Files\Opponents\Opponent_{opp.Id}.txt";

                if (File.Exists(path))
                {
                    string data = File.ReadAllText(path);
                    string[] sortedData = new string[9];

                    for (int j = 0; j < 9; j++)
                    {
                        int index = data.IndexOf(";");
                        if (index > 0)
                        {
                            sortedData[j] = data.Substring(0, index);
                            data = data.Remove(0, index + 1);
                        }
                    }

                    opp.Set(Convert.ToInt32(sortedData[0]), Convert.ToInt32(sortedData[1]), sortedData[2], sortedData[3], Convert.ToInt32(sortedData[4]),
                        sortedData[5], Convert.ToInt32(sortedData[6]), Convert.ToInt32(sortedData[7]), sortedData[8]);

                    if (mapId == opp.MapId)
                    {
                        opponentList.Add(opp);
                    }
                }
            }
            return opponentList;
        }

    }
}
