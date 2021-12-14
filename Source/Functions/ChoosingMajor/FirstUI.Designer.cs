
namespace ChoosingMajor
{
    partial class FirstUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstUI));
            this.pbxTitle = new System.Windows.Forms.PictureBox();
            this.fpnlNhomNganh = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new ChoosingMajor.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxTitle
            // 
            this.pbxTitle.BackColor = System.Drawing.Color.Transparent;
            this.pbxTitle.Image = ((System.Drawing.Image)(resources.GetObject("pbxTitle.Image")));
            this.pbxTitle.Location = new System.Drawing.Point(192, -105);
            this.pbxTitle.Name = "pbxTitle";
            this.pbxTitle.Size = new System.Drawing.Size(700, 316);
            this.pbxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTitle.TabIndex = 1;
            this.pbxTitle.TabStop = false;
            // 
            // fpnlNhomNganh
            // 
            this.fpnlNhomNganh.AutoScroll = true;
            this.fpnlNhomNganh.BackColor = System.Drawing.Color.Transparent;
            this.fpnlNhomNganh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fpnlNhomNganh.Location = new System.Drawing.Point(0, 134);
            this.fpnlNhomNganh.Margin = new System.Windows.Forms.Padding(0);
            this.fpnlNhomNganh.Name = "fpnlNhomNganh";
            this.fpnlNhomNganh.Size = new System.Drawing.Size(1108, 477);
            this.fpnlNhomNganh.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(309, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.OutlineForeColor = System.Drawing.Color.Black;
            this.lblTitle.OutlineWidth = 2F;
            this.lblTitle.Size = new System.Drawing.Size(490, 34);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Đâu là lĩnh vực mà bạn quan tâm?";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChoosingMajor.Properties.Resources.bluebg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 611);
            this.ControlBox = false;
            this.Controls.Add(this.fpnlNhomNganh);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FirstUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxTitle;
        private CustomLabel lblTitle;
        private System.Windows.Forms.FlowLayoutPanel fpnlNhomNganh;
    }
}

