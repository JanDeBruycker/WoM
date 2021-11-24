using System;
using System.Drawing;
using System.Windows.Forms;
using WorldOfMagic.Classes;

namespace WorldOfMagic
{
    public partial class InterfaceCombat : Form
    {
        public string State = "LOSS";
        bool PlayerTurn; string Action = "";

        string SpeechSender; string SpeechText; int SpeechIndex = 0;

        public Player Player; Opponent Opp;
        public int CpuId; public string CpuType;

        public InterfaceCombat()
        {
            InitializeComponent();
        }
        private void InterfaceCombat_Load(object sender, EventArgs e)
        {
            pcbPlayerImg.Image = Data.PlayerImages()[12];

            switch (CpuType)
            {
                case "BOSS":
                    Opp = DataControl.LoadOpponents(Player.MapId)[CpuId];
                    pcbOppImg.Image = Data.OpponentImages()[2];
                    break;
                case "FIXED":
                    Opp = DataControl.LoadOpponents(Player.MapId)[CpuId];
                    pcbOppImg.Image = Data.OpponentImages()[13];
                    break;
                case "RANDOM":
                    Opp = Data.RandomOpponents()[CpuId];
                    pcbOppImg.Image = Data.OpponentImages()[14];
                    break;
                default:
                    break;
            }

            btnAbility1.Text = Player.Ability1.Name;
            btnAbility2.Text = Player.Ability2.Name;
            btnAbility3.Text = Player.Ability3.Name;
            btnAbility4.Text = Player.Ability4.Name;

            pcbItem1.Image = Data.ItemImages()[Player.Item1.Id + 3];
            pcbItem2.Image = Data.ItemImages()[Player.Item2.Id + 3];
            pcbItem3.Image = Data.ItemImages()[Player.Item3.Id + 3];

            btnAbility1.Enabled = false; btnAbility2.Enabled = false;
            btnAbility3.Enabled = false; btnAbility4.Enabled = false;
            btnEscape.Enabled = false; btnCPUAttack.Enabled = false;
            txtAction.Enabled = false;

            pcbPlayerImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbOppImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbItem1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbItem2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbItem3.SizeMode = PictureBoxSizeMode.StretchImage;

            txtAction.Text = "SELECT AN ABILITY";

            PlayerTurn = GetFirstPlayer();

            if (PlayerTurn && CpuType != "RANDOM")
            {
                InitiateSpeech(0); // Initiate Speech, Turn to Player
            }
            else if (CpuType != "RANDOM")
            {
                SpeechSender = "Opponent"; // Delays Opp's First Atk
                InitiateSpeech(0); // Initiate Speech, Turn to Opponent
            }
            else if (PlayerTurn)
            {
                btnAbility1.BackColor = Color.Gray; // No Speech, Turn to Player
            }
            else
            {
                CpuAttack(); // No Speech, Turn to Opponent
            }

            UpdateInterface();
        }
        private void InterfaceCombat_KeyDown(object sender, KeyEventArgs e)
        {
            SelectionKeys(e);
        }

        // Flow
        private void UpdateInterface()
        {
            lblPlayerName.Text = $"{Player.Name} - {Player.Type}"; 
            lblPlayerLevel.Text = $"Lvl {Player.Level}";
            lblPlayerHP.Text = $"HP: {Player.HitPoints}/{Player.TotalHitPoints}";

            if (CpuType == "RANDOM")
            {
                lblCPUName.Text = $"{Opp.Name} - {Opp.Type}";
            }
            else
            {
                lblCPUName.Text = Opp.Name;
            }
            
            lblCPULevel.Text = $"Lvl {Opp.Level}";
            lblCPUHP.Text = $"HP: {Opp.HitPoints}/{Opp.TotalHitPoints}";

            txtAction.Text = Action;
        }
        private bool GetFirstPlayer()
        {
            if (Player.Speed < Opp.Speed)
            {
                return false;
            }
            return true;
        }

        // Controls
        private void SelectionKeys(KeyEventArgs e)
        {
            if (!tmrPlayerAnimation.Enabled && !tmrOpponentAnimation.Enabled)
            {
                if (btnAbility1.BackColor == Color.Gray)
                {
                    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                    {
                        SelectedAbility(1);
                        btnAbility1.BackColor = Color.White;
                    }
                    else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                    {
                        btnAbility1.BackColor = Color.White;
                        btnAbility3.BackColor = Color.Gray;
                    }
                    else if (e.KeyCode == Keys.Q || e.KeyCode == Keys.Left)
                    {
                        btnAbility1.BackColor = Color.White;
                        pcbItem3.BackColor = Color.Gray;
                        if (Player.Item3.Id == 0)
                        {
                            pcbItem3.Image = Properties.Resources.ItemEmptySelected;
                        }
                        else if (Player.Item3.Id == 1)
                        {
                            pcbItem3.Image = Properties.Resources.ItemPotionSelected;
                        }
                        else if (Player.Item3.Id == 2)
                        {
                            pcbItem3.Image = Properties.Resources.ItemRuneSelected;
                        }
                    }
                    else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                    {
                        btnAbility1.BackColor = Color.White;
                        btnAbility2.BackColor = Color.Gray;
                    }
                }
                else if (btnAbility2.BackColor == Color.Gray)
                {
                    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                    {
                        SelectedAbility(2);
                        btnAbility2.BackColor = Color.White;
                    }
                    else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                    {
                        btnAbility2.BackColor = Color.White;
                        btnAbility4.BackColor = Color.Gray;
                    }
                    else if (e.KeyCode == Keys.Q || e.KeyCode == Keys.Left)
                    {
                        btnAbility2.BackColor = Color.White;
                        btnAbility1.BackColor = Color.Gray;
                    }
                }
                else if (btnAbility3.BackColor == Color.Gray)
                {
                    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                    {
                        SelectedAbility(3);
                        btnAbility3.BackColor = Color.White;
                    }
                    else if (e.KeyCode == Keys.Z || e.KeyCode == Keys.Up)
                    {
                        btnAbility3.BackColor = Color.White;
                        btnAbility1.BackColor = Color.Gray;
                    }
                    else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                    {
                        btnAbility3.BackColor = Color.White;
                        btnEscape.BackColor = Color.Gray;
                    }
                    else if (e.KeyCode == Keys.Q || e.KeyCode == Keys.Left)
                    {
                        btnAbility3.BackColor = Color.White;
                        pcbItem3.BackColor = Color.Gray;
                        if (Player.Item3.Id == 0)
                        {
                            pcbItem3.Image = Properties.Resources.ItemEmptySelected;
                        }
                        else if (Player.Item3.Id == 1)
                        {
                            pcbItem3.Image = Properties.Resources.ItemPotionSelected;
                        }
                        else if (Player.Item3.Id == 2)
                        {
                            pcbItem3.Image = Properties.Resources.ItemRuneSelected;
                        }
                    }
                    else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                    {
                        btnAbility3.BackColor = Color.White;
                        btnAbility4.BackColor = Color.Gray;
                    }
                }
                else if (btnAbility4.BackColor == Color.Gray)
                {
                    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                    {
                        SelectedAbility(4);
                        btnAbility4.BackColor = Color.White;
                    }
                    else if (e.KeyCode == Keys.Z || e.KeyCode == Keys.Up)
                    {
                        btnAbility4.BackColor = Color.White;
                        btnAbility2.BackColor = Color.Gray;
                    }
                    else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                    {
                        btnAbility4.BackColor = Color.White;
                        btnEscape.BackColor = Color.Gray;
                    }
                    else if (e.KeyCode == Keys.Q || e.KeyCode == Keys.Left)
                    {
                        btnAbility4.BackColor = Color.White;
                        btnAbility3.BackColor = Color.Gray;
                    }
                }
                else if (pcbItem1.BackColor == Color.Gray)
                {
                    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                    {
                        SelectedItem(1);
                        pcbItem1.BackColor = Color.White;
                        if (Player.Item1.Id == 0)
                        {
                            pcbItem1.Image = Properties.Resources.ItemEmptyUnselected;
                        }
                        else if (Player.Item1.Id == 1)
                        {
                            pcbItem1.Image = Properties.Resources.ItemPotionUnselected;
                        }
                        else if (Player.Item1.Id == 2)
                        {
                            pcbItem1.Image = Properties.Resources.ItemRuneUnselected;
                        }
                    }
                    else if (e.KeyCode == Keys.Z || e.KeyCode == Keys.Up)
                    {
                        pcbItem1.BackColor = Color.White;
                        if (Player.Item1.Id == 0)
                        {
                            pcbItem1.Image = Properties.Resources.ItemEmptyUnselected;
                        }
                        else if (Player.Item1.Id == 1)
                        {
                            pcbItem1.Image = Properties.Resources.ItemPotionUnselected;
                        }
                        else if (Player.Item1.Id == 2)
                        {
                            pcbItem1.Image = Properties.Resources.ItemRuneUnselected;
                        }
                        btnAbility3.BackColor = Color.Gray;
                    }
                    else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                    {
                        pcbItem1.BackColor = Color.White;
                        if (Player.Item1.Id == 0)
                        {
                            pcbItem1.Image = Properties.Resources.ItemEmptyUnselected;
                        }
                        else if (Player.Item1.Id == 1)
                        {
                            pcbItem1.Image = Properties.Resources.ItemPotionUnselected;
                        }
                        else if (Player.Item1.Id == 2)
                        {
                            pcbItem1.Image = Properties.Resources.ItemRuneUnselected;
                        }
                        pcbItem2.BackColor = Color.Gray;
                        if (Player.Item2.Id == 0)
                        {
                            pcbItem2.Image = Properties.Resources.ItemEmptySelected;
                        }
                        else if (Player.Item2.Id == 1)
                        {
                            pcbItem2.Image = Properties.Resources.ItemPotionSelected;
                        }
                        else if (Player.Item2.Id == 2)
                        {
                            pcbItem2.Image = Properties.Resources.ItemRuneSelected;
                        }
                    }
                }
                else if (pcbItem2.BackColor == Color.Gray)
                {
                    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                    {
                        SelectedItem(2);
                        pcbItem2.BackColor = Color.White;

                        if (Player.Item2.Id == 0)
                        {
                            pcbItem2.Image = Properties.Resources.ItemEmptyUnselected;
                        }
                        else if (Player.Item2.Id == 1)
                        {
                            pcbItem2.Image = Properties.Resources.ItemPotionUnselected;
                        }
                        else if (Player.Item2.Id == 2)
                        {
                            pcbItem2.Image = Properties.Resources.ItemRuneUnselected;
                        }
                    }
                    else if (e.KeyCode == Keys.Z || e.KeyCode == Keys.Up)
                    {
                        pcbItem2.BackColor = Color.White;
                        if (Player.Item2.Id == 0)
                        {
                            pcbItem2.Image = Properties.Resources.ItemEmptyUnselected;
                        }
                        else if (Player.Item2.Id == 1)
                        {
                            pcbItem2.Image = Properties.Resources.ItemPotionUnselected;
                        }
                        else if (Player.Item2.Id == 2)
                        {
                            pcbItem2.Image = Properties.Resources.ItemRuneUnselected;
                        }
                        btnAbility3.BackColor = Color.Gray;
                    }
                    else if (e.KeyCode == Keys.Q || e.KeyCode == Keys.Left)
                    {
                        pcbItem2.BackColor = Color.White;
                        if (Player.Item2.Id == 0)
                        {
                            pcbItem2.Image = Properties.Resources.ItemEmptyUnselected;
                        }
                        else if (Player.Item2.Id == 1)
                        {
                            pcbItem2.Image = Properties.Resources.ItemPotionUnselected;
                        }
                        else if (Player.Item2.Id == 2)
                        {
                            pcbItem2.Image = Properties.Resources.ItemRuneUnselected;
                        }
                        pcbItem1.BackColor = Color.Gray;
                        if (Player.Item1.Id == 0)
                        {
                            pcbItem1.Image = Properties.Resources.ItemEmptySelected;
                        }
                        else if (Player.Item1.Id == 1)
                        {
                            pcbItem1.Image = Properties.Resources.ItemPotionSelected;
                        }
                        else if (Player.Item1.Id == 2)
                        {
                            pcbItem1.Image = Properties.Resources.ItemRuneSelected;
                        }
                    }
                    else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                    {
                        pcbItem2.BackColor = Color.White;
                        if (Player.Item2.Id == 0)
                        {
                            pcbItem2.Image = Properties.Resources.ItemEmptyUnselected;
                        }
                        else if (Player.Item2.Id == 1)
                        {
                            pcbItem2.Image = Properties.Resources.ItemPotionUnselected;
                        }
                        else if (Player.Item2.Id == 2)
                        {
                            pcbItem2.Image = Properties.Resources.ItemRuneUnselected;
                        }
                        pcbItem3.BackColor = Color.Gray;
                        if (Player.Item3.Id == 0)
                        {
                            pcbItem3.Image = Properties.Resources.ItemEmptySelected;
                        }
                        else if (Player.Item3.Id == 1)
                        {
                            pcbItem3.Image = Properties.Resources.ItemPotionSelected;
                        }
                        else if (Player.Item3.Id == 2)
                        {
                            pcbItem3.Image = Properties.Resources.ItemRuneSelected;
                        }
                    }
                }
                else if (pcbItem3.BackColor == Color.Gray)
                {
                    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                    {
                        SelectedItem(3);
                        pcbItem3.BackColor = Color.White;

                        if (Player.Item3.Id == 0)
                        {
                            pcbItem3.Image = Properties.Resources.ItemEmptyUnselected;
                        }
                        else if (Player.Item3.Id == 1)
                        {
                            pcbItem3.Image = Properties.Resources.ItemPotionUnselected;
                        }
                        else if (Player.Item3.Id == 2)
                        {
                            pcbItem3.Image = Properties.Resources.ItemRuneUnselected;
                        }
                    }
                    else if (e.KeyCode == Keys.Q || e.KeyCode == Keys.Left)
                    {
                        pcbItem3.BackColor = Color.White;
                        if (Player.Item3.Id == 0)
                        {
                            pcbItem3.Image = Properties.Resources.ItemEmptyUnselected;
                        }
                        else if (Player.Item3.Id == 1)
                        {
                            pcbItem3.Image = Properties.Resources.ItemPotionUnselected;
                        }
                        else if (Player.Item3.Id == 2)
                        {
                            pcbItem3.Image = Properties.Resources.ItemRuneUnselected;
                        }
                        pcbItem2.BackColor = Color.Gray;
                        if (Player.Item2.Id == 0)
                        {
                            pcbItem2.Image = Properties.Resources.ItemEmptySelected;
                        }
                        else if (Player.Item2.Id == 1)
                        {
                            pcbItem2.Image = Properties.Resources.ItemPotionSelected;
                        }
                        else if (Player.Item2.Id == 2)
                        {
                            pcbItem2.Image = Properties.Resources.ItemRuneSelected;
                        }
                    }
                    else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                    {
                        pcbItem3.BackColor = Color.White;
                        if (Player.Item3.Id == 0)
                        {
                            pcbItem3.Image = Properties.Resources.ItemEmptyUnselected;
                        }
                        else if (Player.Item3.Id == 1)
                        {
                            pcbItem3.Image = Properties.Resources.ItemPotionUnselected;
                        }
                        else if (Player.Item3.Id == 2)
                        {
                            pcbItem3.Image = Properties.Resources.ItemRuneUnselected;
                        }
                        btnAbility3.BackColor = Color.Gray;
                    }
                }
                else if (btnEscape.BackColor == Color.Gray)
                {
                    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                    {
                        Escape();
                        btnEscape.BackColor = Color.White;
                    }
                    else if (e.KeyCode == Keys.Z || e.KeyCode == Keys.Up)
                    {
                        btnEscape.BackColor = Color.White;
                        btnAbility4.BackColor = Color.Gray;
                    }
                    else if (e.KeyCode == Keys.Q || e.KeyCode == Keys.Left)
                    {
                        btnEscape.BackColor = Color.White;
                        pcbItem3.BackColor = Color.Gray;
                        if (Player.Item3.Id == 0)
                        {
                            pcbItem3.Image = Properties.Resources.ItemEmptySelected;
                        }
                        else if (Player.Item3.Id == 1)
                        {
                            pcbItem3.Image = Properties.Resources.ItemPotionSelected;
                        }
                        else if (Player.Item3.Id == 2)
                        {
                            pcbItem3.Image = Properties.Resources.ItemRuneSelected;
                        }
                    }
                }
            }
        }
        private void SelectedAbility(int number)
        {
            int abilityId = 0;
            switch (number)
            {
                case 1:
                    abilityId = Player.Ability1.Id;
                    break;
                case 2:
                    abilityId = Player.Ability2.Id;
                    break;
                case 3:
                    abilityId = Player.Ability3.Id;
                    break;
                case 4:
                    abilityId = Player.Ability4.Id;
                    break;
                default:
                    break;
            }

            CombatData data = new CombatData();
            data.OpponentType = Opp.Type;
            data.OpponentAttack = Opp.Attack;
            data.OpponentDefense = Opp.Defense;
            data.OpponentSpeed = Opp.Speed;

            CombatData result = Player.UseAbility(number, data);

            if (result.AbilityType != "NoType" || result.AbilityType != "Healing")
            {
                Opp.HitPoints -= result.AbilityDamage;
            }
            else if (result.AbilityType == "Healing")
            {
                Player.HitPoints += result.AbilityHealing;
            }

            TextResult(result);

            AnimatePlayerAbility(abilityId);
            UpdateInterface();
        }
        private void SelectedItem(int number)
        {
            int itemId = 0;
            switch (number)
            {
                case 1:
                    itemId = Player.Item1.Id;
                    break;
                case 2:
                    itemId = Player.Item2.Id;
                    break;
                case 3:
                    itemId = Player.Item3.Id;
                    break;
                default:
                    break;
            }

            CombatData data = new CombatData();
            data.OpponentType = Opp.Type;

            CombatData result = Player.UseItem(number, data);

            if (result.ItemType == "Potion")
            {
                Player.HitPoints += result.ItemHealing;
                if (Player.HitPoints > Player.TotalHitPoints)
                {
                    Player.HitPoints = Player.TotalHitPoints;
                }
            }
            else if (result.ItemType == "Rune")
            {
                Opp.HitPoints -= result.ItemDamage;
            }

            TextResult(result);

            AnimatePlayerItem(itemId);
            UpdateInterface();
        }
        private void CpuAttack()
        {
            int maxVal = 5;
            if (Opp.Ability4.Id == 0)
            {
                maxVal = 4;
            }
            if (Opp.Ability3.Id == 0)
            {
                maxVal = 3;
            }
            if (Opp.Ability2.Id == 0)
            {
                maxVal = 2;
            }

            Random rnd = new Random();
            int abilityNumber = rnd.Next(1, maxVal);

            int abilityId = 0;
            switch (abilityNumber)
            {
                case 1:
                    abilityId = Opp.Ability1.Id;
                    break;
                case 2:
                    abilityId = Opp.Ability2.Id;
                    break;
                case 3:
                    abilityId = Opp.Ability3.Id;
                    break;
                case 4:
                    abilityId = Opp.Ability4.Id;
                    break;
                default:
                    break;
            }

            CombatData data = new CombatData();
            data.OpponentType = Player.Type;
            data.OpponentAttack = Player.Attack;
            data.OpponentDefense = Player.Defense;
            data.OpponentSpeed = Player.Speed;

            CombatData result = Opp.UseAbility(abilityNumber, data);

            if (result.AbilityType != "NoType" || result.AbilityType != "Healing")
            {
                Player.HitPoints -= result.AbilityDamage;
            }
            else if (result.AbilityType == "Healing")
            {
                Opp.HitPoints += result.AbilityHealing;
            }

            TextResult(result);
            AnimateOpponentAbility(abilityId);

            UpdateInterface();
        }

        // Turn Result
        private void TextResult(CombatData cd)
        {
            if (cd.AbilityType == "NoType")
            {
                Action = $"{cd.AbilityName}: NOTHING HAPPENED";
            }
            else if (cd.AbilityType != "NoType" && cd.AbilityType != "Healing" && cd.AbilityType != "Miss")
            {
                Action = $"{cd.AbilityName}: HIT ({cd.AbilityDamage} {cd.AbilityType} DMG)";
            }
            else if (cd.AbilityType == "Healing")
            {
                Action = $"{cd.AbilityName}: RESTORED {cd.AbilityHealing} HP)";
            }
            else
            {
                Action = $"{cd.AbilityName}: MISS!";
            }

            if (cd.ItemType == "Potion")
            {
                Action = $"{cd.ItemName}: RESTORED {cd.ItemHealing} HP.";
            }
            else if (cd.ItemType == "Rune")
            {
                Action = $"{cd.ItemName}: HIT ({cd.ItemDamage} DMG)";
            }
        }

        // Calculations
        private void Escape()
        {
            if (CpuType == "RANDOM")
            {
                if (Player.Escape())
                {
                    EndCombat("ESCAPE");
                }
                else
                {
                    AnimatePlayerAbility(0); // TEMP
                    UpdateInterface();
                }
            }
            else
            {
                Messages.CombatEscapeFailure();
                AnimatePlayerAbility(0); // TEMP
                UpdateInterface();
            }
        }
        private void CheckWinConditions()
        {
            if (Opp.HitPoints <= 0)
            {
                EndCombat("WIN");
            }
            else if (Player.HitPoints <= 0)
            {
                EndCombat("LOSS");
            }
        }
        private void EndCombat(string state)
        {
            State = state;
            Player.HitPoints = Player.HitPoints;

            if (State == "WIN")
            {
                Opp.ChangeStatus();
                if (CpuType != "RANDOM")
                {
                    InitiateSpeech(1);
                    Player.GainMoney(Opp.Level);
                }

                Player.GainExp(Opp.Level);
            }

            // Close CombatInterface
            Close();
        }

        // Animations
        private void AnimatePlayerAbility(int abilityId)
        {
            pcbAnimation.Visible = true;
            pcbAnimation.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAnimation.Location = new Point(pcbPlayerImg.Location.X + pcbPlayerImg.Size.Width / 2, pcbPlayerImg.Location.Y + pcbPlayerImg.Size.Height / 4);

            pcbAnimation.Image = Data.AbilityImages()[abilityId];
            if (abilityId < 3)
            {
                pcbAnimation.Visible = false;
            }

            pcbAnimation.BringToFront();

            tmrPlayerAnimation.Enabled = true;
            tmrPlayerAnimation.Start();
        }
        private void AnimatePlayerItem(int itemId)
        {
            pcbAnimation.Visible = true;
            pcbAnimation.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAnimation.Location = new Point(pcbPlayerImg.Location.X + pcbPlayerImg.Size.Width / 2, pcbPlayerImg.Location.Y + pcbPlayerImg.Size.Height / 4);

            pcbAnimation.Image = Data.ItemImages()[itemId];
            if (itemId < 2)
            {
                pcbAnimation.Visible = false;
            }

            pcbAnimation.BringToFront();

            tmrPlayerAnimation.Enabled = true;
            tmrPlayerAnimation.Start();
        }
        private void AnimateOpponentAbility(int abilityId)
        {
            pcbAnimation.Visible = true;
            pcbAnimation.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAnimation.Location = new Point(pcbOppImg.Location.X + pcbOppImg.Size.Width / 2 - 12, pcbOppImg.Location.Y + pcbOppImg.Size.Height / 2);

            pcbAnimation.Image = Data.AbilityImages()[abilityId];
            if (abilityId < 3)
            {
                pcbAnimation.Visible = false;
            }

            pcbAnimation.BringToFront();

            tmrOpponentAnimation.Enabled = true;
            tmrOpponentAnimation.Start();
        }
        private void RunPlayerAnimation()
        {
            pcbAnimation.Location = new Point(pcbAnimation.Location.X + 4, pcbAnimation.Location.Y - 3);

            if (pcbAnimation.Location.X > pcbOppImg.Location.X + pcbOppImg.Size.Width / 4)
            {
                pcbAnimation.Location = new Point(-50, -50);

                tmrPlayerAnimation.Stop();
                tmrPlayerAnimation.Enabled = false;

                // Set OpponentTurn (AUTO)
                CheckWinConditions();
                if (State != "WIN")
                {
                    CpuAttack();
                }
            }
        }
        private void RunOpponentAnimation()
        {
            pcbAnimation.Location = new Point(pcbAnimation.Location.X - 4, pcbAnimation.Location.Y + 3);

            if (pcbAnimation.Location.X < pcbPlayerImg.Location.X + pcbPlayerImg.Size.Width / 2 - 10)
            {
                pcbAnimation.Location = new Point(-50, -50);

                tmrOpponentAnimation.Stop();
                tmrOpponentAnimation.Enabled = false;

                // Set PlayerTurn
                CheckWinConditions();
                btnAbility1.BackColor = Color.Gray;
            }
        }
        private void tmrPlayerAnimation_Tick(object sender, EventArgs e)
        {
            RunPlayerAnimation();
        }
        private void tmrOpponentAnimation_Tick(object sender, EventArgs e)
        {
            RunOpponentAnimation();
        }

        // Speech
        private void InitiateSpeech(int part)
        {
            if (part == 0)
            {
                SpeechText = Data.Speech(Player.MapId)[CpuId].Begin;
            }
            else
            {
                SpeechText = Data.Speech(Player.MapId)[CpuId].End;
            }

            txtAction.Text = "";

            tmrSpeech.Enabled = true;
            tmrSpeech.Start();
        }
        private void Speech()
        {
            txtAction.Text += SpeechText.Substring(SpeechIndex, 1);

            if (SpeechIndex == SpeechText.Length - 1)
            {
                SpeechIndex = 0;

                tmrSpeech.Stop();
                tmrSpeech.Enabled = false;

                if (SpeechSender == "Opponent")
                {
                    SpeechSender = "";
                    CpuAttack();
                }
                else
                {
                    btnAbility1.BackColor = Color.Gray;
                }
            }
            else
            {
                SpeechIndex++;
            }
        }
        private void tmrSpeech_Tick(object sender, EventArgs e)
        {
            Speech();
        }

    }
}
