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
    public partial class Stats : Form
    {
        public Player Player;

        public Stats()
        {
            InitializeComponent();
        }
        private void Stats_Load(object sender, EventArgs e)
        {
            lblName.Text = Player.Name;
            lblType.Text = Player.Type;
            lblLevel.Text = $"Level: {Player.Level}"; lblExperience.Text = $"Exp: {Player.Experience}"; lblMoney.Text = $"Money: {Player.Money}";
            lblHP.Text = $"HP: {Player.HitPoints}/{Player.TotalHitPoints}"; lblAbility1.Text = $"Ability1: {Player.Ability1.Name} ({Player.Ability1.Moves}/{Player.Ability1.TotalMoves})";
            lblAttack.Text = $"Atk: {Player.Attack}"; lblAbility2.Text = $"Ability2: {Player.Ability2.Name} ({Player.Ability2.Moves}/{Player.Ability2.TotalMoves})";
            lblDefense.Text = $"Def: {Player.Defense}"; lblAbility3.Text = $"Ability3: {Player.Ability3.Name} ({Player.Ability3.Moves}/{Player.Ability3.TotalMoves})";
            lblSpeed.Text = $"Spd: {Player.Speed}"; lblAbility4.Text = $"Ability4: {Player.Ability4.Name} ({Player.Ability4.Moves}/{Player.Ability4.TotalMoves})";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
