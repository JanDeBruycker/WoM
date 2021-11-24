using System;
using System.Collections.Generic;
using System.Text;

namespace ElementalWar.Classes.Character
{
    public class Opponent : Character
    {
        public string Status { get; set; }

        // Set Opponent from Data
        public void Set(int id, int imgId, string name, string type, int lvl, string mapId, int row, int column, string status)
        {
            Create(id, name, type, lvl, mapId, row, column);
            ChangeImageId(imgId);
            ChangeMapId(mapId);
            Status = status;
        }

        // Set Opponent Status to 'DEFEATED'
        public void ChangeStatus()
        {
            Status = "DEFEATED";
        }
    }
}
