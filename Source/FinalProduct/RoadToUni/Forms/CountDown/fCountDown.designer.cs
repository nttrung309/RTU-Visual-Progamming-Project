
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCountDown));
            this.tmCountDown = new System.Windows.Forms.Timer(this.components);
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbSubTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDays = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMins = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbHours = new System.Windows.Forms.Label();
            this.lbSec = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMBTI = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picPomo = new System.Windows.Forms.PictureBox();
            this.topBackGround = new System.Windows.Forms.PictureBox();
            this.picRoundedRec1 = new System.Windows.Forms.PictureBox();
            this.picRoundedRec2 = new System.Windows.Forms.PictureBox();
            this.picRoundedRec3 = new System.Windows.Forms.PictureBox();
            this.picRoundedRec4 = new System.Windows.Forms.PictureBox();
            this.lbQuote = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.btnMBTI = new CustomControls.RJControls.RJButton();
            this.btnPomo = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMBTI)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPomo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoundedRec1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoundedRec2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoundedRec3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoundedRec4)).BeginInit();
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
            this.lbTitle.Location = new System.Drawing.Point(440, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(260, 31);
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
            this.lbSubTitle.Location = new System.Drawing.Point(455, 47);
            this.lbSubTitle.Name = "lbSubTitle";
            this.lbSubTitle.Size = new System.Drawing.Size(227, 20);
            this.lbSubTitle.TabIndex = 3;
            this.lbSubTitle.Text = "Kỳ thi THPT Quốc Gia 2022";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 162);
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
            this.lbDays.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDays.ForeColor = System.Drawing.Color.White;
            this.lbDays.Location = new System.Drawing.Point(293, 114);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(86, 46);
            this.lbDays.TabIndex = 0;
            this.lbDays.Text = "100";
            this.lbDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(460, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
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
            this.label3.Location = new System.Drawing.Point(604, 162);
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
            this.lbMins.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMins.ForeColor = System.Drawing.Color.White;
            this.lbMins.Location = new System.Drawing.Point(601, 114);
            this.lbMins.Name = "lbMins";
            this.lbMins.Size = new System.Drawing.Size(64, 46);
            this.lbMins.TabIndex = 2;
            this.lbMins.Text = "60";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(752, 162);
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
            this.lbHours.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHours.ForeColor = System.Drawing.Color.White;
            this.lbHours.Location = new System.Drawing.Point(454, 114);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(64, 46);
            this.lbHours.TabIndex = 3;
            this.lbHours.Text = "24";
            this.lbHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSec
            // 
            this.lbSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSec.AutoSize = true;
            this.lbSec.BackColor = System.Drawing.Color.Transparent;
            this.lbSec.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSec.ForeColor = System.Drawing.Color.White;
            this.lbSec.Location = new System.Drawing.Point(749, 114);
            this.lbSec.Name = "lbSec";
            this.lbSec.Size = new System.Drawing.Size(64, 46);
            this.lbSec.TabIndex = 2;
            this.lbSec.Text = "60";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::RoadToUni.Properties.Resources.green_panel;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnMBTI);
            this.panel1.Controls.Add(this.picMBTI);
            this.panel1.Location = new System.Drawing.Point(914, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 192);
            this.panel1.TabIndex = 12;
            // 
            // picMBTI
            // 
            this.picMBTI.BackColor = System.Drawing.Color.Transparent;
            this.picMBTI.Image = ((System.Drawing.Image)(resources.GetObject("picMBTI.Image")));
            this.picMBTI.Location = new System.Drawing.Point(-17, 11);
            this.picMBTI.Name = "picMBTI";
            this.picMBTI.Size = new System.Drawing.Size(201, 125);
            this.picMBTI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMBTI.TabIndex = 11;
            this.picMBTI.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnPomo);
            this.panel2.Controls.Add(this.picPomo);
            this.panel2.Location = new System.Drawing.Point(744, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 192);
            this.panel2.TabIndex = 11;
            // 
            // picPomo
            // 
            this.picPomo.BackColor = System.Drawing.Color.Transparent;
            this.picPomo.Image = ((System.Drawing.Image)(resources.GetObject("picPomo.Image")));
            this.picPomo.Location = new System.Drawing.Point(-11, 13);
            this.picPomo.Name = "picPomo";
            this.picPomo.Size = new System.Drawing.Size(201, 125);
            this.picPomo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPomo.TabIndex = 11;
            this.picPomo.TabStop = false;
            // 
            // topBackGround
            // 
            this.topBackGround.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBackGround.BackColor = System.Drawing.Color.Transparent;
            this.topBackGround.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topBackGround.BackgroundImage")));
            this.topBackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topBackGround.Location = new System.Drawing.Point(12, 12);
            this.topBackGround.Name = "topBackGround";
            this.topBackGround.Size = new System.Drawing.Size(1084, 330);
            this.topBackGround.TabIndex = 9;
            this.topBackGround.TabStop = false;
            // 
            // picRoundedRec1
            // 
            this.picRoundedRec1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picRoundedRec1.BackColor = System.Drawing.Color.Transparent;
            this.picRoundedRec1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRoundedRec1.BackgroundImage")));
            this.picRoundedRec1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRoundedRec1.Location = new System.Drawing.Point(264, 74);
            this.picRoundedRec1.Name = "picRoundedRec1";
            this.picRoundedRec1.Size = new System.Drawing.Size(142, 137);
            this.picRoundedRec1.TabIndex = 5;
            this.picRoundedRec1.TabStop = false;
            // 
            // picRoundedRec2
            // 
            this.picRoundedRec2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picRoundedRec2.BackColor = System.Drawing.Color.Transparent;
            this.picRoundedRec2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRoundedRec2.BackgroundImage")));
            this.picRoundedRec2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRoundedRec2.Location = new System.Drawing.Point(412, 74);
            this.picRoundedRec2.Name = "picRoundedRec2";
            this.picRoundedRec2.Size = new System.Drawing.Size(142, 137);
            this.picRoundedRec2.TabIndex = 6;
            this.picRoundedRec2.TabStop = false;
            // 
            // picRoundedRec3
            // 
            this.picRoundedRec3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picRoundedRec3.BackColor = System.Drawing.Color.Transparent;
            this.picRoundedRec3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRoundedRec3.BackgroundImage")));
            this.picRoundedRec3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRoundedRec3.Location = new System.Drawing.Point(560, 74);
            this.picRoundedRec3.Name = "picRoundedRec3";
            this.picRoundedRec3.Size = new System.Drawing.Size(142, 137);
            this.picRoundedRec3.TabIndex = 7;
            this.picRoundedRec3.TabStop = false;
            // 
            // picRoundedRec4
            // 
            this.picRoundedRec4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picRoundedRec4.BackColor = System.Drawing.Color.Transparent;
            this.picRoundedRec4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRoundedRec4.BackgroundImage")));
            this.picRoundedRec4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRoundedRec4.Location = new System.Drawing.Point(708, 74);
            this.picRoundedRec4.Name = "picRoundedRec4";
            this.picRoundedRec4.Size = new System.Drawing.Size(142, 137);
            this.picRoundedRec4.TabIndex = 8;
            this.picRoundedRec4.TabStop = false;
            // 
            // lbQuote
            // 
            this.lbQuote.AutoSize = true;
            this.lbQuote.BackColor = System.Drawing.Color.White;
            this.lbQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuote.ForeColor = System.Drawing.Color.White;
            this.lbQuote.Location = new System.Drawing.Point(359, 237);
            this.lbQuote.Name = "lbQuote";
            this.lbQuote.Size = new System.Drawing.Size(668, 29);
            this.lbQuote.TabIndex = 13;
            this.lbQuote.Text = "Chỉ những người dám thất bại lớn mới đạt được thành công lớn";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.BackColor = System.Drawing.Color.White;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.ForeColor = System.Drawing.Color.White;
            this.lbAuthor.Location = new System.Drawing.Point(704, 275);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(186, 24);
            this.lbAuthor.TabIndex = 14;
            this.lbAuthor.Text = "Robert F. Kennedy";
            // 
            // btnMBTI
            // 
            this.btnMBTI.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnMBTI.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.btnMBTI.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMBTI.BorderRadius = 10;
            this.btnMBTI.BorderSize = 0;
            this.btnMBTI.FlatAppearance.BorderSize = 0;
            this.btnMBTI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMBTI.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMBTI.ForeColor = System.Drawing.Color.White;
            this.btnMBTI.Location = new System.Drawing.Point(18, 135);
            this.btnMBTI.Name = "btnMBTI";
            this.btnMBTI.Size = new System.Drawing.Size(144, 40);
            this.btnMBTI.TabIndex = 0;
            this.btnMBTI.Text = "MBTI";
            this.btnMBTI.TextColor = System.Drawing.Color.White;
            this.btnMBTI.UseVisualStyleBackColor = false;
            this.btnMBTI.Click += new System.EventHandler(this.btnMBTI_Click);
            // 
            // btnPomo
            // 
            this.btnPomo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnPomo.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.btnPomo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPomo.BorderRadius = 10;
            this.btnPomo.BorderSize = 0;
            this.btnPomo.FlatAppearance.BorderSize = 0;
            this.btnPomo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPomo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomo.ForeColor = System.Drawing.Color.White;
            this.btnPomo.Location = new System.Drawing.Point(18, 135);
            this.btnPomo.Name = "btnPomo";
            this.btnPomo.Size = new System.Drawing.Size(144, 40);
            this.btnPomo.TabIndex = 0;
            this.btnPomo.Text = "Pomodoro";
            this.btnPomo.TextColor = System.Drawing.Color.White;
            this.btnPomo.UseVisualStyleBackColor = false;
            this.btnPomo.Click += new System.EventHandler(this.btnPomo_Click);
            // 
            // fCountDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 611);
            this.ControlBox = false;
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbQuote);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMBTI)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPomo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoundedRec1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoundedRec2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoundedRec3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoundedRec4)).EndInit();
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
        private CustomControls.RJControls.RJButton btnPomo;
        private System.Windows.Forms.PictureBox picPomo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton btnMBTI;
        private System.Windows.Forms.PictureBox picMBTI;
        private System.Windows.Forms.Label lbQuote;
        private System.Windows.Forms.Label lbAuthor;
    }
}