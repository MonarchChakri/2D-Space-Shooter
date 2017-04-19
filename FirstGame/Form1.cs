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
    public partial class SpaceShooter : Form
    {
        Graphics g;
        GameInitializer game;
        int b;

        WindowsMediaPlayer player = new WindowsMediaPlayer();

        IWMPMedia next;

        public SpaceShooter GetThis
        {
            get
            {
                return this;
            }
        }

        public Graphics GetG
        {
            get
            {
                return this.g;
            }
        }

        public SpaceShooter()
        {
            InitializeComponent();
            mc();
        }

        private void SpaceShooter_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            this.BackgroundImage = Properties.Resources.Background;
            game = new GameInitializer(g, GetThis);
            game.initGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.g.Clear(Color.CornflowerBlue);
            b = game.render(GetThis);
            if (b != 0 || btnYes.Enabled == true || btnOk.Enabled == true)
            {
                Timer.Stop();
                Timer1.Start();
            }
        }

        private void SpaceShooter_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Down) || (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right))
                game.MovePlayer(e);
            if (e.KeyCode == Keys.Space)
                game.ShootBullet();
            if (e.KeyCode == Keys.Escape)
                game.pause();
        }

        public void mc()
        {
            next = player.newMedia(Application.StartupPath + "\\Resources\\0.mp3");
            player.currentPlaylist.appendItem(next);
            next = player.newMedia(Application.StartupPath + "\\Resources\\1.mp3");
            player.currentPlaylist.appendItem(next);
            next = player.newMedia(Application.StartupPath + "\\Resources\\2.mp3");
            player.currentPlaylist.appendItem(next);
            next = player.newMedia(Application.StartupPath + "\\Resources\\3.mp3");
            player.currentPlaylist.appendItem(next);
            next = player.newMedia(Application.StartupPath + "\\Resources\\4.mp3");
            player.currentPlaylist.appendItem(next);
            next = player.newMedia(Application.StartupPath + "\\Resources\\5.mp3");
            player.currentPlaylist.appendItem(next);
            next = player.newMedia(Application.StartupPath + "\\Resources\\6.mp3");
            player.currentPlaylist.appendItem(next);
            next = player.newMedia(Application.StartupPath + "\\Resources\\7.mp3");
            player.currentPlaylist.appendItem(next);
            next = player.newMedia(Application.StartupPath + "\\Resources\\8.mp3");
            player.currentPlaylist.appendItem(next);
            next = player.newMedia(Application.StartupPath + "\\Resources\\9.mp3");
            player.currentPlaylist.appendItem(next);
            next = player.newMedia(Application.StartupPath + "\\Resources\\10.mp3");
            player.currentPlaylist.appendItem(next);
            next = player.newMedia(Application.StartupPath + "\\Resources\\11.mp3");
            player.currentPlaylist.appendItem(next);

            player.settings.autoStart = true;
            player.controls.play();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            b = 0;
            this.btnYes.Visible = false;
            this.btnYes.Enabled = false;
            this.btnInst.Enabled = false;
            this.btnInst.Visible = false;
            this.gamePause.Visible = false;
            this.gamePause.Enabled = false;
            this.winGame.Visible = false;
            this.winGame.Enabled = false;
            this.Level1.Visible = false;
            this.Level1.Enabled = false;
            this.Level2.Visible = false;
            this.Level2.Enabled = false;
            this.Level3.Visible = false;
            this.Level3.Enabled = false;
            this.label1.Visible = false;
            this.label1.Enabled = false;
            this.label2.Visible = false;
            this.label2.Enabled = false;
            this.label3.Visible = false;
            this.label3.Enabled = false;
            this.label4.Visible = false;
            this.label4.Enabled = false;
            Timer1.Stop();
            Timer.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Background;
            if (b == 1)
                game.renderLevel2();
            else if (b == 2)
                game.renderLevel3();
            else if (b == 3)
                game.winGame();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnInst_Click(object sender, EventArgs e)
        {
            game.winInstr();
        }
    }
}
