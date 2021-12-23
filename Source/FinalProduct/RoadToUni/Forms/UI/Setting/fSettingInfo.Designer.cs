
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.btnCheckUpdate = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Lobster", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Violet;
            this.lbTitle.Location = new System.Drawing.Point(72, 37);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(252, 72);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Road to Uni";
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yanone Kaffeesatz", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 121);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ứng dụng hỗ trợ chọn trường cùng với một số công cụ liên quan, giúp cho việc định" +
    " hướng tương lai dễ dàng hơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Anton", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(135, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giới thiệu";
            // 
            // fSettingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 610);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckUpdate);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSettingInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbVersion;
        private CustomControls.RJControls.RJButton btnCheckUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}