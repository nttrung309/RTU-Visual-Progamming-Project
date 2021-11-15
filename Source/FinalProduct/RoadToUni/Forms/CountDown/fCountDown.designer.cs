
namespace RoadToUni.Forms.CountDown
{
    partial class fCountDown
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
            this.tmCountDown = new System.Windows.Forms.Timer(this.components);
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbSubTitle = new System.Windows.Forms.Label();
            this.picRoundedRec1 = new System.Windows.Forms.PictureBox();
            this.picRoundedRec2 = new System.Windows.Forms.PictureBox();
            this.picRoundedRec3 = new System.Windows.Forms.PictureBox();
            this.picRoundedRec4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDays = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMins = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbHours = new System.Windows.Forms.Label();
            this.lbSec = new System.Windows.Forms.Label();
            this.topBackGround = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRoundedRec1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoundedRec2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoundedRec3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoundedRec4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // tmCountDown
            // 
            this.tmCountDown.Interval = 1000;
            this.tmCountDown.Tick += new System.EventHandler(this.tmCountDown_Tick);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(440, 32);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(258, 31);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Đếm ngược ngày thi";
            // 
            // lbSubTitle
            // 
            this.lbSubTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSubTitle.AutoSize = true;
            this.lbSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTitle.ForeColor = System.Drawing.Color.White;
            this.lbSubTitle.Location = new System.Drawing.Point(455, 67);
            this.lbSubTitle.Name = "lbSubTitle";
            this.lbSubTitle.Size = new System.Drawing.Size(227, 20);
            this.lbSubTitle.TabIndex = 3;
            this.lbSubTitle.Text = "Kỳ thi THPT Quốc Gia 2022";
            // 
            // picRoundedRec1
            // 
            this.picRoundedRec1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picRoundedRec1.BackColor = System.Drawing.Color.Transparent;
            this.picRoundedRec1.BackgroundImage = global::RoadToUni.Properties.Resources.rounded_rec;
            this.picRoundedRec1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picRoundedRec1.Location = new System.Drawing.Point(143, 109);
            this.picRoundedRec1.Name = "picRoundedRec1";
            this.picRoundedRec1.Size = new System.Drawing.Size(201, 195);
            this.picRoundedRec1.TabIndex = 5;
            this.picRoundedRec1.TabStop = false;
            // 
            // picRoundedRec2
            // 
            this.picRoundedRec2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picRoundedRec2.BackColor = System.Drawing.Color.Transparent;
            this.picRoundedRec2.BackgroundImage = global::RoadToUni.Properties.Resources.rounded_rec;
            this.picRoundedRec2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picRoundedRec2.Location = new System.Drawing.Point(350, 109);
            this.picRoundedRec2.Name = "picRoundedRec2";
            this.picRoundedRec2.Size = new System.Drawing.Size(201, 195);
            this.picRoundedRec2.TabIndex = 6;
            this.picRoundedRec2.TabStop = false;
            // 
            // picRoundedRec3
            // 
            this.picRoundedRec3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picRoundedRec3.BackColor = System.Drawing.Color.Transparent;
            this.picRoundedRec3.BackgroundImage = global::RoadToUni.Properties.Resources.rounded_rec;
            this.picRoundedRec3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picRoundedRec3.Location = new System.Drawing.Point(557, 109);
            this.picRoundedRec3.Name = "picRoundedRec3";
            this.picRoundedRec3.Size = new System.Drawing.Size(201, 195);
            this.picRoundedRec3.TabIndex = 7;
            this.picRoundedRec3.TabStop = false;
            // 
            // picRoundedRec4
            // 
            this.picRoundedRec4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picRoundedRec4.BackColor = System.Drawing.Color.Transparent;
            this.picRoundedRec4.BackgroundImage = global::RoadToUni.Properties.Resources.rounded_rec;
            this.picRoundedRec4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picRoundedRec4.Location = new System.Drawing.Point(764, 109);
            this.picRoundedRec4.Name = "picRoundedRec4";
            this.picRoundedRec4.Size = new System.Drawing.Size(201, 195);
            this.picRoundedRec4.TabIndex = 8;
            this.picRoundedRec4.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDays
            // 
            this.lbDays.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDays.AutoSize = true;
            this.lbDays.BackColor = System.Drawing.Color.Transparent;
            this.lbDays.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDays.ForeColor = System.Drawing.Color.White;
            this.lbDays.Location = new System.Drawing.Point(188, 166);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(88, 64);
            this.lbDays.TabIndex = 0;
            this.lbDays.Text = "10";
            this.lbDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(427, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giờ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(631, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phút";
            // 
            // lbMins
            // 
            this.lbMins.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMins.AutoSize = true;
            this.lbMins.BackColor = System.Drawing.Color.Transparent;
            this.lbMins.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMins.ForeColor = System.Drawing.Color.White;
            this.lbMins.Location = new System.Drawing.Point(617, 166);
            this.lbMins.Name = "lbMins";
            this.lbMins.Size = new System.Drawing.Size(0, 64);
            this.lbMins.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(837, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giây";
            // 
            // lbHours
            // 
            this.lbHours.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHours.AutoSize = true;
            this.lbHours.BackColor = System.Drawing.Color.Transparent;
            this.lbHours.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHours.ForeColor = System.Drawing.Color.White;
            this.lbHours.Location = new System.Drawing.Point(409, 166);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(0, 64);
            this.lbHours.TabIndex = 3;
            this.lbHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSec
            // 
            this.lbSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSec.AutoSize = true;
            this.lbSec.BackColor = System.Drawing.Color.Transparent;
            this.lbSec.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSec.ForeColor = System.Drawing.Color.White;
            this.lbSec.Location = new System.Drawing.Point(824, 166);
            this.lbSec.Name = "lbSec";
            this.lbSec.Size = new System.Drawing.Size(0, 64);
            this.lbSec.TabIndex = 2;
            // 
            // topBackGround
            // 
            this.topBackGround.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBackGround.BackColor = System.Drawing.Color.Transparent;
            this.topBackGround.BackgroundImage = global::RoadToUni.Properties.Resources.cdBackGround4;
            this.topBackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topBackGround.Location = new System.Drawing.Point(12, 12);
            this.topBackGround.Name = "topBackGround";
            this.topBackGround.Size = new System.Drawing.Size(1084, 330);
            this.topBackGround.TabIndex = 9;
            this.topBackGround.TabStop = false;
            // 
            // fCountDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 611);
            this.ControlBox = false;
            this.Controls.Add(this.topBackGround);
            this.Controls.Add(this.lbSec);
            this.Controls.Add(this.lbHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picRoundedRec1);
            this.Controls.Add(this.lbMins);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSubTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picRoundedRec2);
            this.Controls.Add(this.lbDays);
            this.Controls.Add(this.picRoundedRec3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picRoundedRec4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCountDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCountDown";
            this.Load += new System.EventHandler(this.fCountDown_Load);
            this.SizeChanged += new System.EventHandler(this.fCountDown_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picRoundedRec1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoundedRec2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoundedRec3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoundedRec4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmCountDown;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbSubTitle;
        private System.Windows.Forms.PictureBox picRoundedRec1;
        private System.Windows.Forms.PictureBox picRoundedRec2;
        private System.Windows.Forms.PictureBox picRoundedRec3;
        private System.Windows.Forms.PictureBox picRoundedRec4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.Label lbSec;
        private System.Windows.Forms.PictureBox topBackGround;
    }
}