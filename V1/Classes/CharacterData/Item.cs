using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfMagic.Classes;

namespace WorldOfMagic
{
    public class Item
    {
        public int Id { get; private set; }
        public int ImageId { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }

        public int Bonus { get; private set; }
        public int Price { get; private set; }

        public string MapId { get; set; }
        public int LocX { get; set; }
        public int LocY { get; set; }

        public string Status { get; set; }


        public void Set(int id, int imgId, string name, string type, int bonus, int price)
        {
            Id = id;
            ImageId = imgId;
            Name = name;
            Type = type;
            Bonus = bonus;
            Price = price;
        }
        public void Set(int id, int imgId, string name, string type, int bonus, int price, string mapId, int locX, int locY, string status)
        {
            Id = id;
            ImageId = imgId;
            Name = name;
            Type = type;
            
            Bonus = bonus;
            Price = price;

            MapId = mapId;
            LocX = locX;
            LocY = locY;

            Status = status;
        }

        public CombatData Use(CombatData data)
        {
            data.ItemName = Name;
            data.ItemType = Type;

            if (Type == "Potion")
            {
                data.ItemHealing = Bonus;
            }
            else if (Type == "Rune")
            {
                data.ItemDamage = Bonus;
            }

            Set(Data.Items()[0].Id, Data.Items()[0].ImageId, Data.Items()[0].Name, Data.Items()[0].Type, 0, 0);

            return data;
        }

        public void ChangeStatus()
        {
            Status = "Picked_Up";

            LocX = -1;
            LocY = -1;
        }

    }
}
