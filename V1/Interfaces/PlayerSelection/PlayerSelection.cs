using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WorldOfMagic.Interfaces.PlayerSelection;

namespace WorldOfMagic
{
    public partial class PlayerSelection : Form
    {
        Player Player = new Player();
        
        public PlayerSelection()
        {
            InitializeComponent();
        }
        private void PlayerSelection_Load(object sender, EventArgs e)
        {
            UpdateInterface();
        }
        private void UpdateInterface()
        {
            string dir = @"C:\WoM\";
            string path = @"C:\WoM\player.txt";

            if (Directory.Exists(dir) && File.Exists(path))
            {
                Player = DataControl.LoadPlayer();

                gpbPlayer.Text = "Current Game";
                txtPlayerName.Text = Player.Name;
                txtPlayerLevel.Text = $"{Player.Level}";
                txtPlayerExperience.Text = $"{Player.Experience}";
                btnPlay.Enabled = true;
                btnPlay.Focus();
            }
            else
            {
                gpbPlayer.Text = "Current Game";
                txtPlayerName.Text = "";
                txtPlayerLevel.Text = "";
                txtPlayerExperience.Text = "";
                btnPlay.Enabled = false;
                btnNewGame.Focus();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Hide();
            Player.Play();

            Close();
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            PlayerTypeSelection typeSelector = new PlayerTypeSelection();
            typeSelector.ShowDialog();

            if (Messages.NewGame())
            {
                Player.NewGame(typeSelector.Type);            
            }
            UpdateInterface();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            // TO BE EDITED ...

            string info = "Game is saved everytime you go to another zone.";
            
            MessageBox.Show(info);
        }
    }
}
