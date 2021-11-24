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
    public partial class MagicShopAbilitySelector : Form
    {
        public Player Player;
        public int AbilityId;
        public MagicShopAbilitySelector()
        {
            InitializeComponent();
        }
        private void MagicShopAbilitySelector_Load(object sender, EventArgs e)
        {
            rbtnAbility1.Text = Player.Ability1.Name;
            rbtnAbility2.Text = Player.Ability2.Name;
            rbtnAbility3.Text = Player.Ability3.Name;
            rbtnAbility4.Text = Player.Ability4.Name;

            rbtnAbility1.Checked = true;
            rbtnAbility1.Checked = false;
            rbtnAbility1.Checked = false;
            rbtnAbility1.Checked = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (rbtnAbility1.Checked)
            {
                AbilityId = 1;
            }
            else if (rbtnAbility2.Checked)
            {
                AbilityId = 2;
            }
            else if (rbtnAbility3.Checked)
            {
                AbilityId = 3;
            }
            else if (rbtnAbility4.Checked)
            {
                AbilityId = 4;
            }
            Close();
        }
    }
}
