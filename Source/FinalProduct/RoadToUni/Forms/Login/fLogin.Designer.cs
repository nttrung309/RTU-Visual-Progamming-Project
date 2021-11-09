
namespace RoadToUni.Forms.Login
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.pbxSlide = new System.Windows.Forms.PictureBox();
            this.btnLeftArrow = new System.Windows.Forms.Button();
            this.btnRightArrow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlImageSlider = new System.Windows.Forms.Panel();
            this.rbtn5 = new System.Windows.Forms.RadioButton();
            this.rbtn4 = new System.Windows.Forms.RadioButton();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblAccountExist = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.cbxShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlide)).BeginInit();
            this.pnlImageSlider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxSlide
            // 
            this.pbxSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxSlide.Image = global::RoadToUni.Properties.Resources.login_1;
            this.pbxSlide.ImageLocation = "";
            this.pbxSlide.Location = new System.Drawing.Point(0, 0);
            this.pbxSlide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxSlide.Name = "pbxSlide";
            this.pbxSlide.Size = new System.Drawing.Size(647, 533);
            this.pbxSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSlide.TabIndex = 0;
            this.pbxSlide.TabStop = false;
            // 
            // btnLeftArrow
            // 
            this.btnLeftArrow.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnLeftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLeftArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeftArrow.FlatAppearance.BorderSize = 0;
            this.btnLeftArrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnLeftArrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLeftArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftArrow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLeftArrow.Image = global::RoadToUni.Properties.Resources.back_24px;
            this.btnLeftArrow.Location = new System.Drawing.Point(1, 236);
            this.btnLeftArrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeftArrow.Name = "btnLeftArrow";
            this.btnLeftArrow.Size = new System.Drawing.Size(26, 85);
            this.btnLeftArrow.TabIndex = 1;
            this.btnLeftArrow.TabStop = false;
            this.btnLeftArrow.UseVisualStyleBackColor = false;
            this.btnLeftArrow.Click += new System.EventHandler(this.btnLeftArrow_Click);
            // 
            // btnRightArrow
            // 
            this.btnRightArrow.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnRightArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRightArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRightArrow.FlatAppearance.BorderSize = 0;
            this.btnRightArrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnRightArrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRightArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightArrow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRightArrow.Image = global::RoadToUni.Properties.Resources.next_24px;
            this.btnRightArrow.Location = new System.Drawing.Point(620, 236);
            this.btnRightArrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRightArrow.Name = "btnRightArrow";
            this.btnRightArrow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRightArrow.Size = new System.Drawing.Size(26, 85);
            this.btnRightArrow.TabIndex = 2;
            this.btnRightArrow.TabStop = false;
            this.btnRightArrow.UseVisualStyleBackColor = false;
            this.btnRightArrow.Click += new System.EventHandler(this.btnRightArrow_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Image = global::RoadToUni.Properties.Resources.close_window_26px;
            this.btnClose.Location = new System.Drawing.Point(968, 16);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(45, 47);
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimize.Image = global::RoadToUni.Properties.Resources.minimize_window_26px;
            this.btnMinimize.Location = new System.Drawing.Point(915, 16);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMinimize.Size = new System.Drawing.Size(45, 47);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlImageSlider
            // 
            this.pnlImageSlider.BackColor = System.Drawing.Color.Transparent;
            this.pnlImageSlider.Controls.Add(this.rbtn5);
            this.pnlImageSlider.Controls.Add(this.rbtn4);
            this.pnlImageSlider.Controls.Add(this.rbtn3);
            this.pnlImageSlider.Controls.Add(this.rbtn2);
            this.pnlImageSlider.Controls.Add(this.rbtn1);
            this.pnlImageSlider.Location = new System.Drawing.Point(270, 509);
            this.pnlImageSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlImageSlider.Name = "pnlImageSlider";
            this.pnlImageSlider.Size = new System.Drawing.Size(105, 23);
            this.pnlImageSlider.TabIndex = 6;
            // 
            // rbtn5
            // 
            this.rbtn5.AutoSize = true;
            this.rbtn5.BackColor = System.Drawing.Color.Transparent;
            this.rbtn5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtn5.Location = new System.Drawing.Point(85, 3);
            this.rbtn5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn5.Name = "rbtn5";
            this.rbtn5.Size = new System.Drawing.Size(21, 20);
            this.rbtn5.TabIndex = 11;
            this.rbtn5.UseVisualStyleBackColor = false;
            this.rbtn5.CheckedChanged += new System.EventHandler(this.rbtn3_CheckedChanged);
            // 
            // rbtn4
            // 
            this.rbtn4.AutoSize = true;
            this.rbtn4.BackColor = System.Drawing.Color.Transparent;
            this.rbtn4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtn4.Location = new System.Drawing.Point(64, 3);
            this.rbtn4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn4.Name = "rbtn4";
            this.rbtn4.Size = new System.Drawing.Size(21, 20);
            this.rbtn4.TabIndex = 10;
            this.rbtn4.UseVisualStyleBackColor = false;
            this.rbtn4.CheckedChanged += new System.EventHandler(this.rbtn3_CheckedChanged);
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.BackColor = System.Drawing.Color.Transparent;
            this.rbtn3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtn3.Location = new System.Drawing.Point(44, 3);
            this.rbtn3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(21, 20);
            this.rbtn3.TabIndex = 9;
            this.rbtn3.UseVisualStyleBackColor = false;
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.BackColor = System.Drawing.Color.Transparent;
            this.rbtn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtn2.Location = new System.Drawing.Point(23, 3);
            this.rbtn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(21, 20);
            this.rbtn2.TabIndex = 8;
            this.rbtn2.UseVisualStyleBackColor = false;
            this.rbtn2.CheckedChanged += new System.EventHandler(this.rbtn3_CheckedChanged);
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.BackColor = System.Drawing.Color.Transparent;
            this.rbtn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtn1.Location = new System.Drawing.Point(3, 3);
            this.rbtn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(21, 20);
            this.rbtn1.TabIndex = 7;
            this.rbtn1.UseVisualStyleBackColor = false;
            this.rbtn1.CheckedChanged += new System.EventHandler(this.rbtn3_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbxLogo.Image = global::RoadToUni.Properties.Resources.image_psd__1_;
            this.pbxLogo.Location = new System.Drawing.Point(703, 65);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(278, 132);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 7;
            this.pbxLogo.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(724, 212);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(129, 32);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(730, 248);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(229, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(730, 319);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(229, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(724, 283);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(123, 32);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Location = new System.Drawing.Point(730, 388);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(230, 54);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblAccountExist
            // 
            this.lblAccountExist.AutoSize = true;
            this.lblAccountExist.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAccountExist.ForeColor = System.Drawing.Color.White;
            this.lblAccountExist.Location = new System.Drawing.Point(725, 446);
            this.lblAccountExist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountExist.Name = "lblAccountExist";
            this.lblAccountExist.Size = new System.Drawing.Size(233, 28);
            this.lblAccountExist.TabIndex = 12;
            this.lblAccountExist.Text = "Don\'t have an account?";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Yellow;
            this.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegister.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.Black;
            this.lblRegister.Location = new System.Drawing.Point(730, 479);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(98, 30);
            this.lblRegister.TabIndex = 5;
            this.lblRegister.Text = "Register";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // cbxShowPassword
            // 
            this.cbxShowPassword.AutoSize = true;
            this.cbxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxShowPassword.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.cbxShowPassword.ForeColor = System.Drawing.Color.White;
            this.cbxShowPassword.Location = new System.Drawing.Point(730, 359);
            this.cbxShowPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxShowPassword.Name = "cbxShowPassword";
            this.cbxShowPassword.Size = new System.Drawing.Size(164, 29);
            this.cbxShowPassword.TabIndex = 3;
            this.cbxShowPassword.Text = "Show password";
            this.cbxShowPassword.UseVisualStyleBackColor = true;
            this.cbxShowPassword.CheckedChanged += new System.EventHandler(this.cbxShowPassword_CheckedChanged);
            // 
            // fLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1029, 533);
            this.Controls.Add(this.cbxShowPassword);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblAccountExist);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.pnlImageSlider);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRightArrow);
            this.Controls.Add(this.btnLeftArrow);
            this.Controls.Add(this.pbxSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlide)).EndInit();
            this.pnlImageSlider.ResumeLayout(false);
            this.pnlImageSlider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxSlide;
        private System.Windows.Forms.Button btnLeftArrow;
        private System.Windows.Forms.Button btnRightArrow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlImageSlider;
        private System.Windows.Forms.RadioButton rbtn5;
        private System.Windows.Forms.RadioButton rbtn4;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblAccountExist;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.CheckBox cbxShowPassword;
    }
}

