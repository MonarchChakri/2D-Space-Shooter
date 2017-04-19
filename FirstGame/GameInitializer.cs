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
        Graphics g;

        Player p;

        SpaceShooter obj;

        static FinalBoss fb;

        HealthBall healthBall;

        private Enemy enemy;

        int one = 10;

        int two = 0;

        int three = 0;

        int once = 0;

        private LeftEnemy objLeft;

        private List<PlayerBullet> bullets { get; set; } = new List<PlayerBullet>();

        public GameInitializer(Graphics g, SpaceShooter obj)
        {
            this.g = g;
            this.obj = obj;
            p = new Player(obj, g);
            objLeft = new LeftEnemy(obj, g, p);
            healthBall = new HealthBall(p, g, obj);
        }

        public int render(SpaceShooter obj)
        {
            if (p.DeadPlayer())
            {
                managePlayer();
                healthBallFunction();
                managePlayerBullet();
                if (p.score >= 5 && two == 0)
                {
                    DisplayScore(one);
                    return Level2();
                }
                else if (p.score >= 10)
                    return Level3();
                else
                {
                    DisplayScore(one);
                    mangeEnemy();
                }
            }
            else
                gameOver();
            return 0;
        }

    }
}
