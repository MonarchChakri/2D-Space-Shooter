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
    class Entity
    {
        protected Graphics g;
        protected Vector2 newLoc;
        protected Image tile;
        protected Random r = new Random();
        protected SpaceShooter obj;
        protected float health;
        protected Rectangle rect;

        public Image GetSetTile
        {
            get
            {
                return tile;
            }
            set
            {
                this.tile = value;
            }
        }

        public float GetSetHealth
        {
            get
            {
                return health;
            }
            set
            {
                this.health = value;
            }
        }

        public Vector2 GetSetLoc
        {
            get
            {
                return newLoc;
            }
            set
            {
                this.newLoc = value;
            }
        }

        public float GetSetY
        {
            get
            {
                return newLoc.y;
            }
            set
            {
                this.newLoc.y = value;
            }
        }

        public float GetSetX
        {
            get
            {
                return newLoc.x;
            }
            set
            {
                this.newLoc.x = value;
            }
        }

        public Rectangle GetRect{
            get
            {
                return rect;
            }
            }

        public virtual void render()
        {
            if (tile != null)
            {
                    this.g.DrawImage(tile, newLoc.x, newLoc.y);
                    this.g.DrawRectangle(new Pen(Color.Transparent), rect);
            }
        }

        public virtual void HealthBar()
        {
            Font f = new Font(FontFamily.GenericSansSerif, 10);
            Pen p = new Pen(Color.Green);
            Brush b = new SolidBrush(Color.White);
            g.DrawString("Your Health: ", f, b, 10, 10);
            b.Dispose();
            b = new SolidBrush(Color.Green);
            g.DrawRectangle(p, 10, 30, 100, 25);
            g.FillRectangle(b, 10, 30, health, 25);
        }

    }
}
