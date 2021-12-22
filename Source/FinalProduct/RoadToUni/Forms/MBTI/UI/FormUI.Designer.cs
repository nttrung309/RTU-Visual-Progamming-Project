
namespace Đồ_án_1
{
    partial class FormUI
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
            this.CheckButton = new System.Windows.Forms.Button();
            this.panelWhite2 = new Đồ_án_1.PanelWhite();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelWhite1 = new Đồ_án_1.PanelWhite();
            this.label3 = new System.Windows.Forms.Label();
            this.panelWhite2.SuspendLayout();
            this.panelWhite1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckButton
            // 
            this.CheckButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CheckButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.CheckButton.Location = new System.Drawing.Point(431, 501);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(249, 53);
            this.CheckButton.TabIndex = 5;
            this.CheckButton.Text = "Kiểm tra ngay";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // panelWhite2
            // 
            this.panelWhite2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelWhite2.BackColor = System.Drawing.Color.Transparent;
            this.panelWhite2.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.panelWhite2.Controls.Add(this.label5);
            this.panelWhite2.Controls.Add(this.label6);
            this.panelWhite2.Edge = 20;
            this.panelWhite2.Location = new System.Drawing.Point(162, 1);
            this.panelWhite2.Name = "panelWhite2";
            this.panelWhite2.Size = new System.Drawing.Size(827, 202);
            this.panelWhite2.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(476, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Khám phá nghề nghiệp phù hợp qua tính cách của bạn";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(156, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(496, 58);
            this.label6.TabIndex = 4;
            this.label6.Text = "Trắc nghiệm tính cách";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWhite1
            // 
            this.panelWhite1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelWhite1.BackColor = System.Drawing.Color.Transparent;
            this.panelWhite1.BorderColor = System.Drawing.Color.White;
            this.panelWhite1.Controls.Add(this.label3);
            this.panelWhite1.Edge = 20;
            this.panelWhite1.Location = new System.Drawing.Point(95, 238);
            this.panelWhite1.Name = "panelWhite1";
            this.panelWhite1.Size = new System.Drawing.Size(954, 223);
            this.panelWhite1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1288, 236);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bạn vẫn đang phân vân về công việc tương lai mà không biết nên\r\nhỏi ai, hay đơn g" +
    "iản chỉ đang tìm kiếm bản thân mình. \r\n\r\nHãy trả lời các câu hỏi MBTI sau đây để" +
    " tìm thấy câu trả lời.";
            // 
            // FormUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::RoadToUni.Properties.Resources.cdBackGround4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 611);
            this.ControlBox = false;
            this.Controls.Add(this.panelWhite2);
            this.Controls.Add(this.panelWhite1);
            this.Controls.Add(this.CheckButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelWhite2.ResumeLayout(false);
            this.panelWhite2.PerformLayout();
            this.panelWhite1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CheckButton;
        private PanelWhite panelWhite1;
        private PanelWhite panelWhite2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

