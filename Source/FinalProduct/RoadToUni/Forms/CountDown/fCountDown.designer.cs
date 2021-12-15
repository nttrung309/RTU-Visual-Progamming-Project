
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
            this.lbQuote = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.timerNextQuote = new System.Windows.Forms.Timer(this.components);
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn4 = new System.Windows.Forms.RadioButton();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeskTools = new CustomControls.RJControls.RJButton();
            this.btnDeskSearch = new CustomControls.RJControls.RJButton();
            this.btnSupport = new CustomControls.RJControls.RJButton();
            this.picRoundedRec1 = new System.Windows.Forms.PictureBox();
            this.picRoundedRec2 = new System.Windows.Forms.PictureBox();
            this.picRoundedRec3 = new System.Windows.Forms.PictureBox();
            this.picRoundedRec4 = new System.Windows.Forms.PictureBox();
            this.tmSearch = new System.Windows.Forms.Timer(this.components);
            this.tmSupport = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
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
            // lbQuote
            // 
            this.lbQuote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbQuote.AutoSize = true;
            this.lbQuote.BackColor = System.Drawing.Color.White;
            this.lbQuote.Font = new System.Drawing.Font("Pacifico", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuote.ForeColor = System.Drawing.Color.White;
            this.lbQuote.Location = new System.Drawing.Point(359, 204);
            this.lbQuote.Name = "lbQuote";
            this.lbQuote.Size = new System.Drawing.Size(617, 46);
            this.lbQuote.TabIndex = 13;
            this.lbQuote.Text = "Chỉ những người dám thất bại lớn mới đạt được thành công lớn";
            this.lbQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbQuote.Click += new System.EventHandler(this.lbQuote_Click);
            // 
            // lbAuthor
            // 
            this.lbAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.BackColor = System.Drawing.Color.White;
            this.lbAuthor.Font = new System.Drawing.Font("Lobster", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.ForeColor = System.Drawing.Color.White;
            this.lbAuthor.Location = new System.Drawing.Point(704, 267);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(144, 28);
            this.lbAuthor.TabIndex = 14;
            this.lbAuthor.Text = "Robert F. Kennedy";
            this.lbAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAuthor.Click += new System.EventHandler(this.lbAuthor_Click);
            // 
            // timerNextQuote
            // 
            this.timerNextQuote.Interval = 20000;
            this.timerNextQuote.Tick += new System.EventHandler(this.timerNextQuote_Tick);
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Checked = true;
            this.rbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn1.Location = new System.Drawing.Point(3, 3);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(14, 13);
            this.rbtn1.TabIndex = 18;
            this.rbtn1.TabStop = true;
            this.rbtn1.UseVisualStyleBackColor = true;
            this.rbtn1.CheckedChanged += new System.EventHandler(this.rbtn1_CheckedChanged);
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn2.Location = new System.Drawing.Point(23, 3);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(14, 13);
            this.rbtn2.TabIndex = 19;
            this.rbtn2.UseVisualStyleBackColor = true;
            // 
            // rbtn4
            // 
            this.rbtn4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtn4.AutoSize = true;
            this.rbtn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn4.Location = new System.Drawing.Point(573, 590);
            this.rbtn4.Name = "rbtn4";
            this.rbtn4.Size = new System.Drawing.Size(14, 13);
            this.rbtn4.TabIndex = 21;
            this.rbtn4.UseVisualStyleBackColor = true;
            // 
            // rbtn3
            // 
            this.rbtn3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtn3.AutoSize = true;
            this.rbtn3.Checked = true;
            this.rbtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn3.Location = new System.Drawing.Point(553, 590);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(14, 13);
            this.rbtn3.TabIndex = 20;
            this.rbtn3.TabStop = true;
            this.rbtn3.UseVisualStyleBackColor = true;
            this.rbtn3.CheckedChanged += new System.EventHandler(this.btn3_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn2);
            this.panel1.Controls.Add(this.rbtn1);
            this.panel1.Location = new System.Drawing.Point(93, 588);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 31);
            this.panel1.TabIndex = 26;
            // 
            // btnDeskTools
            // 
            this.btnDeskTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeskTools.BackColor = System.Drawing.Color.Snow;
            this.btnDeskTools.BackgroundColor = System.Drawing.Color.Snow;
            this.btnDeskTools.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeskTools.BackgroundImage")));
            this.btnDeskTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeskTools.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnDeskTools.BorderRadius = 20;
            this.btnDeskTools.BorderSize = 2;
            this.btnDeskTools.FlatAppearance.BorderSize = 0;
            this.btnDeskTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeskTools.ForeColor = System.Drawing.Color.White;
            this.btnDeskTools.Location = new System.Drawing.Point(900, 377);
            this.btnDeskTools.Name = "btnDeskTools";
            this.btnDeskTools.Size = new System.Drawing.Size(196, 202);
            this.btnDeskTools.TabIndex = 17;
            this.btnDeskTools.TextColor = System.Drawing.Color.White;
            this.btnDeskTools.UseVisualStyleBackColor = false;
            this.btnDeskTools.Click += new System.EventHandler(this.btnDeskTools_Click);
            // 
            // btnDeskSearch
            // 
            this.btnDeskSearch.BackColor = System.Drawing.Color.Snow;
            this.btnDeskSearch.BackgroundColor = System.Drawing.Color.Snow;
            this.btnDeskSearch.BackgroundImage = global::RoadToUni.Properties.Resources.countdown_score;
            this.btnDeskSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeskSearch.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeskSearch.BorderRadius = 20;
            this.btnDeskSearch.BorderSize = 0;
            this.btnDeskSearch.FlatAppearance.BorderSize = 0;
            this.btnDeskSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeskSearch.ForeColor = System.Drawing.Color.White;
            this.btnDeskSearch.Location = new System.Drawing.Point(12, 377);
            this.btnDeskSearch.Name = "btnDeskSearch";
            this.btnDeskSearch.Size = new System.Drawing.Size(211, 202);
            this.btnDeskSearch.TabIndex = 16;
            this.btnDeskSearch.TextColor = System.Drawing.Color.White;
            this.btnDeskSearch.UseVisualStyleBackColor = false;
            this.btnDeskSearch.Click += new System.EventHandler(this.btnDeskSearch_Click);
            // 
            // btnSupport
            // 
            this.btnSupport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupport.BackColor = System.Drawing.Color.Snow;
            this.btnSupport.BackgroundColor = System.Drawing.Color.Snow;
            this.btnSupport.BackgroundImage = global::RoadToUni.Properties.Resources.countdown_schoolSearch;
            this.btnSupport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSupport.BorderRadius = 20;
            this.btnSupport.BorderSize = 0;
            this.btnSupport.FlatAppearance.BorderSize = 0;
            this.btnSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupport.ForeColor = System.Drawing.Color.White;
            this.btnSupport.Location = new System.Drawing.Point(236, 377);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(658, 202);
            this.btnSupport.TabIndex = 15;
            this.btnSupport.TextColor = System.Drawing.Color.White;
            this.btnSupport.UseVisualStyleBackColor = false;
            this.btnSupport.Click += new System.EventHandler(this.rjButton1_Click);
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
            // tmSearch
            // 
            this.tmSearch.Interval = 4000;
            this.tmSearch.Tick += new System.EventHandler(this.tmSearch_Tick);
            // 
            // tmSupport
            // 
            this.tmSupport.Interval = 4000;
            this.tmSupport.Tick += new System.EventHandler(this.tmSupport_Tick);
            // 
            // fCountDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 611);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbtn4);
            this.Controls.Add(this.rbtn3);
            this.Controls.Add(this.btnDeskTools);
            this.Controls.Add(this.btnDeskSearch);
            this.Controls.Add(this.btnSupport);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbQuote);
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
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label lbQuote;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Timer timerNextQuote;
        private CustomControls.RJControls.RJButton btnSupport;
        private CustomControls.RJControls.RJButton btnDeskSearch;
        private CustomControls.RJControls.RJButton btnDeskTools;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn4;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmSearch;
        private System.Windows.Forms.Timer tmSupport;
    }
}