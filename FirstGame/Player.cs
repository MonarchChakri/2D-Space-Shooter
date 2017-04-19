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
    class Player : Entity
    {
        public int score;

        LeftEnemy objLeft;

        Enemy enemy;

        FinalBoss fb;

        public Player(SpaceShooter obj, Graphics g)
        {
            this.g = g;
            this.obj = obj;
            tile = new Bitmap(Properties.Resources.PlayerStationary);
            newLoc = new Vector2((obj.ClientSize.Width - tile.Width) / 2, obj.ClientSize.Height - tile.Height);
            this.g.DrawImage(tile, newLoc.x,newLoc.y);
            this.health = 100;
            this.rect = new Rectangle((int)(newLoc.x), (int)(newLoc.y), tile.Width, tile.Height);
            this.score = 0;
        }

        public void MovePlayer(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (newLoc.y >= 450)
                    {
                        newLoc.y -= rect.Height / 2;
                        rect.Y -= rect.Height / 2;
                    }
                    break;
                case Keys.Down:
                    if (newLoc.y <= 620)
                    {
                        newLoc.y += rect.Height / 2;
                        rect.Y += rect.Height / 2;
                    } 
                    break;
                case Keys.Left:
                    if (newLoc.x >= 10)
                    {
                        newLoc.x -= rect.Width;
                        rect.X -= rect.Width;
                    }
                    else
                    {
                        newLoc.x = obj.ClientSize.Width - tile.Width;
                        rect.X = obj.ClientSize.Width - tile.Width;
                    }
                    break;
                case Keys.Right:
                    if (newLoc.x <= 400)
                    {
                        newLoc.x += rect.Width;
                        rect.X += rect.Width;
                    }
                    else
                    {
                        newLoc.x = 0;
                        rect.X = 0;
                    }
                    break;
            }
        }

        public void updateLeftEnemy(LeftEnemy objLeft)
        {
            this.objLeft = objLeft;
        }

        public void updateTopEnemy(Enemy enemy)
        {
            this.enemy = enemy;
        }

        public void updateFinalBoss(FinalBoss fb)
        {
            this.fb = fb;
        }

        public bool DeadPlayer()
        {
            if (health <= 0)
                return false;
            return true;
        }
        
    }
}
