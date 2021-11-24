using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xaml;
using ElementalWar.Classes;
using ElementalWar.Classes.Character;
using ElementalWar.Classes.Data;

namespace ElementalWar.UI
{
    /// <summary>
    /// Interaction logic for Combat.xaml
    /// </summary>
    public partial class Combat : Window
    {
        Player player; Opponent opponent;
        public string state = "Loss";

        public Combat(Player pla, Opponent opp, string oppSort)
        {
            InitializeComponent();

            LoadCharacters(pla, opp);
            LoadUI(oppSort);
        }

        private void LoadCharacters(Player pla, Opponent opp)
        {
            player = pla;
            opponent = opp;
        }

        private void LoadUI(string oppSort)
        {
            LoadData(oppSort);
            LoadLayout();
        }
        private void LoadData(string oppSort)
        {
            lblOppName.Content = $"{opponent.Name} - {opponent.Type}";
            lblOppLevel.Content = $"Lvl {opponent.Level}";
            lblOppHitpoints.Content = $"{opponent.HitPoints}/{opponent.TotalHitPoints} HP";
            switch (oppSort)
            {
                case "Boss":
                    imgOpp.Source = Images.OpponentImages()[0].Source;
                    break;
                case "Fixed":
                    imgOpp.Source = Images.OpponentImages()[1].Source;
                    break;
                case "Random":
                    imgOpp.Source = Images.OpponentImages()[6].Source;
                    break;
                default:
                    break;
            }
            imgOpp.Stretch = Stretch.Fill;

            lblPlayerName.Content = $"{player.Name} - {player.Type}";
            lblPlayerLevel.Content = $"Lvl {player.Level}";
            lblPlayerHitpoints.Content = $"{player.HitPoints}/{player.TotalHitPoints} HP";
            imgPlayer.Source = Images.PlayerImages()[0].Source;
            imgPlayer.Stretch = Stretch.Fill;

            btnAbility1.Content = player.Ability1.Name;
            btnAbility2.Content = player.Ability2.Name;
            btnAbility3.Content = player.Ability3.Name;
            btnAbility4.Content = player.Ability4.Name;

            btnItem1.Content = player.Item1.Name;
            btnItem2.Content = player.Item2.Name;
            btnItem3.Content = player.Item3.Name;

            btnEscape.Content = "Escape";
        }
        private void LoadLayout()
        {
            // Opponent Region [0,0]-[150,300]
            Canvas.SetTop(lblOppName, 5); Canvas.SetLeft(lblOppName, 5);
            Canvas.SetTop(lblOppLevel, 25); Canvas.SetLeft(lblOppLevel, 5);
            Canvas.SetTop(lblOppHitpoints, 75); Canvas.SetLeft(lblOppHitpoints, 5);
            Canvas.SetTop(imgOpp, 0); Canvas.SetRight(imgOpp, 0);

            // ResultText Region [150, 0]-[175, 300]
            Canvas.SetTop(txtResult, 150);

            // Player Region [175, 0]-[325, 300]
            Canvas.SetTop(lblPlayerName, 180); Canvas.SetRight(lblPlayerName, 5); 
            Canvas.SetTop(lblPlayerLevel, 200); Canvas.SetRight(lblPlayerLevel, 5);
            Canvas.SetTop(lblPlayerHitpoints, 250); Canvas.SetRight(lblPlayerHitpoints, 5);
            Canvas.SetTop(imgPlayer, 175); Canvas.SetLeft(imgPlayer, 0);

            // Controls Region [325, 0]-[400, 300]
            Canvas.SetBottom(btnAbility1, 55); Canvas.SetLeft(btnAbility1, 5);
            Canvas.SetBottom(btnAbility2, 55); Canvas.SetRight(btnAbility2, 5);
            Canvas.SetBottom(btnAbility3, 30); Canvas.SetLeft(btnAbility3, 5);
            Canvas.SetBottom(btnAbility4, 30); Canvas.SetRight(btnAbility4, 5); 

            Canvas.SetBottom(btnItem1, 5); Canvas.SetLeft(btnItem1, 5);
            Canvas.SetBottom(btnItem2, 5); Canvas.SetLeft(btnItem2, 55);
            Canvas.SetBottom(btnItem3, 5); Canvas.SetLeft(btnItem3, 105);

            Canvas.SetBottom(btnEscape, 5); Canvas.SetRight(btnEscape, 5);
        }

        private void Ability1()
        {
            CombatData cd = new CombatData();
            cd.PlayerType = player.Type;
            cd.PlayerAttack = player.Attack;
            cd.PlayerSpeed = player.Speed;
            cd.OpponentType = opponent.Type;
            cd.OpponentDefense = opponent.Defense;
            cd.OpponentSpeed = opponent.Speed;

            player.UseAbility(1, cd);
        }

        private void btnAbility1_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Ability1();
        }

        private void btnAbility1_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
