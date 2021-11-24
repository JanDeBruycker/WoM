using System;

namespace WorldOfMagic
{
    public class Opponent : Character
    {
        public string Status { get; set; }

        // Set Opponent from Data
        public void Set(int id, int imgId, string name, string type, int lvl, string mapId, int locX, int locY, string status)
        {
            Create(id, name, type, lvl, mapId, locX, locY);
            ChangeImageId(imgId);

            Status = status;

            MapId = mapId;
            LocX = locX;
            LocY = locY;
        }

        // Set Opponent Status to 'DEFEATED'
        public void ChangeStatus()
        {
            Status = "DEFEATED";
        }

    }
}
