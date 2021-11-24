using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldOfMagic.Interfaces.PlayerSelection
{
    public partial class PlayerTypeSelection : Form
    {
        public string Type;

        public PlayerTypeSelection()
        {
            InitializeComponent();
        }
        private void PlayerTypeSelection_Load(object sender, EventArgs e)
        {
            rdbNoType.Text = "No Type";
            rdbArcane.Text = "Arcane";
            rdbFrost.Text = "Frost";
            rdbFire.Text = "Fire";

            rdbNoType.Checked = true;
            rdbArcane.Checked = false;
            rdbFrost.Checked = false;
            rdbFire.Checked = false;
        }

        private void btnSelectType_Click(object sender, EventArgs e)
        {
            if (rdbNoType.Checked)
            {
                Type = "None";
            }
            else if (rdbArcane.Checked)
            {
                Type = "Arcane";
            }
            else if (rdbFrost.Checked)
            {
                Type = "Frost";
            }
            else if (rdbFire.Checked)
            {
                Type = "Fire";
            }
            Close();
        }
    }
}
