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
using WMPLib;

namespace FirstGame
{
    class HealthBall : Entity
    {
        Player p;

        public HealthBall(Player p, Graphics g, SpaceShooter obj)
        {
            this.g = g;
            this.p = p;
            this.obj = obj;
            tile = new Bitmap(Properties.Resources.HealthBall);
        }

        public void CollidePlayer()
        {
            if (rect.IntersectsWith(p.GetRect))
            {
                p.GetSetHealth = 100;
                Inatatiate();
            }
        }

        public void MoveBall()
        {
            rect.X = (int)newLoc.x;

            if (newLoc.y <= 720 + tile.Height)
            {
                newLoc.y += tile.Height / 2;
            }

            else
            {
                newLoc.y = 0;
                newLoc.x = r.Next(0, obj.ClientSize.Width - tile.Width);
            }

            rect.Y = (int)newLoc.y;

            CollidePlayer();

        }

        public void Inatatiate()
        {
            newLoc = new Vector2(r.Next(0, obj.ClientSize.Width - tile.Width) - 10, 0);
            this.g.DrawImage(tile, newLoc.x, newLoc.y);
            this.rect = new Rectangle((int)(newLoc.x), (int)(newLoc.y), tile.Width, tile.Height);
        }
    }
}
