using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldOfMagic.Interfaces.World
{
    public partial class Items : Form
    {
        public Player Player;

        public Items()
        {
            InitializeComponent();
        }
        private void Items_Load(object sender, EventArgs e)
        {
            lblName.Text = Player.Name;

            if (Player.Item1.Type == "Potion")
            {
                lblItem1.Text = $"{Player.Item1.Name} (Restore {Player.Item1.Bonus} HP)";
            }
            else if (Player.Item1.Type == "Rune")
            {
                lblItem1.Text = $"{Player.Item1.Name} (Deal {Player.Item1.Bonus} DMG)";
            }
            else
            {
                lblItem1.Text = "Empty Slot";
            }

            if (Player.Item2.Type == "Potion")
            {
                lblItem2.Text = $"{Player.Item2.Name} (Restore {Player.Item2.Bonus} HP)";
            }
            else if (Player.Item2.Type == "Rune")
            {
                lblItem2.Text = $"{Player.Item2.Name} (Deal {Player.Item2.Bonus} DMG)";
            }
            else
            {
                lblItem2.Text = "Empty Slot";
            }

            if (Player.Item3.Type == "Potion")
            {
                lblItem3.Text = $"{Player.Item3.Name} (Restore {Player.Item3.Bonus} HP)";
            }
            else if (Player.Item3.Type == "Potion")
            {
                lblItem3.Text = $"{Player.Item3.Name} (Deal {Player.Item3.Bonus} DMG)";
            }
            else
            {
                lblItem3.Text = "Empty Slot";
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
