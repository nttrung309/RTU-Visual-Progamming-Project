
namespace ChoosingMajor.GUID
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbTenNghanh = new System.Windows.Forms.Label();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.Nghanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Truong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2019 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2021 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2021 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTenNghanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 40);
            this.panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(898, 49);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(1006, 49);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbTenNghanh
            // 
            this.lbTenNghanh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTenNghanh.AutoSize = true;
            this.lbTenNghanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNghanh.Location = new System.Drawing.Point(373, 9);
            this.lbTenNghanh.Name = "lbTenNghanh";
            this.lbTenNghanh.Size = new System.Drawing.Size(302, 20);
            this.lbTenNghanh.TabIndex = 0;
            this.lbTenNghanh.Text = "CHỌN LĨNH VỰC BẠN QUAN TÂM";
            // 
            // gridData
            // 
            this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nghanh,
            this.Truong,
            this.col2019,
            this.col2021,
            this.cl2021});
            this.gridData.Location = new System.Drawing.Point(0, 95);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersWidth = 51;
            this.gridData.RowTemplate.Height = 24;
            this.gridData.Size = new System.Drawing.Size(1108, 511);
            this.gridData.TabIndex = 2;
            // 
            // Nghanh
            // 
            this.Nghanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nghanh.DataPropertyName = "MaNghanh";
            this.Nghanh.HeaderText = "Mã Nghành";
            this.Nghanh.MinimumWidth = 6;
            this.Nghanh.Name = "Nghanh";
            this.Nghanh.Width = 150;
            // 
            // Truong
            // 
            this.Truong.DataPropertyName = "MaTruong";
            this.Truong.HeaderText = "Tên Trường";
            this.Truong.MinimumWidth = 6;
            this.Truong.Name = "Truong";
            // 
            // col2019
            // 
            this.col2019.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col2019.DataPropertyName = "D19";
            this.col2019.HeaderText = "Điểm 2019";
            this.col2019.MinimumWidth = 6;
            this.col2019.Name = "col2019";
            this.col2019.Width = 120;
            // 
            // col2021
            // 
            this.col2021.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col2021.DataPropertyName = "D20";
            this.col2021.HeaderText = "Điểm 2020";
            this.col2021.MinimumWidth = 6;
            this.col2021.Name = "col2021";
            this.col2021.Width = 120;
            // 
            // cl2021
            // 
            this.cl2021.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl2021.DataPropertyName = "D21";
            this.cl2021.HeaderText = "Điểm 2021";
            this.cl2021.MinimumWidth = 6;
            this.cl2021.Name = "cl2021";
            this.cl2021.Width = 120;
            // 
            // ThirdUI
            // 
            this.ClientSize = new System.Drawing.Size(1108, 611);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gridData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1108, 611);
            this.Name = "ThirdUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ỨNG DỤNG TƯ VẤN CHỌN NGHÀNH HỌC";
            this.Load += new System.EventHandler(this.ThirdUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTenNghanh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nghanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Truong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2019;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2021;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2021;
    }
}

