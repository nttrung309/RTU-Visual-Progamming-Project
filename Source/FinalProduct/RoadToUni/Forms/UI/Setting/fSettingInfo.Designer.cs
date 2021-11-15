
namespace RoadToUni.Forms.UI.Setting
{
    partial class fSettingInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.btnCheckUpdate = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(81, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Road to Uni";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbVersion.Location = new System.Drawing.Point(8, 574);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(128, 28);
            this.lbVersion.TabIndex = 1;
            this.lbVersion.Text = "Version: 1.0";
            // 
            // btnCheckUpdate
            // 
            this.btnCheckUpdate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCheckUpdate.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCheckUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCheckUpdate.BorderRadius = 8;
            this.btnCheckUpdate.BorderSize = 0;
            this.btnCheckUpdate.FlatAppearance.BorderSize = 0;
            this.btnCheckUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckUpdate.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCheckUpdate.Image = global::RoadToUni.Properties.Resources.update;
            this.btnCheckUpdate.Location = new System.Drawing.Point(255, 550);
            this.btnCheckUpdate.Name = "btnCheckUpdate";
            this.btnCheckUpdate.Size = new System.Drawing.Size(144, 54);
            this.btnCheckUpdate.TabIndex = 2;
            this.btnCheckUpdate.Text = "Check For Update!";
            this.btnCheckUpdate.TextColor = System.Drawing.Color.AliceBlue;
            this.btnCheckUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckUpdate.UseVisualStyleBackColor = false;
            this.btnCheckUpdate.Click += new System.EventHandler(this.btnCheckUpdate_Click);
            // 
            // fSettingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 610);
            this.ControlBox = false;
            this.Controls.Add(this.btnCheckUpdate);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSettingInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbVersion;
        private CustomControls.RJControls.RJButton btnCheckUpdate;
    }
}