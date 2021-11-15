using System.Windows.Forms;
using System.Drawing;
namespace RoadToUni.Forms.UI
{
    partial class fUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUI));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.lbUser = new System.Windows.Forms.Label();
            this.ptBUser = new System.Windows.Forms.PictureBox();
            this.lbMenu = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new CustomControls.RJControls.RJButton();
            this.btnHome = new CustomControls.RJControls.RJButton();
            this.btnLogout = new CustomControls.RJControls.RJButton();
            this.btnSetting = new CustomControls.RJControls.RJButton();
            this.btnChoice = new CustomControls.RJControls.RJButton();
            this.btnPomo = new CustomControls.RJControls.RJButton();
            this.btnMenu = new CustomControls.RJControls.RJButton();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBUser)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMenu.Controls.Add(this.btnSearch);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.pnlMenuBar);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnSetting);
            this.pnlMenu.Controls.Add(this.btnChoice);
            this.pnlMenu.Controls.Add(this.btnPomo);
            this.pnlMenu.Controls.Add(this.lbUser);
            this.pnlMenu.Controls.Add(this.ptBUser);
            this.pnlMenu.Controls.Add(this.lbMenu);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(187, 637);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.BackColor = System.Drawing.Color.White;
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 188);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(8, 58);
            this.pnlMenuBar.TabIndex = 1;
            this.pnlMenuBar.Visible = false;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.Bisque;
            this.lbUser.Location = new System.Drawing.Point(20, 121);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(76, 24);
            this.lbUser.TabIndex = 3;
            this.lbUser.Text = "Chào: ";
            // 
            // ptBUser
            // 
            this.ptBUser.Image = global::RoadToUni.Properties.Resources.account;
            this.ptBUser.Location = new System.Drawing.Point(67, 67);
            this.ptBUser.Name = "ptBUser";
            this.ptBUser.Size = new System.Drawing.Size(49, 47);
            this.ptBUser.TabIndex = 2;
            this.ptBUser.TabStop = false;
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("Hobo Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.Color.White;
            this.lbMenu.Location = new System.Drawing.Point(39, 19);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(75, 30);
            this.lbMenu.TabIndex = 1;
            this.lbMenu.Text = "MENU";
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(187, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(981, 26);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Turquoise;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::RoadToUni.Properties.Resources.minimize;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.Location = new System.Drawing.Point(846, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 26);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::RoadToUni.Properties.Resources.maximize;
            this.btnMaximize.Location = new System.Drawing.Point(891, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 26);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Salmon;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::RoadToUni.Properties.Resources.close;
            this.btnExit.Location = new System.Drawing.Point(936, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 26);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::RoadToUni.Properties.Resources.explore;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(1, 250);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(184, 60);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Tag = "Tra cứu";
            this.btnSearch.Text = "Tra cứu";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHome.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHome.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnHome.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHome.BorderRadius = 10;
            this.btnHome.BorderSize = 0;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::RoadToUni.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(1, 190);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(184, 60);
            this.btnHome.TabIndex = 2;
            this.btnHome.Tag = "Home";
            this.btnHome.Text = "Home";
            this.btnHome.TextColor = System.Drawing.Color.White;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogout.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::RoadToUni.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 517);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(187, 60);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Tag = "Log out";
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSetting.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnSetting.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSetting.BorderRadius = 10;
            this.btnSetting.BorderSize = 0;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = global::RoadToUni.Properties.Resources.setting;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 577);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(187, 60);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.Tag = "Cài đặt";
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.TextColor = System.Drawing.Color.White;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnChoice
            // 
            this.btnChoice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnChoice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnChoice.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnChoice.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChoice.BorderRadius = 10;
            this.btnChoice.BorderSize = 0;
            this.btnChoice.FlatAppearance.BorderSize = 0;
            this.btnChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoice.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice.ForeColor = System.Drawing.Color.White;
            this.btnChoice.Image = global::RoadToUni.Properties.Resources.analyticsp;
            this.btnChoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoice.Location = new System.Drawing.Point(1, 370);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(184, 60);
            this.btnChoice.TabIndex = 6;
            this.btnChoice.Tag = "Trắc nghiệm tính cách";
            this.btnChoice.Text = "Trắc nghiệm tính cách";
            this.btnChoice.TextColor = System.Drawing.Color.White;
            this.btnChoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChoice.UseVisualStyleBackColor = false;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // btnPomo
            // 
            this.btnPomo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPomo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPomo.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnPomo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPomo.BorderRadius = 10;
            this.btnPomo.BorderSize = 0;
            this.btnPomo.FlatAppearance.BorderSize = 0;
            this.btnPomo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPomo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomo.ForeColor = System.Drawing.Color.White;
            this.btnPomo.Image = global::RoadToUni.Properties.Resources.alarm;
            this.btnPomo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPomo.Location = new System.Drawing.Point(1, 310);
            this.btnPomo.Name = "btnPomo";
            this.btnPomo.Size = new System.Drawing.Size(184, 60);
            this.btnPomo.TabIndex = 5;
            this.btnPomo.Tag = "Pomodoro";
            this.btnPomo.Text = "Pomodoro";
            this.btnPomo.TextColor = System.Drawing.Color.White;
            this.btnPomo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPomo.UseVisualStyleBackColor = false;
            this.btnPomo.Click += new System.EventHandler(this.btnPomo_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMenu.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMenu.BorderRadius = 10;
            this.btnMenu.BorderSize = 0;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::RoadToUni.Properties.Resources.menu;
            this.btnMenu.Location = new System.Drawing.Point(127, 1);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TextColor = System.Drawing.Color.White;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // fUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1168, 637);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fUI_Load);
            this.SizeChanged += new System.EventHandler(this.fMain_SizeChanged);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBUser)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private CustomControls.RJControls.RJButton btnMenu;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.PictureBox ptBUser;
        private System.Windows.Forms.Label lbUser;
        private CustomControls.RJControls.RJButton btnPomo;
        private CustomControls.RJControls.RJButton btnChoice;
        private CustomControls.RJControls.RJButton btnSetting;
        private System.Windows.Forms.Panel pnlMenuBar;
        private CustomControls.RJControls.RJButton btnLogout;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private CustomControls.RJControls.RJButton btnHome;
        private CustomControls.RJControls.RJButton btnSearch;
    }
}

