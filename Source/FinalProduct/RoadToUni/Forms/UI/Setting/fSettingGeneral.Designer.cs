
namespace RoadToUni.Forms.UI.Setting
{
    partial class fSettingGeneral
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
            this.lbTile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.picCountDown = new System.Windows.Forms.PictureBox();
            this.btnSetDefault = new CustomControls.RJControls.RJButton();
            this.btnChangeBackGround = new CustomControls.RJControls.RJButton();
            this.gradientPanel1 = new RoadToUni.Forms.UI.GradientPanel();
            this.btnChangeName = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.picCountDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên: ";
            // 
            // lbTile
            // 
            this.lbTile.AutoSize = true;
            this.lbTile.Font = new System.Drawing.Font("Anton", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTile.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbTile.Location = new System.Drawing.Point(8, 9);
            this.lbTile.Name = "lbTile";
            this.lbTile.Size = new System.Drawing.Size(218, 61);
            this.lbTile.TabIndex = 1;
            this.lbTile.Text = "Cài đặt chung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ảnh nền đếm ngược";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.Black;
            this.lbUserName.Location = new System.Drawing.Point(66, 94);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(81, 25);
            this.lbUserName.TabIndex = 3;
            this.lbUserName.Text = "Meow";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picCountDown
            // 
            this.picCountDown.Location = new System.Drawing.Point(16, 244);
            this.picCountDown.Name = "picCountDown";
            this.picCountDown.Size = new System.Drawing.Size(230, 154);
            this.picCountDown.TabIndex = 6;
            this.picCountDown.TabStop = false;
            // 
            // btnSetDefault
            // 
            this.btnSetDefault.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSetDefault.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSetDefault.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSetDefault.BorderRadius = 6;
            this.btnSetDefault.BorderSize = 0;
            this.btnSetDefault.FlatAppearance.BorderSize = 0;
            this.btnSetDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDefault.ForeColor = System.Drawing.Color.White;
            this.btnSetDefault.Location = new System.Drawing.Point(273, 314);
            this.btnSetDefault.Name = "btnSetDefault";
            this.btnSetDefault.Size = new System.Drawing.Size(99, 39);
            this.btnSetDefault.TabIndex = 8;
            this.btnSetDefault.Text = "Mặc định";
            this.btnSetDefault.TextColor = System.Drawing.Color.White;
            this.btnSetDefault.UseVisualStyleBackColor = false;
            // 
            // btnChangeBackGround
            // 
            this.btnChangeBackGround.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnChangeBackGround.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btnChangeBackGround.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChangeBackGround.BorderRadius = 6;
            this.btnChangeBackGround.BorderSize = 0;
            this.btnChangeBackGround.FlatAppearance.BorderSize = 0;
            this.btnChangeBackGround.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeBackGround.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeBackGround.ForeColor = System.Drawing.Color.White;
            this.btnChangeBackGround.Location = new System.Drawing.Point(273, 359);
            this.btnChangeBackGround.Name = "btnChangeBackGround";
            this.btnChangeBackGround.Size = new System.Drawing.Size(99, 39);
            this.btnChangeBackGround.TabIndex = 7;
            this.btnChangeBackGround.Text = "Đổi";
            this.btnChangeBackGround.TextColor = System.Drawing.Color.White;
            this.btnChangeBackGround.UseVisualStyleBackColor = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Location = new System.Drawing.Point(16, 66);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(200, 2);
            this.gradientPanel1.TabIndex = 5;
            this.gradientPanel1.TopColor = System.Drawing.Color.Empty;
            // 
            // btnChangeName
            // 
            this.btnChangeName.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnChangeName.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.btnChangeName.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChangeName.BorderRadius = 6;
            this.btnChangeName.BorderSize = 0;
            this.btnChangeName.FlatAppearance.BorderSize = 0;
            this.btnChangeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeName.ForeColor = System.Drawing.Color.White;
            this.btnChangeName.Location = new System.Drawing.Point(16, 122);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(86, 32);
            this.btnChangeName.TabIndex = 4;
            this.btnChangeName.Text = "Đổi tên:";
            this.btnChangeName.TextColor = System.Drawing.Color.White;
            this.btnChangeName.UseVisualStyleBackColor = false;
            // 
            // fSettingGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 610);
            this.Controls.Add(this.btnSetDefault);
            this.Controls.Add(this.btnChangeBackGround);
            this.Controls.Add(this.picCountDown);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTile);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSettingGeneral";
            this.Text = "fSettingGeneral";
            this.Load += new System.EventHandler(this.fSettingGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCountDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUserName;
        private CustomControls.RJControls.RJButton btnChangeName;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox picCountDown;
        private CustomControls.RJControls.RJButton btnChangeBackGround;
        private CustomControls.RJControls.RJButton btnSetDefault;
    }
}