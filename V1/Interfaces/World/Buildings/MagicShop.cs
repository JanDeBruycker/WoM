using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WorldOfMagic
{
    public partial class MagicShop : Form
    {
        public Player Player;

        public MagicShop()
        {
            InitializeComponent();
        }
        private void MagicShop_Load(object sender, EventArgs e)
        {
            btnAbility1.Text = $"{Data.Abilities()[5].Name}\n(Lvl {Data.Abilities()[5].RequiredLevel})";
            btnAbility2.Text = $"{Data.Abilities()[6].Name}\n(Lvl {Data.Abilities()[6].RequiredLevel})";
            btnAbility3.Text = $"{Data.Abilities()[7].Name}\n(Lvl {Data.Abilities()[7].RequiredLevel})";
            btnAbility4.Text = $"{Data.Abilities()[8].Name}\n(Lvl {Data.Abilities()[8].RequiredLevel})";
            btnAbility5.Text = $"{Data.Abilities()[9].Name}\n(Lvl {Data.Abilities()[9].RequiredLevel})";
            btnAbility6.Text = $"{Data.Abilities()[10].Name}\n(Lvl {Data.Abilities()[10].RequiredLevel})";
            btnAbility7.Text = $"{Data.Abilities()[11].Name}\n(Lvl {Data.Abilities()[11].RequiredLevel})";
            btnAbility8.Text = $"{Data.Abilities()[12].Name}\n(Lvl {Data.Abilities()[12].RequiredLevel})";
            btnAbility9.Text = $"{Data.Abilities()[13].Name}\n(Lvl {Data.Abilities()[13].RequiredLevel})";
            btnAbility10.Text = $"{Data.Abilities()[14].Name}\n(Lvl {Data.Abilities()[14].RequiredLevel})";
        }

        private void AssignNewAbility(int id)
        {
            Player.BuyAbility(id);
        }

        private void btnAbility1_Click(object sender, EventArgs e)
        {
            AssignNewAbility(5);
        }
        private void btnAbility2_Click(object sender, EventArgs e)
        {
            AssignNewAbility(6);
        }
        private void btnAbility3_Click(object sender, EventArgs e)
        {
            AssignNewAbility(7);
        }
        private void btnAbility4_Click(object sender, EventArgs e)
        {
            AssignNewAbility(8);
        }
        private void btnAbility5_Click(object sender, EventArgs e)
        {
            AssignNewAbility(9);
        }
        private void btnAbility6_Click(object sender, EventArgs e)
        {
            AssignNewAbility(10);
        }
        private void btnAbility7_Click(object sender, EventArgs e)
        {
            AssignNewAbility(11);
        }
        private void btnAbility8_Click(object sender, EventArgs e)
        {
            AssignNewAbility(12);
        }
        private void btnAbility9_Click(object sender, EventArgs e)
        {
            AssignNewAbility(13);
        }
        private void Ability10_Click(object sender, EventArgs e)
        {
            AssignNewAbility(14);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
