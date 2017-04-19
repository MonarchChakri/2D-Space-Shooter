using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    class LeftEnemy : Enemy
    {
        public LeftEnemy(SpaceShooter obj, Graphics g, Player p) : base(obj, g, p)
        {
            this.g = g;
            this.obj = obj;
            this.p = p;
            tile = new Bitmap(Properties.Resources.Enemy);
            tile.RotateFlip(RotateFlipType.Rotate180FlipNone);
            newLoc = new Vector2(obj.ClientSize.Width - tile.Width, r.Next(0, obj.ClientSize.Width - tile.Width) - 10);
            this.g.DrawImage(tile, newLoc.x, newLoc.y);
            this.health = 100;
            this.rect = new Rectangle((int)newLoc.x, (int)newLoc.y, tile.Width, tile.Height);
            isReady = true;
            time = 0;
            maxBullCount = 1;
            bullCount = 1;
        }

        public override void MoveEnemy()
        {
            rect.Y = (int)newLoc.y;
            if (newLoc.x >= tile.Width)
            {
                newLoc.x -= tile.Width / 2;
            }
            else
            {
                time = 0;
                newLoc.y = r.Next(0, obj.ClientSize.Width - tile.Width);
                newLoc.x = obj.ClientSize.Width - tile.Width;
                bullCount = 1;
            }

            rect.X = (int)newLoc.x;
             
            if (isReady)
            {
                isReady = false;
                if (bullCount <= maxBullCount)
                    ShootBullet();
            }

            time++;

            if (time >= r.Next(100))
            {
                time = 0;
                isReady = true;
            }
        }  

    }
}
