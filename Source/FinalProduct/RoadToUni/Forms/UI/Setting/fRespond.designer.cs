
namespace RoadToUni.Forms.UI.Setting
{
    partial class fRespond
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.ckboxPic = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChoosePic = new CustomControls.RJControls.RJButton();
            this.btnSend = new CustomControls.RJControls.RJButton();
            this.btnCancel = new CustomControls.RJControls.RJButton();
            this.txbContent = new CustomControls.RJControls.RJTextBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.label);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(405, 51);
            this.pnlTop.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label.Location = new System.Drawing.Point(103, 9);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(187, 33);
            this.label.TabIndex = 2;
            this.label.Text = "Gửi phản hồi";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // ckboxPic
            // 
            this.ckboxPic.AutoSize = true;
            this.ckboxPic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxPic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckboxPic.Location = new System.Drawing.Point(7, 276);
            this.ckboxPic.Margin = new System.Windows.Forms.Padding(2);
            this.ckboxPic.Name = "ckboxPic";
            this.ckboxPic.Size = new System.Drawing.Size(230, 23);
            this.ckboxPic.TabIndex = 3;
            this.ckboxPic.Text = "Gửi kèm ảnh chụp màn hình";
            this.ckboxPic.UseVisualStyleBackColor = true;
            this.ckboxPic.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 364);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnChoosePic
            // 
            this.btnChoosePic.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChoosePic.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChoosePic.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChoosePic.BorderRadius = 8;
            this.btnChoosePic.BorderSize = 0;
            this.btnChoosePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePic.ForeColor = System.Drawing.Color.White;
            this.btnChoosePic.Location = new System.Drawing.Point(259, 261);
            this.btnChoosePic.Margin = new System.Windows.Forms.Padding(2);
            this.btnChoosePic.Name = "btnChoosePic";
            this.btnChoosePic.Size = new System.Drawing.Size(139, 49);
            this.btnChoosePic.TabIndex = 7;
            this.btnChoosePic.Text = "Chọn hình ảnh";
            this.btnChoosePic.TextColor = System.Drawing.Color.White;
            this.btnChoosePic.UseVisualStyleBackColor = true;
            this.btnChoosePic.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSend.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.btnSend.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSend.BorderRadius = 8;
            this.btnSend.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Snow;
            this.btnSend.Location = new System.Drawing.Point(101, 316);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 40);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Gửi";
            this.btnSend.TextColor = System.Drawing.Color.Snow;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Salmon;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Snow;
            this.btnCancel.Location = new System.Drawing.Point(199, 316);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextColor = System.Drawing.Color.Snow;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbContent
            // 
            this.txbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbContent.AutoScroll = true;
            this.txbContent.BackColor = System.Drawing.SystemColors.Window;
            this.txbContent.BorderColor = System.Drawing.Color.Thistle;
            this.txbContent.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbContent.BorderRadius = 0;
            this.txbContent.BorderSize = 2;
            this.txbContent.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContent.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.txbContent.Location = new System.Drawing.Point(7, 55);
            this.txbContent.Margin = new System.Windows.Forms.Padding(2);
            this.txbContent.Multiline = true;
            this.txbContent.Name = "txbContent";
            this.txbContent.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbContent.PasswordChar = false;
            this.txbContent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbContent.PlaceholderText = "Gửi cho chúng tôi thông tin về lỗi mà bạn gặp phải trong quá trình sử dụng sản ph" +
    "ẩm, việc bạn mô tả càng chi tiết sẽ giúp chúng tôi nhanh chóng và dễ dàng sửa đư" +
    "ợc lỗi đó hơn, xin chân thành cám ơn.";
            this.txbContent.Size = new System.Drawing.Size(391, 200);
            this.txbContent.TabIndex = 2;
            this.txbContent.Texts = "";
            this.txbContent.UnderlinedStyle = false;
            // 
            // fRespond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 610);
            this.Controls.Add(this.btnChoosePic);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ckboxPic);
            this.Controls.Add(this.txbContent);
            this.Controls.Add(this.pnlTop);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fRespond";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label;
        private CustomControls.RJControls.RJTextBox txbContent;
        private System.Windows.Forms.CheckBox ckboxPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton btnCancel;
        private CustomControls.RJControls.RJButton btnSend;
        private CustomControls.RJControls.RJButton btnChoosePic;
    }
}

