using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldOfMagic
{
    class Messages
    {
        public static bool NewGame()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show("Do you want to start a new game?\nPrevious save-game will be lost.", "New Game", buttons, icon);

            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        public static void NewGameCreated()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBox.Show("New game has been created!", "New Game Created", buttons, icon);
        }

        public static void GameSaved()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Previous save-file overwritten!", "Game Saved", buttons);
        }
        public static void GameLoaded()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Previous save-file loaded!", "Game Loaded", buttons);
        }

        public static void MoneyUp(int money)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show($"You gained {money} money!", "Money Up", buttons);
        }
        public static void ExpUp(int exp)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show($"You gained {exp} experience!", "Experience Up", buttons);
        }
        public static void LvlUp(int lvl)
        {
            string message = $"You leveled to {lvl}!";

            if (lvl == 5 || lvl == 8 || lvl == 12)
            {
                message += "\nYou unlocked a new tier of abilities.";
                message += "\nVisit the Magic Shop to acquire them.";
            }

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, "Level Up", buttons);
        }
        public static void NextMapUnlocked()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show($"Congratulations! You unlocked the next map!\nCheck the hospital to be teleported there.", "Next Map Unlocked", buttons);
        }

        public static void CombatItemUsed(string name)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show($"You used a {name}!\nThe item is lost.", "Item Used", buttons);
        }
        public static void CombatEscapeSucces()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Got away safely!", "Escape Succes", buttons);
        }
        public static void CombatEscapeFailure()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Couldn't get away...", "Escape Failed", buttons);
        }
        public static void CombatOutOfMoves()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Out of moves...\nYou tried to attack, but failed.", "Out of Moves", buttons);
        }

        public static void HospitalHPRestored()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("You got patched up by a nurse.\nHitpoints fully restored!", "HP Restored", buttons);
        }
        public static void HospitalMovesRestored()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("You rested. You feel fit again.\nMove fully restored!", "Moves Restored", buttons);
        }

        public static void ItemPickUpSucces(string name)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show($"You found a {name}!\nYou put the item in your bag.", "Pick Up Succes", buttons);
        }
        public static void ItemPickUpFailure()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Can't pick up the item!\nYou don't have any free slots.", "Pick Up Failed", buttons);
        }
        public static void ItemShopSucces(string name)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show($"You bought a {name}!\nYou put the item in your bag.", "Purchase Succes", buttons);
        }
        public static void ItemShopFailureMoney()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Purchase failed!\nYou don't have enough money.", "Purchase Failed", buttons);
        }
        public static void ItemShopFailureSlots()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Purchase failed!\nYou don't have any free slots.", "Purchase Failed", buttons);
        }

        public static void MagicShopSucces(string name)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show($"{name} learned!\nThe previous ability in this slot is lost.", "Ability Learned", buttons);
        }
        public static void MagicShopFailure()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show($"Could not learn ability!\nYour level is too low.", "Ability Not Learned", buttons);
        }

    }
}
