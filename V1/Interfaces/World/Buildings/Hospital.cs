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
    public partial class Hospital : Form
    {
        public Player Player;

        public Hospital()
        {
            InitializeComponent();
        }
        private void Hospital_Load(object sender, EventArgs e)
        {

        }

        private void btnRestoreHP_Click(object sender, EventArgs e)
        {
            Player.HitPoints = Player.TotalHitPoints;
            
            Messages.HospitalHPRestored();
        }
        private void btnRestoreMoves_Click(object sender, EventArgs e)
        {
            Player.Ability1.Moves = Player.Ability1.TotalMoves;
            Player.Ability2.Moves = Player.Ability2.TotalMoves;
            Player.Ability3.Moves = Player.Ability3.TotalMoves;
            Player.Ability4.Moves = Player.Ability4.TotalMoves;

            Messages.HospitalMovesRestored();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
