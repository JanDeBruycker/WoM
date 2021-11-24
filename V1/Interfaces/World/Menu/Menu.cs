using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldOfMagic
{
    public partial class Menu : Form
    {
        public Player Player;
        public string Command = "";

        public Menu()
        {
            InitializeComponent();
        }
        private void btnShowStats_Click(object sender, EventArgs e)
        {
            Player.ShowStats();
        }
        private void btnShowItems_Click(object sender, EventArgs e)
        {
            Player.ShowItems();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Command = "Save";
            Close();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            Command = "Load";
            Close();
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Command = "Quit";
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
