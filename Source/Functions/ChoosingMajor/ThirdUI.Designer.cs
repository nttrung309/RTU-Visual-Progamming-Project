
namespace ChoosingMajor
{
    partial class ThirdUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThirdUI));
            this.pbxTitle = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvNganh = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customLabel2 = new ChoosingMajor.CustomLabel();
            this.customLabel1 = new ChoosingMajor.CustomLabel();
            this.lblTitle = new ChoosingMajor.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 72);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvNganh
            // 
            this.dgvNganh.AllowUserToAddRows = false;
            this.dgvNganh.AllowUserToDeleteRows = false;
            this.dgvNganh.AllowUserToResizeColumns = false;
            this.dgvNganh.AllowUserToResizeRows = false;
            this.dgvNganh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNganh.Location = new System.Drawing.Point(154, 298);
            this.dgvNganh.Name = "dgvNganh";
            this.dgvNganh.RowHeadersVisible = false;
            this.dgvNganh.Size = new System.Drawing.Size(800, 301);
            this.dgvNganh.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(154, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 301);
            this.dataGridView1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019"});
            this.comboBox1.Location = new System.Drawing.Point(856, 266);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 26);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.BackColor = System.Drawing.Color.Transparent;
            this.customLabel2.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.ForeColor = System.Drawing.Color.Red;
            this.customLabel2.Location = new System.Drawing.Point(226, 244);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.OutlineForeColor = System.Drawing.Color.Black;
            this.customLabel2.OutlineWidth = 2F;
            this.customLabel2.Size = new System.Drawing.Size(195, 32);
            this.customLabel2.TabIndex = 10;
            this.customLabel2.Text = "customLabel2";
            this.customLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.BackColor = System.Drawing.Color.Transparent;
            this.customLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.ForeColor = System.Drawing.Color.White;
            this.customLabel1.Location = new System.Drawing.Point(860, 244);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.OutlineForeColor = System.Drawing.Color.Black;
            this.customLabel1.OutlineWidth = 2F;
            this.customLabel1.Size = new System.Drawing.Size(88, 19);
            this.customLabel1.TabIndex = 9;
            this.customLabel1.Text = "Chọn năm";
            this.customLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // ThirdUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChoosingMajor.Properties.Resources.bluebg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 611);
            this.ControlBox = false;
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvNganh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThirdUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThirdUI";
            this.Load += new System.EventHandler(this.ThirdUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxTitle;
        private CustomLabel lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvNganh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private CustomLabel customLabel1;
        private CustomLabel customLabel2;
    }
}