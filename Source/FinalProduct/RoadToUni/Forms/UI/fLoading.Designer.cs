
namespace RoadToUni.Forms.UI
{
    partial class fLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLoading));
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lowConnect = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // picLoad
            // 
            this.picLoad.BackColor = System.Drawing.Color.Transparent;
            this.picLoad.Image = ((System.Drawing.Image)(resources.GetObject("picLoad.Image")));
            this.picLoad.Location = new System.Drawing.Point(209, 286);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(50, 50);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoad.TabIndex = 0;
            this.picLoad.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lowConnect
            // 
            this.lowConnect.Interval = 10000;
            this.lowConnect.Tick += new System.EventHandler(this.lowConnect_Tick);
            // 
            // fLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(492, 347);
            this.ControlBox = false;
            this.Controls.Add(this.picLoad);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fLoading_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fLoading_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLoad;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer lowConnect;
    }
}