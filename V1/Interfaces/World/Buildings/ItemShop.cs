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
    public partial class ItemShop : Form
    {
        public Player Player;

        public ItemShop()
        {
            InitializeComponent();
        }
        private void ItemShop_Load(object sender, EventArgs e)
        {
            pcbItem1.Image = Data.ItemImages()[1];
            pcbItem2.Image = Data.ItemImages()[2];
            pcbItem3.Image = Data.ItemImages()[0];

            pcbItem1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbItem2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbItem3.SizeMode = PictureBoxSizeMode.StretchImage;

            btnItem1.Text = $"{Data.Items()[1].Name}\n({Data.Items()[1].Price})";
            btnItem2.Text = $"{Data.Items()[2].Name}\n({Data.Items()[2].Price})";
            btnItem3.Text = $"{Data.Items()[0].Name}\n({Data.Items()[0].Price})";
        }

        private void btnItem1_Click(object sender, EventArgs e)
        {
            Player.BuyItem(1);
        }
        private void btnItem2_Click(object sender, EventArgs e)
        {
            Player.BuyItem(2);
        }
        private void btnItem3_Click(object sender, EventArgs e)
        {
            // COMING SOON
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
