
namespace JobSearch
{
    partial class Job
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJob = new System.Windows.Forms.Label();
            this.pboxJobs = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJob
            // 
            this.lblJob.BackColor = System.Drawing.Color.Transparent;
            this.lblJob.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblJob.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJob.ForeColor = System.Drawing.Color.White;
            this.lblJob.Location = new System.Drawing.Point(0, 150);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(300, 50);
            this.lblJob.TabIndex = 0;
            this.lblJob.Text = "label1";
            this.lblJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pboxJobs
            // 
            this.pboxJobs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pboxJobs.Location = new System.Drawing.Point(0, 0);
            this.pboxJobs.Margin = new System.Windows.Forms.Padding(0);
            this.pboxJobs.Name = "pboxJobs";
            this.pboxJobs.Size = new System.Drawing.Size(300, 150);
            this.pboxJobs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxJobs.TabIndex = 1;
            this.pboxJobs.TabStop = false;
            // 
            // Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.pboxJobs);
            this.Controls.Add(this.lblJob);
            this.Name = "Job";
            this.Size = new System.Drawing.Size(300, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pboxJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.PictureBox pboxJobs;
    }
}
