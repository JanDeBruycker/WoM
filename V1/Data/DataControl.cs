using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldOfMagic.Classes;

namespace WorldOfMagic
{
    class DataControl
    {
        public static void CreateDirectory()
        {
            string dir = @"C:\WoM\";
            Directory.CreateDirectory(dir);
        }
        public static void CreatePlayer(string type)
        {
            Player player = new Player(); 
            player.Create(0, "Player", type, 5, "A1", 7, 9);

            string path = @"C:\WoM\player.txt";
            string data = $"{player.ImageId};{player.Type};{player.Level};{player.HitPoints};" +
                $"{player.Ability1.Id};{player.Ability2.Id};{player.Ability3.Id};{player.Ability4.Id};" + 
                $"{player.Item1.Id};{player.Item2.Id};{player.Item3.Id};{player.MapId};{player.LocX};{player.LocY};" +
                $"{player.Experience};{player.Money};" ;
            
            File.WriteAllText(path, data);
        }
        public static void CreateOpponents()
        {
            for (int i = 0; i < Data.FixedOpponents().Count; i++)
            {
                Opponent opp = Data.FixedOpponents()[i];

                string path = $@"C:\WoM\opp{opp.Id}.txt";
                string data = $"{opp.Id};{opp.ImageId};{opp.Name};{opp.Type};{opp.Level};" + 
                    $"{opp.MapId};{opp.LocX};{opp.LocY};{opp.Status};";

                File.WriteAllText(path, data);
            }
        }
        public static void CreateItems()
        {
            for (int i = 0; i < Data.Items().Count; i++)
            {
                Item item = Data.Items()[i];

                string path = $@"C:\WoM\item{item.Id}.txt";
                string data = $"{item.Id};{item.ImageId};{item.Name};{item.Type};{item.Bonus};{item.Price};{item.MapId};{item.LocX};{item.LocY};{item.Status};";

                File.WriteAllText(path, data);
            }

            Messages.NewGameCreated();
        }

        public static Player LoadPlayer()
        {
            Player player = new Player();

            string path = @"C:\WoM\player.txt";

            if (File.Exists(path))
            {
                string data = File.ReadAllText(path);

                string[] sortedData = new string[16];

                for (int i = 0; i < 16; i++)
                {
                    int index = data.IndexOf(";");
                    if (index > 0)
                    {
                        sortedData[i] = data.Substring(0, index);
                        data = data.Remove(0, index + 1);
                    }
                }

                Ability[] abilities = new Ability[4];
                abilities[0] = Data.Abilities()[Convert.ToInt32(sortedData[4])];
                abilities[1] = Data.Abilities()[Convert.ToInt32(sortedData[5])];
                abilities[2] = Data.Abilities()[Convert.ToInt32(sortedData[6])];
                abilities[3] = Data.Abilities()[Convert.ToInt32(sortedData[7])];

                Item[] items = new Item[3];
                items[0] = Data.Items()[Convert.ToInt32(sortedData[8])];
                items[1] = Data.Items()[Convert.ToInt32(sortedData[9])];
                items[2] = Data.Items()[Convert.ToInt32(sortedData[10])];

                player.Set(Convert.ToInt32(sortedData[0]), sortedData[1], Convert.ToInt32(sortedData[2]), 
                    Convert.ToInt32(sortedData[3]), abilities, items, sortedData[11], Convert.ToInt32(sortedData[12]), Convert.ToInt32(sortedData[13]), 
                    Convert.ToInt32(sortedData[14]),  Convert.ToInt32(sortedData[15]));
            }
            return player;
        }
        public static List<Opponent> LoadOpponents(string mapId)
        {
            List<Opponent> mapOpponents = new List<Opponent>();
            
            for (int i = 0; i < Data.FixedOpponents().Count; i++)
            {
                string path = $@"C:\WoM\opp{i}.txt";

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

                    Opponent opp = new Opponent();
                    opp.Set(Convert.ToInt32(sortedData[0]), Convert.ToInt32(sortedData[1]), sortedData[2], sortedData[3], Convert.ToInt32(sortedData[4]),
                        sortedData[5], Convert.ToInt32(sortedData[6]), Convert.ToInt32(sortedData[7]), sortedData[8]);

                    if (mapId == opp.MapId)
                    {
                        mapOpponents.Add(opp);
                    }    
                }
            }
            return mapOpponents;
        }
        public static List<Item> LoadItems(string mapId)
        {
            List<Item> mapItems = new List<Item>();

            for (int i = 0; i < Data.Items().Count; i++)
            {
                string path = $@"C:\WoM\item{i}.txt";

                if (File.Exists(path))
                {
                    string data = File.ReadAllText(path);
                    string[] sortedData = new string[10];

                    for (int j = 0; j < 10; j++)
                    {
                        int index = data.IndexOf(";");
                        if (index > 0)
                        {
                            sortedData[j] = data.Substring(0, index);
                            data = data.Remove(0, index + 1);
                        }
                    }

                    Item item = new Item();
                    item.Set(Convert.ToInt32(sortedData[0]), Convert.ToInt32(sortedData[1]), sortedData[2], sortedData[3], 
                        Convert.ToInt32(sortedData[4]), Convert.ToInt32(sortedData[5]), sortedData[6], Convert.ToInt32(sortedData[7]),
                        Convert.ToInt32(sortedData[8]), sortedData[9]);

                    if (mapId == item.MapId)
                    {
                        mapItems.Add(item);
                    }
                }
            }
            return mapItems;
        }

        public static void SaveGame(Player player, List<Opponent> opponents, List<Item> items)
        {
            string path = @"C:\WoM\player.txt";
            string data = $"{player.ImageId};{player.Type};{player.Level};{player.HitPoints};" +
                $"{player.Ability1.Id};{player.Ability2.Id};{player.Ability3.Id};{player.Ability4.Id};" +
                $"{player.Item1.Id};{player.Item2.Id};{player.Item3.Id};{player.MapId};{player.LocX};{player.LocY};" +
                $"{player.Experience};{player.Money};";

            File.WriteAllText(path, data);

            foreach (var opp in opponents)
            {
                path = $@"C:\WoM\opp{opp.Id}.txt";
                data = $"{opp.Id};{opp.ImageId};{opp.Name};{opp.Type};{opp.Level};{opp.MapId};{opp.LocX};{opp.LocY};{opp.Status};";

                File.WriteAllText(path, data);
            }

            foreach (var item in items)
            {
                path = $@"C:\WoM\item{item.Id}.txt";
                data = $"{item.Id};{item.ImageId};{item.Name};{item.Type};{item.Bonus};{item.Price};{item.MapId};{item.LocX};{item.LocY};{item.Status};";

                File.WriteAllText(path, data);
            }

            Messages.GameSaved();
        }

    }
}
