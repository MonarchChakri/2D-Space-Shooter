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
    class EnemyBullet : Entity
    {
        Enemy E;
        Player p;
        Vector2 playerPos;
        double movX;
        double movY;

        public EnemyBullet(Enemy E, Player p, Graphics g)
        {
            this.g = g;
            this.p = p;
            this.E = E;
            tile = new Bitmap(Properties.Resources.EnemyBullet);
            tile.RotateFlip(RotateFlipType.Rotate180FlipNone);
            movX = 0;
            movY = 0;
        }

        public void MoveBullet(Enemy E)
        {
            if (newLoc.x < 0 || newLoc.x > 720 || newLoc.y < 0 || newLoc.x > 500)
            {
                tile = null;
                return;
            }
            newLoc.y += Convert.ToInt32(movY);
            rect.Y += Convert.ToInt32(movY);
            newLoc.x += Convert.ToInt32(movX);
            rect.X += Convert.ToInt32(movX);
            collide();
        }

        public void PlaceBullet(Enemy E)
        {
            this.rect = new Rectangle((int)(E.GetSetLoc.x + (E.GetSetTile.Width - tile.Width) / 2), (int)(E.GetSetLoc.y + tile.Height), tile.Width, tile.Height);
            newLoc = new Vector2(E.GetSetLoc.x + (E.GetSetTile.Width - tile.Width) / 2, E.GetSetLoc.y + tile.Height);
            playerPos = new Vector2(p.GetSetX, p.GetSetY);
            if (rect.Left + (rect.Width / 2) > p.GetSetLoc.x + (p.GetSetTile.Width / 2))
                movX = -Math.Abs(rect.Right + (rect.Width / 2) - p.GetRect.Left) / 10;
            else
                movX = Math.Abs(rect.Right + (rect.Width / 2) - p.GetRect.Right) / 10;
            movY = Math.Abs(rect.Bottom - p.GetRect.Bottom) / 10;
        }

        public void collide()
        {
            if (tile != null)
            {
                if (intersect())
                {
                    float temp = p.GetSetHealth;
                    temp -= 3;
                    p.GetSetHealth = temp;
                    tile = null;
                }
            }
        }

        public bool intersect()
        {
            return (rect.IntersectsWith(p.GetRect));
        }
    }
}
