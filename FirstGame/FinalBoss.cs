using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FirstGame
{
    class FinalBoss : Enemy
    {
        string direc;

        public FinalBoss(SpaceShooter obj, Graphics g, Player p) : base(obj, g, p)
        {
            this.g = g;
            this.obj = obj;
            this.p = p;
            tile = new Bitmap(Properties.Resources.FinalBoss);
            tile.RotateFlip(RotateFlipType.Rotate180FlipNone);
            newLoc = new Vector2((obj.ClientSize.Width - tile.Width) / 2, tile.Height / 2 + 20);
            this.g.DrawImage(tile, newLoc.x, newLoc.y);
            this.health = 250;
            this.rect = new Rectangle((int)(newLoc.x) + 5, (int)(newLoc.y), tile.Width - 10, tile.Height - 10);
            direc = "Left";
        }

        public override void MoveEnemy()
        {
            rect.Y = (int)newLoc.y;

            if (newLoc.x < 0) ShootBullet();

            if (newLoc.x > 0 && direc == "Left")
                newLoc.x -= tile.Width / 5;
            else if (newLoc.x < (obj.ClientSize.Width - tile.Width))
            {
                direc = "Right";
                newLoc.x += tile.Width / 5;
            }
            else
            {
                ShootBullet();
                direc = "Left";
            }

            rect.X = (int)newLoc.x + 5;
        }
    }
}
