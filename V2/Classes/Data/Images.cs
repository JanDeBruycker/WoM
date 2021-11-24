using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ElementalWar.Classes.Data
{
    class Images
    {
        public static List<Image> FieldImages()
        {
            List<Image> items = new List<Image>();

            Image img0 = new Image();
            img0.Name = "Dirt";
            img0.Source = new BitmapImage(new Uri(@"C:\EW\Images\Field\Dirt.png"));
            img0.Stretch = Stretch.Fill;
            items.Add(img0);

            Image img1 = new Image();
            img1.Name = "Grass";
            img1.Source = new BitmapImage(new Uri(@"C:\EW\Images\Field\Grass.png"));
            img1.Stretch = Stretch.Fill;
            items.Add(img1);

            Image img2 = new Image();
            img2.Name = "Road";
            img2.Source = new BitmapImage(new Uri(@"C:\EW\Images\Field\Road.png"));
            img2.Stretch = Stretch.Fill;
            items.Add(img2);

            Image img3 = new Image();
            img3.Name = "Wall";
            img3.Source = new BitmapImage(new Uri(@"C:\EW\Images\Field\Wall.png"));
            img3.Stretch = Stretch.Fill;
            items.Add(img3);

            Image img4 = new Image();
            img4.Name = "Portal";
            img4.Source = new BitmapImage(new Uri(@"C:\EW\Images\Field\Portal.png"));
            img4.Stretch = Stretch.Fill;
            items.Add(img4);

            return items;
        }
        public static List<Image> PlayerImages()
        {
            List<Image> items = new List<Image>();

            Image img0 = new Image();
            img0.Name = "Up";
            img0.Source = new BitmapImage(new Uri(@"C:\EW\Images\Character\Player\Up.png"));
            img0.Stretch = Stretch.Fill;
            items.Add(img0);

            Image img1 = new Image();
            img1.Name = "Down";
            img1.Source = new BitmapImage(new Uri(@"C:\EW\Images\Character\Player\Down.png"));
            img1.Stretch = Stretch.Fill;
            items.Add(img1);

            Image img2 = new Image();
            img2.Name = "Left";
            img2.Source = new BitmapImage(new Uri(@"C:\EW\Images\Character\Player\Left.png"));
            img2.Stretch = Stretch.Fill;
            items.Add(img2);

            Image img3 = new Image();
            img3.Name = "Right";
            img3.Source = new BitmapImage(new Uri(@"C:\EW\Images\Character\Player\Right.png"));
            img3.Stretch = Stretch.Fill;
            items.Add(img3);

            return items;
        }
        public static List<Image> OpponentImages()
        {
            List<Image> items = new List<Image>();

            Image img0 = new Image();
            img0.Name = "Boss";
            img0.Source = new BitmapImage(new Uri(@"C:\EW\Images\Character\Opponent\Boss.png"));
            img0.Stretch = Stretch.Fill;
            items.Add(img0);

            Image img1 = new Image();
            img1.Name = "Fixed";
            img1.Source = new BitmapImage(new Uri(@"C:\EW\Images\Character\Opponent\Fixed.png"));
            img1.Stretch = Stretch.Fill;
            items.Add(img1);

            Image img2 = new Image();
            img2.Name = "Fixed_Up";
            img2.Source = new BitmapImage(new Uri(@"C:\EW\Images\Character\Opponent\Fixed_Up.png"));
            img2.Stretch = Stretch.Fill;
            items.Add(img2);

            Image img3 = new Image();
            img3.Name = "Fixed_Down";
            img3.Source = new BitmapImage(new Uri(@"C:\EW\Images\Character\Opponent\Fixed_Down.png"));
            img3.Stretch = Stretch.Fill;
            items.Add(img3);

            Image img4 = new Image();
            img4.Name = "Fixed_Left";
            img4.Source = new BitmapImage(new Uri(@"C:\EW\Images\Character\Opponent\Fixed_Left.png"));
            img4.Stretch = Stretch.Fill;
            items.Add(img4);

            Image img5 = new Image();
            img5.Name = "Fixed_Right";
            img5.Source = new BitmapImage(new Uri(@"C:\EW\Images\Character\Opponent\Fixed_Right.png"));
            img5.Stretch = Stretch.Fill;
            items.Add(img5);

            Image img6 = new Image();
            img6.Name = "Random";
            img6.Source = new BitmapImage(new Uri(@"C:\EW\Images\Character\Opponent\Random.png"));
            img6.Stretch = Stretch.Fill;
            items.Add(img6);

            return items;
        }

        public static List<Image> AbilityImages()
        {
            List<Image> abilities = new List<Image>();

            Image img0 = new Image();
            img0.Name = "Empty";
            img0.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\Empty.png"));
            img0.Stretch = Stretch.Fill;
            abilities.Add(img0);

            Image img1 = new Image();
            img1.Name = "Cower";
            img1.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\Empty.png"));
            img1.Stretch = Stretch.Fill;
            abilities.Add(img1);

            Image img2 = new Image();
            img2.Name = "Wait";
            img2.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\Wait.png"));
            img2.Stretch = Stretch.Fill;
            abilities.Add(img2);

            Image img3 = new Image();
            img3.Name = "Punch";
            img3.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\Punch.png"));
            img3.Stretch = Stretch.Fill;
            abilities.Add(img3);

            Image img4 = new Image();
            img4.Name = "Kick";
            img4.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\Kick.png"));
            img4.Stretch = Stretch.Fill;
            abilities.Add(img4);

            Image img5 = new Image();
            img5.Name = "Tackle";
            img5.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\Tackle.png"));
            img5.Stretch = Stretch.Fill;
            abilities.Add(img5);

            Image img6 = new Image();
            img6.Name = "ArcaneShock";
            img6.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\ArcaneShock.png"));
            img6.Stretch = Stretch.Fill;
            abilities.Add(img6);

            Image img7 = new Image();
            img7.Name = "FrostBolt";
            img7.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\FrostBolt.png"));
            img7.Stretch = Stretch.Fill;
            abilities.Add(img7);

            Image img8 = new Image();
            img8.Name = "FireBall";
            img8.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\FireBall.png"));
            img8.Stretch = Stretch.Fill;
            abilities.Add(img8);

            Image img9 = new Image();
            img9.Name = "ArcaneWave";
            img9.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\ArcaneWave.png"));
            img9.Stretch = Stretch.Fill;
            abilities.Add(img9);

            Image img10 = new Image();
            img10.Name = "Slam";
            img10.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\Slam.png"));
            img10.Stretch = Stretch.Fill;
            abilities.Add(img10);

            Image img11 = new Image();
            img11.Name = "FrostRay";
            img11.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\FrostRay.png"));
            img11.Stretch = Stretch.Fill;
            abilities.Add(img11);

            Image img12 = new Image();
            img12.Name = "FireBlast";
            img12.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\FireBlast.png"));
            img12.Stretch = Stretch.Fill;
            abilities.Add(img12);

            Image img13 = new Image();
            img13.Name = "Takedown";
            img13.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\Takedown.png"));
            img13.Stretch = Stretch.Fill;
            abilities.Add(img13);

            Image img14 = new Image();
            img14.Name = "ArcaneSpike";
            img14.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\ArcaneSpike.png"));
            img14.Stretch = Stretch.Fill;
            abilities.Add(img14);

            Image img15 = new Image();
            img15.Name = "FrostSpear";
            img15.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\FrostSpear.png"));
            img15.Stretch = Stretch.Fill;
            abilities.Add(img15);

            Image img16 = new Image();
            img16.Name = "FireLance";
            img16.Source = new BitmapImage(new Uri(@"C:\EW\Images\Ability\FireLance.png"));
            img16.Stretch = Stretch.Fill;
            abilities.Add(img16);

            return abilities;
        }
        public static List<Image> ItemImages()
        {
            List<Image> items = new List<Image>();

            Image img0 = new Image();
            img0.Name = "Empty";
            img0.Source = new BitmapImage(new Uri(@"C:\EW\Images\Item\Empty.png"));
            img0.Stretch = Stretch.Fill;
            items.Add(img0);

            Image img1 = new Image();
            img1.Name = "Potion";
            img1.Source = new BitmapImage(new Uri(@"C:\EW\Images\Item\Potion.png"));
            img1.Stretch = Stretch.Fill;
            items.Add(img1);

            Image img2 = new Image();
            img2.Name = "Rune";
            img2.Source = new BitmapImage(new Uri(@"C:\EW\Images\Item\Rune.png"));
            img2.Stretch = Stretch.Fill;
            items.Add(img2);

            Image img3 = new Image();
            img3.Name = "EmptyUnselected";
            img3.Source = new BitmapImage(new Uri(@"C:\EW\Images\Item\EmptyUnselected.png"));
            img3.Stretch = Stretch.Fill;
            items.Add(img3);

            Image img4 = new Image();
            img4.Name = "PotionUnselected";
            img4.Source = new BitmapImage(new Uri(@"C:\EW\Images\Item\PotionUnselected.png"));
            img4.Stretch = Stretch.Fill;
            items.Add(img4);

            Image img5 = new Image();
            img5.Name = "RuneUnselected";
            img5.Source = new BitmapImage(new Uri(@"C:\EW\Images\Item\RuneUnselected.png"));
            img5.Stretch = Stretch.Fill;
            items.Add(img5);

            Image img6 = new Image();
            img6.Name = "EmptySelected";
            img6.Source = new BitmapImage(new Uri(@"C:\EW\Images\Item\EmptySelected.png"));
            img6.Stretch = Stretch.Fill;
            items.Add(img6);

            Image img7 = new Image();
            img7.Name = "PotionSelected";
            img7.Source = new BitmapImage(new Uri(@"C:\EW\Images\Item\PotionSelected.png"));
            img7.Stretch = Stretch.Fill;
            items.Add(img7);

            Image img8 = new Image();
            img8.Name = "RuneSelected";
            img8.Source = new BitmapImage(new Uri(@"C:\EW\Images\Item\RuneSelected.png"));
            img8.Stretch = Stretch.Fill;
            items.Add(img8);

            return items;
        }
        public static List<Image> BuildingImages()
        {
            List<Image> buildings = new List<Image>();

            Image img0 = new Image();
            img0.Name = "Recovery";
            img0.Source = new BitmapImage(new Uri(@"C:\EW\Images\Building\HP_Center.png"));
            img0.Stretch = Stretch.Fill;
            buildings.Add(img0);

            Image img1 = new Image();
            img1.Name = "Shopping";
            img1.Source = new BitmapImage(new Uri(@"C:\EW\Images\Building\Item_Center.png"));
            img1.Stretch = Stretch.Fill;
            buildings.Add(img1);

            Image img2 = new Image();
            img2.Name = "Training";
            img2.Source = new BitmapImage(new Uri(@"C:\EW\Images\Building\Ability_Center.png"));
            img2.Stretch = Stretch.Fill;
            buildings.Add(img2);

            return buildings;
        }
    }
}
