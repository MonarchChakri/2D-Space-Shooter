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
    class PlayerBullet : Entity
    {
        Player p;

        Enemy enemy;

        LeftEnemy objLeft;

        FinalBoss fb;

        public PlayerBullet(Player p, Graphics g, LeftEnemy objLeft, Enemy enemy, FinalBoss fb)
        {
            this.g = g;
            this.p = p;
            this.objLeft = objLeft;
            this.fb = fb;
            this.enemy = enemy;
            tile = new Bitmap(Properties.Resources.Bullet);
        }

        public void MoveBullet()
        {
            collideTopEnemy();
            collideLeftEnemy();
            collideFinalBoss();
            newLoc.y -= 50;
            rect.Y -= 50;
        }

        public void PlaceBullet()
        {
            this.rect = new Rectangle((int)(p.GetSetLoc.x + (p.GetSetTile.Width - tile.Width) / 2), (int)(p.GetSetLoc.y - tile.Height), tile.Width, tile.Height);
            newLoc = new Vector2(p.GetSetLoc.x + (p.GetSetTile.Width - tile.Width) / 2, p.GetSetLoc.y - tile.Height);
        }

        public void collideTopEnemy()
        {
            if (enemy != null && tile != null)
            { 
                    if (intersect(enemy))
                    {
                        float tmp = enemy.GetSetHealth;
                        tmp -= 5;
                        enemy.GetSetHealth = tmp;
                        tile = null;
                        if (enemy.GetSetHealth <= 0)
                        {
                            enemy.GetSetY = 0;
                            enemy.GetSetX = r.Next(0, 390);
                            enemy.GetSetHealth = 100;
                            p.score++;
                        }
                    }
                }
            }

        private bool intersect(Enemy e)
        { 
                return (rect.IntersectsWith(e.GetRect));
        }

        public void collideLeftEnemy()
        {
            if(objLeft != null) {
                if (intersectLeftEnemy())
                {
                    float tmp = objLeft.GetSetHealth;
                    tmp -= 5;
                    objLeft.GetSetHealth = tmp;
                    tile = null;
                    if (objLeft.GetSetHealth <= 0)
                    {
                        objLeft.GetSetX = 433 - objLeft.GetSetTile.Width;
                        objLeft.GetSetY = r.Next(0, 433 - objLeft.GetSetTile.Width);
                        objLeft.GetSetHealth = 100;
                        p.score++;
                    }
                }
            }
        }

        private bool intersectLeftEnemy()
        {
            return (rect.IntersectsWith(objLeft.GetRect));
        }

        public void collideFinalBoss()
        {
            if (fb != null)
            {
                if (intersectFinalBoss())
                {
                    float tmp = fb.GetSetHealth;
                    tmp -= 0.5f;
                    fb.GetSetHealth = tmp;
                    tile = null; 
                }
            }
        }

        private bool intersectFinalBoss()
        {
            return (rect.IntersectsWith(fb.GetRect));
        }
    }
}
