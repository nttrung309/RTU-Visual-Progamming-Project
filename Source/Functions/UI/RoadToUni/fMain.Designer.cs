
namespace RoadToUni
{
    partial class fMain
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnChoice = new System.Windows.Forms.Button();
            this.btnPomo = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.ptBUser = new System.Windows.Forms.PictureBox();
            this.lbMenu = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMenu.Controls.Add(this.pnlMenuBar);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnSetting);
            this.pnlMenu.Controls.Add(this.btnChoice);
            this.pnlMenu.Controls.Add(this.btnPomo);
            this.pnlMenu.Controls.Add(this.btnSearch);
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
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 183);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(4, 65);
            this.pnlMenuBar.TabIndex = 1;
            this.pnlMenuBar.Visible = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::RoadToUni.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 183);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(187, 65);
            this.btnHome.TabIndex = 10;
            this.btnHome.Tag = "Home";
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::RoadToUni.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 507);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(187, 65);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Tag = "Log out";
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = global::RoadToUni.Properties.Resources.setting;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 572);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(187, 65);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.Tag = "Cài đặt";
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnChoice
            // 
            this.btnChoice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnChoice.FlatAppearance.BorderSize = 0;
            this.btnChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice.ForeColor = System.Drawing.Color.White;
            this.btnChoice.Image = global::RoadToUni.Properties.Resources.explore;
            this.btnChoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoice.Location = new System.Drawing.Point(0, 378);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(187, 65);
            this.btnChoice.TabIndex = 6;
            this.btnChoice.Tag = "Trắc nghiệm tính cách";
            this.btnChoice.Text = "Trắc nghiệm tính cách";
            this.btnChoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChoice.UseVisualStyleBackColor = false;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // btnPomo
            // 
            this.btnPomo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPomo.FlatAppearance.BorderSize = 0;
            this.btnPomo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPomo.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomo.ForeColor = System.Drawing.Color.White;
            this.btnPomo.Image = global::RoadToUni.Properties.Resources.alarm;
            this.btnPomo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPomo.Location = new System.Drawing.Point(0, 313);
            this.btnPomo.Name = "btnPomo";
            this.btnPomo.Size = new System.Drawing.Size(202, 65);
            this.btnPomo.TabIndex = 5;
            this.btnPomo.Tag = "Pomodoro";
            this.btnPomo.Text = "Pomodoro";
            this.btnPomo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPomo.UseVisualStyleBackColor = false;
            this.btnPomo.Click += new System.EventHandler(this.btnPomo_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::RoadToUni.Properties.Resources.analyticsp;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 248);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(187, 65);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Tag = "Tra cứu";
            this.btnSearch.Text = "Tra cứu";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.Pink;
            this.lbUser.Location = new System.Drawing.Point(60, 116);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(69, 22);
            this.lbUser.TabIndex = 3;
            this.lbUser.Text = "Admin";
            // 
            // ptBUser
            // 
            this.ptBUser.Image = global::RoadToUni.Properties.Resources.account;
            this.ptBUser.Location = new System.Drawing.Point(70, 66);
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
            this.lbMenu.Location = new System.Drawing.Point(39, 17);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(75, 30);
            this.lbMenu.TabIndex = 1;
            this.lbMenu.Text = "MENU";
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::RoadToUni.Properties.Resources.menu;
            this.btnMenu.Location = new System.Drawing.Point(127, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1168, 637);
            this.Controls.Add(this.pnlMenu);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.PictureBox ptBUser;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPomo;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHome;
    }
}

