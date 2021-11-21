
namespace WindowsFormsApp1
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNameUni = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMajor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvShow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShow.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShow.Location = new System.Drawing.Point(55, 304);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 62;
            this.dgvShow.RowTemplate.Height = 28;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(893, 230);
            this.dgvShow.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(55, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 260);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbNameUni
            // 
            this.lbNameUni.BackColor = System.Drawing.Color.White;
            this.lbNameUni.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameUni.Location = new System.Drawing.Point(366, 50);
            this.lbNameUni.Name = "lbNameUni";
            this.lbNameUni.Size = new System.Drawing.Size(552, 90);
            this.lbNameUni.TabIndex = 3;
            this.lbNameUni.Text = "label1";
            this.lbNameUni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 74);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhóm ngành: ";
            // 
            // lbMajor
            // 
            this.lbMajor.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMajor.Location = new System.Drawing.Point(537, 156);
            this.lbMajor.Name = "lbMajor";
            this.lbMajor.Size = new System.Drawing.Size(445, 90);
            this.lbMajor.TabIndex = 5;
            this.lbMajor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1018, 647);
            this.Controls.Add(this.lbMajor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNameUni);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvShow);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfor;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNameUni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMajor;
    }
}