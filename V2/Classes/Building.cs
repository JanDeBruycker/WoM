using System;
using System.Collections.Generic;
using System.Text;

namespace ElementalWar.Classes
{
    public class Building
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }

        public void Set(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }
    }
}
