using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace FirstGame
{
    partial class GameInitializer
    {
         
        public void managePlayer()
        {
            p.render();
            p.HealthBar();
        }

        public void mangeEnemy()
        {
            if (objLeft != null)
            {
                objLeft.render();
                objLeft.MoveEnemy();
            }
            if (enemy != null)
            {
                enemy.render();
                enemy.MoveEnemy();
            }
        }

        public int Level2()
        {
            two++;
            one = 10;
            enemy = new Enemy(obj, g, p);
            return 1;
        }

        public int Level3()
        {
            if (once == 0)
            {
                enemy.GetSetLoc.x = this.obj.ClientSize.Width + enemy.GetSetTile.Width;
                objLeft.GetSetLoc.x = this.obj.ClientSize.Width + objLeft.GetSetTile.Width;
                once++;
                return 2;
            }
            one = 20;
            if (fb == null)
                fb = new FinalBoss(obj, g, p);
            if (fb.GetSetHealth <= 0)
                return 3;
            fb.render();
            fb.MoveEnemy();
            return 0;
        } 

        public void managePlayerBullet()
        {
            foreach (PlayerBullet item in bullets)
            {
                item.render();
                item.MoveBullet();
            }
        }

        public void healthBallFunction()
        {
            if (p.GetSetHealth <= 50)
            {
                if (three == 0)
                {
                    three++;
                    healthBall.Inatatiate();
                }
                healthBall.MoveBall();
                healthBall.render();
            }
        }

        public void MovePlayer(KeyEventArgs e)
        {
            p.MovePlayer(e);
        }

        public void ShootBullet()
        {
            PlayerBullet item = new PlayerBullet(p, g, objLeft, enemy,fb);
            bullets.Add(item);
            item.PlaceBullet();
            if (enemy != null)
                p.updateTopEnemy(enemy);
            if (objLeft != null)
                p.updateLeftEnemy(objLeft);
            if (fb != null)
                p.updateFinalBoss(fb);
        }

        public void DisplayScore(int a)
        {
            string scor = p.score.ToString();
            Font f = new Font(FontFamily.GenericSansSerif, 10);
            Brush b = new SolidBrush(Color.White);
            g.DrawString("Your Score: ", f, b, 10, 60);
            g.DrawString(scor, f, b, 90, 60);
            g.DrawString("  /" + a.ToString(), f, b, 100, 60);
        }

        public void winInstr()
        {
            winInst win = new winInst();
            win.ShowDialog();
        }

        public void gameOver()
        {
            this.obj.BackgroundImage = Properties.Resources.Background;
            this.obj.btnOk.Visible = true;
            this.obj.btnOk.Enabled = true;
            this.obj.btnNo.Visible = true;
            this.obj.btnNo.Enabled = true;
            this.obj.gameOver.Visible = true;
            this.obj.gameOver.Enabled = true;
        }

        public void pause()
        {
            this.obj.gamePause.Visible = true;
            this.obj.gamePause.Enabled = true;
            this.obj.btnYes.Visible = true;
            this.obj.btnYes.Enabled = true;
            this.obj.btnInst.Enabled = true;
            this.obj.btnInst.Visible = true;
        }

        public void initGame()
        {
            this.obj.label1.Visible = true;
            this.obj.label1.Enabled = true;
            this.obj.label2.Visible = true;
            this.obj.label2.Enabled = true;
            this.obj.label3.Visible = true;
            this.obj.label3.Enabled = true;
            this.obj.label4.Visible = true;
            this.obj.label4.Enabled = true;
            this.obj.btnYes.Visible = true;
            this.obj.btnYes.Enabled = true;
            this.obj.btnInst.Enabled = true;
            this.obj.btnInst.Visible = true;
        }

        public void renderLevel2()
        {
            this.obj.btnYes.Visible = true;
            this.obj.btnYes.Enabled = true;
            this.obj.Level1.Visible = true;
            this.obj.Level1.Enabled = true;
        }

        public void renderLevel3()
        {
            this.obj.btnYes.Visible = true;
            this.obj.btnYes.Enabled = true;
            this.obj.Level2.Visible = true;
            this.obj.Level2.Enabled = true;
            this.obj.Level3.Visible = true;
            this.obj.Level3.Enabled = true;
        }

        public void winGame()
        {
            this.obj.BackgroundImage = Properties.Resources.Background;
            this.obj.btnOk.Visible = true;
            this.obj.btnOk.Enabled = true;
            this.obj.btnNo.Visible = true;
            this.obj.btnNo.Enabled = true;
            this.obj.winGame.Visible = true;
            this.obj.winGame.Enabled = true;
        }

    }
}
