namespace FirstGame
{
    partial class SpaceShooter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceShooter));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.btnYes = new System.Windows.Forms.Button();
            this.Level2 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Level1 = new System.Windows.Forms.Label();
            this.Level3 = new System.Windows.Forms.Label();
            this.gameOver = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.gamePause = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.winGame = new System.Windows.Forms.Label();
            this.btnInst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 123;
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Black;
            this.btnYes.Enabled = false;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(180, 642);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Continue";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // Level2
            // 
            this.Level2.BackColor = System.Drawing.Color.Transparent;
            this.Level2.Enabled = false;
            this.Level2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level2.ForeColor = System.Drawing.Color.LawnGreen;
            this.Level2.Location = new System.Drawing.Point(99, 305);
            this.Level2.Name = "Level2";
            this.Level2.Size = new System.Drawing.Size(232, 82);
            this.Level2.TabIndex = 3;
            this.Level2.Text = "Hurray Level 2 Completed!";
            this.Level2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Level2.Visible = false;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 123;
            this.Timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Level1
            // 
            this.Level1.BackColor = System.Drawing.Color.Transparent;
            this.Level1.Enabled = false;
            this.Level1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level1.ForeColor = System.Drawing.Color.LawnGreen;
            this.Level1.Location = new System.Drawing.Point(99, 42);
            this.Level1.Name = "Level1";
            this.Level1.Size = new System.Drawing.Size(232, 82);
            this.Level1.TabIndex = 4;
            this.Level1.Text = "Hurray Level 1 Completed!";
            this.Level1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Level1.Visible = false;
            // 
            // Level3
            // 
            this.Level3.BackColor = System.Drawing.Color.Transparent;
            this.Level3.Enabled = false;
            this.Level3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level3.ForeColor = System.Drawing.Color.OrangeRed;
            this.Level3.Location = new System.Drawing.Point(99, 521);
            this.Level3.Name = "Level3";
            this.Level3.Size = new System.Drawing.Size(232, 82);
            this.Level3.TabIndex = 5;
            this.Level3.Text = "Final Level Starts now!";
            this.Level3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Level3.Visible = false;
            // 
            // gameOver
            // 
            this.gameOver.BackColor = System.Drawing.Color.Transparent;
            this.gameOver.Enabled = false;
            this.gameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver.ForeColor = System.Drawing.Color.Crimson;
            this.gameOver.Location = new System.Drawing.Point(99, 138);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(232, 82);
            this.gameOver.TabIndex = 6;
            this.gameOver.Text = "Game Over, Wanna Retry ?";
            this.gameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOver.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Black;
            this.btnOk.Enabled = false;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(11, 642);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Yes";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Black;
            this.btnNo.Enabled = false;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(342, 642);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 8;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // gamePause
            // 
            this.gamePause.BackColor = System.Drawing.Color.Transparent;
            this.gamePause.Enabled = false;
            this.gamePause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePause.ForeColor = System.Drawing.Color.Gold;
            this.gamePause.Location = new System.Drawing.Point(99, 220);
            this.gamePause.Name = "gamePause";
            this.gamePause.Size = new System.Drawing.Size(232, 82);
            this.gamePause.TabIndex = 9;
            this.gamePause.Text = "Game Paused";
            this.gamePause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gamePause.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(99, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(99, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(99, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Space";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(99, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Shooter";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // winGame
            // 
            this.winGame.BackColor = System.Drawing.Color.Transparent;
            this.winGame.Enabled = false;
            this.winGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winGame.ForeColor = System.Drawing.Color.Lime;
            this.winGame.Location = new System.Drawing.Point(69, 433);
            this.winGame.Name = "winGame";
            this.winGame.Size = new System.Drawing.Size(304, 88);
            this.winGame.TabIndex = 14;
            this.winGame.Text = "        Congratulations ! \r\nYou have finished the game :)\r\n            Wanna repl" +
    "ay ?";
            this.winGame.Visible = false;
            // 
            // btnInst
            // 
            this.btnInst.BackColor = System.Drawing.Color.Black;
            this.btnInst.Enabled = false;
            this.btnInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInst.ForeColor = System.Drawing.Color.White;
            this.btnInst.Location = new System.Drawing.Point(180, 606);
            this.btnInst.Name = "btnInst";
            this.btnInst.Size = new System.Drawing.Size(75, 23);
            this.btnInst.TabIndex = 15;
            this.btnInst.Text = "Instructions";
            this.btnInst.UseVisualStyleBackColor = false;
            this.btnInst.Visible = false;
            this.btnInst.Click += new System.EventHandler(this.btnInst_Click);
            // 
            // SpaceShooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::FirstGame.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(430, 677);
            this.Controls.Add(this.btnInst);
            this.Controls.Add(this.winGame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamePause);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.Level3);
            this.Controls.Add(this.Level1);
            this.Controls.Add(this.Level2);
            this.Controls.Add(this.btnYes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpaceShooter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Shooter";
            this.Load += new System.EventHandler(this.SpaceShooter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceShooter_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer Timer;
        public System.Windows.Forms.Label Level2;
        public System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Timer Timer1;
        public System.Windows.Forms.Label Level1;
        public System.Windows.Forms.Label Level3;
        public System.Windows.Forms.Label gameOver;
        public System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.Button btnNo;
        public System.Windows.Forms.Label gamePause;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label winGame;
        public System.Windows.Forms.Button btnInst;
    }
}

