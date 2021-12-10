
namespace ChoosingMajor
{
    partial class SecondUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondUI));
            this.pbxTitle = new System.Windows.Forms.PictureBox();
            this.lblTitle = new ChoosingMajor.CustomLabel();
            this.fpnlNganh = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
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
            this.pbxTitle.TabIndex = 2;
            this.pbxTitle.TabStop = false;
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
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Đâu là lĩnh vực mà bạn quan tâm?";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fpnlNganh
            // 
            this.fpnlNganh.AutoScroll = true;
            this.fpnlNganh.BackColor = System.Drawing.Color.Transparent;
            this.fpnlNganh.Location = new System.Drawing.Point(147, 134);
            this.fpnlNganh.Name = "fpnlNganh";
            this.fpnlNganh.Size = new System.Drawing.Size(802, 477);
            this.fpnlNganh.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 72);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SecondUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChoosingMajor.Properties.Resources.bluebg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 611);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.fpnlNganh);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecondUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecondUI";
            this.Load += new System.EventHandler(this.SecondUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxTitle;
        private CustomLabel lblTitle;
        private System.Windows.Forms.FlowLayoutPanel fpnlNganh;
        private System.Windows.Forms.Button btnBack;
    }
}