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
    class Enemy : Entity
    {
        protected bool isReady;

        protected int time;

        protected int maxBullCount;

        protected int bullCount;

        protected Player p;

        List<EnemyBullet> list = new List<EnemyBullet>();

        public Enemy(SpaceShooter obj, Graphics g, Player p)
        {
            this.g = g;
            this.obj = obj;
            this.p = p;
            tile = new Bitmap(Properties.Resources.Enemy);
            tile.RotateFlip(RotateFlipType.Rotate180FlipNone);
            newLoc = new Vector2(r.Next(0, obj.ClientSize.Width - tile.Width) - 10, 0);
            this.g.DrawImage(tile, newLoc.x,newLoc.y);
            this.health = 100;
            this.rect = new Rectangle((int)newLoc.x, (int)newLoc.y, tile.Width, tile.Height);
            isReady = true;
            time = 0;
            maxBullCount = 1;
            bullCount = 1;
        }

        public virtual void MoveEnemy()
        {
            rect.X = (int)newLoc.x;
            if (newLoc.y <= 720 + tile.Height)
            {
                newLoc.y += tile.Height / 2;
            }
            else
            {
                time = 0;
                newLoc.y = 0;
                newLoc.x = r.Next(0, obj.ClientSize.Width - tile.Width);
                bullCount = 1;
            }

            rect.Y = (int)newLoc.y;

            if (rect.IntersectsWith(p.GetRect))
            {
                if (rect.X + (tile.Width / 2) >= p.GetRect.Left && rect.X + (tile.Width / 2) <= p.GetRect.Right)
                {
                    p.GetSetHealth -= 5;
                }
            }

            if (isReady && rect.Bottom + 10 <= p.GetRect.Top)
            {
                isReady = false;
                if(bullCount <= maxBullCount)
                ShootBullet();
            }

            time++;

            if (time >= r.Next(100))
            {
                time = 0;
                isReady = true;
            }
        }

        public void ShootBullet() 
        {
            bullCount++;
            EnemyBullet b = new EnemyBullet(this, p, g);
            list.Add(b);
            b.PlaceBullet(this);
            b.collide();
        }

        public override void render()
        {
            base.render();
            foreach (EnemyBullet item in list)
            {
                item.MoveBullet(this);
                item.render();
            }
        } 

    }
}
