
namespace RoadToUni.Forms.Pomodoro
{
    partial class fPomodoro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPomodoro));
            this.btnPomodoro = new System.Windows.Forms.Button();
            this.btnShortBreak = new System.Windows.Forms.Button();
            this.btnLongBreak = new System.Windows.Forms.Button();
            this.lbClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop1 = new RoadToUni.Forms.Pomodoro.CircleButton();
            this.btnStart1 = new RoadToUni.Forms.Pomodoro.CircleButton();
            this.SuspendLayout();
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPomodoro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPomodoro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPomodoro.FlatAppearance.BorderSize = 20;
            this.btnPomodoro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPomodoro.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomodoro.ForeColor = System.Drawing.Color.IndianRed;
            this.btnPomodoro.Image = global::RoadToUni.Properties.Resources.LogoBtnPomo;
            this.btnPomodoro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPomodoro.Location = new System.Drawing.Point(71, 145);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.Size = new System.Drawing.Size(201, 60);
            this.btnPomodoro.TabIndex = 0;
            this.btnPomodoro.Text = "      Pomodoro";
            this.btnPomodoro.UseVisualStyleBackColor = false;
            this.btnPomodoro.Click += new System.EventHandler(this.btnPomodoro_Click);
            // 
            // btnShortBreak
            // 
            this.btnShortBreak.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShortBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShortBreak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShortBreak.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShortBreak.ForeColor = System.Drawing.Color.IndianRed;
            this.btnShortBreak.Image = global::RoadToUni.Properties.Resources.LogoBtnShortBreak;
            this.btnShortBreak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShortBreak.Location = new System.Drawing.Point(71, 232);
            this.btnShortBreak.Name = "btnShortBreak";
            this.btnShortBreak.Size = new System.Drawing.Size(201, 59);
            this.btnShortBreak.TabIndex = 1;
            this.btnShortBreak.Text = "Short Break";
            this.btnShortBreak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShortBreak.UseVisualStyleBackColor = false;
            this.btnShortBreak.Click += new System.EventHandler(this.btnShortBreak_Click);
            // 
            // btnLongBreak
            // 
            this.btnLongBreak.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLongBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLongBreak.FlatAppearance.BorderSize = 4;
            this.btnLongBreak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLongBreak.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLongBreak.ForeColor = System.Drawing.Color.IndianRed;
            this.btnLongBreak.Image = global::RoadToUni.Properties.Resources.LogoBtnLongBreak;
            this.btnLongBreak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLongBreak.Location = new System.Drawing.Point(71, 320);
            this.btnLongBreak.Name = "btnLongBreak";
            this.btnLongBreak.Size = new System.Drawing.Size(201, 57);
            this.btnLongBreak.TabIndex = 2;
            this.btnLongBreak.Text = "Long Break";
            this.btnLongBreak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLongBreak.UseVisualStyleBackColor = false;
            this.btnLongBreak.Click += new System.EventHandler(this.btnLongBreak_Click);
            // 
            // lbClock
            // 
            this.lbClock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbClock.BackColor = System.Drawing.Color.Turquoise;
            this.lbClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbClock.Font = new System.Drawing.Font("Script MT Bold", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.ForeColor = System.Drawing.Color.Snow;
            this.lbClock.Location = new System.Drawing.Point(374, 124);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(292, 281);
            this.lbClock.TabIndex = 3;
            this.lbClock.Text = "00 : 00";
            this.lbClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = global::RoadToUni.Properties.Resources.LogoTilteLeft;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "     Pomodoro Timer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStop1
            // 
            this.btnStop1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStop1.BackColor = System.Drawing.Color.Crimson;
            this.btnStop1.FlatAppearance.BorderSize = 0;
            this.btnStop1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop1.Font = new System.Drawing.Font("Cooper Black", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStop1.Image = global::RoadToUni.Properties.Resources.LogoStop;
            this.btnStop1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop1.Location = new System.Drawing.Point(747, 282);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(286, 156);
            this.btnStop1.TabIndex = 8;
            this.btnStop1.Text = " STOP";
            this.btnStop1.UseVisualStyleBackColor = false;
            this.btnStop1.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // btnStart1
            // 
            this.btnStart1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart1.BackColor = System.Drawing.Color.Chartreuse;
            this.btnStart1.FlatAppearance.BorderSize = 0;
            this.btnStart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart1.Font = new System.Drawing.Font("Cooper Black", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart1.ForeColor = System.Drawing.Color.Tomato;
            this.btnStart1.Image = global::RoadToUni.Properties.Resources.logoStart;
            this.btnStart1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart1.Location = new System.Drawing.Point(747, 98);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(286, 156);
            this.btnStart1.TabIndex = 7;
            this.btnStart1.Text = "   START";
            this.btnStart1.UseVisualStyleBackColor = false;
            this.btnStart1.Click += new System.EventHandler(this.btnStart1_Click);
            // 
            // fPomodoro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::RoadToUni.Properties.Resources.Cool_wallpaper1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop1);
            this.Controls.Add(this.btnStart1);
            this.Controls.Add(this.lbClock);
            this.Controls.Add(this.btnLongBreak);
            this.Controls.Add(this.btnShortBreak);
            this.Controls.Add(this.btnPomodoro);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPomodoro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro";
            this.Load += new System.EventHandler(this.fPomodoro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPomodoro;
        private System.Windows.Forms.Button btnShortBreak;
        private System.Windows.Forms.Button btnLongBreak;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.Timer timer1;
        private CircleButton btnStart1;
        private CircleButton btnStop1;
        private System.Windows.Forms.Label label1;
    }
}

