﻿
namespace RoadToUni.Forms.Search.FindSchool
{
    partial class fsearch
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
            this.txbGrade = new System.Windows.Forms.TextBox();
            this.cbCombination = new System.Windows.Forms.ComboBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNameUni = new System.Windows.Forms.ComboBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.lbTHPT = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customLabel3 = new RoadToUni.Forms.Search.FindSchool.customLabel();
            this.customLabel2 = new RoadToUni.Forms.Search.FindSchool.customLabel();
            this.customLabel1 = new RoadToUni.Forms.Search.FindSchool.customLabel();
            this.btnSearch = new RoadToUni.Forms.Search.FindSchool.customButton();
            this.lbTextNote = new RoadToUni.Forms.Search.FindSchool.customLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbGrade
            // 
            this.txbGrade.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGrade.ForeColor = System.Drawing.Color.DarkGray;
            this.txbGrade.Location = new System.Drawing.Point(311, 64);
            this.txbGrade.Name = "txbGrade";
            this.txbGrade.Size = new System.Drawing.Size(277, 35);
            this.txbGrade.TabIndex = 0;
            this.txbGrade.TabStop = false;
            this.txbGrade.Text = "Điểm xét tuyển dự kiến";
            this.txbGrade.Enter += new System.EventHandler(this.txbGrade_Enter);
            this.txbGrade.Leave += new System.EventHandler(this.txbGrade_Leave);
            // 
            // cbCombination
            // 
            this.cbCombination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCombination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCombination.DropDownHeight = 190;
            this.cbCombination.DropDownWidth = 120;
            this.cbCombination.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCombination.ForeColor = System.Drawing.Color.DarkGray;
            this.cbCombination.FormattingEnabled = true;
            this.cbCombination.IntegralHeight = false;
            this.cbCombination.ItemHeight = 27;
            this.cbCombination.Items.AddRange(new object[] {
            "A00 -- Toán, Vật lý, Hóa học",
            "A01 -- Toán, Vật lý, Tiếng Anh",
            "B00 -- Toán, Hóa học, Sinh học",
            "C00 -- Văn, Sử, Địa",
            "D01 -- Văn, Toán, tiếng Anh",
            "D07 -- Toán, Hóa học, Tiếng Anh",
            "A02 -- Toán, Vật lí , Sinh học",
            "A03 -- Toán, Vật lý, Lịch sử",
            "A04 -- Toán, Vật lý, Địa lí",
            "A05 -- Toán, Hóa học, Lịch sử",
            "A06 -- Toán, Hóa học, Địa lí",
            "A07 -- Toán, Lịch sử, Địa lí",
            "A08 -- Toán, Lịch sử, Giáo dục công dân",
            "A09 -- Toán, Địa lí, Giáo dục công dân",
            "A10 -- Toán, Vật lý, Giáo dục công dân",
            "A11 -- Toán, Hóa học, Giáo dục công dân",
            "A12 -- Toán, Khoa học tự nhiên, Khoa học xã hội",
            "A14 -- Toán, Khoa học tự nhiên, Địa lí",
            "A15 -- Toán, Khoa học tự nhiên, Giáo dục công dân",
            "A16 -- Toán, Khoa học tự nhiên, Văn",
            "A17 -- Toán, Khoa học xã hội, Vật lý",
            "A18 -- Toán, Khoa học xã hội, Hóa học",
            "B01 -- Toán, Sinh học, Lịch sử",
            "B02 -- Toán, Sinh học, Địa lí",
            "B03 -- Toán, Sinh học, Văn",
            "B04 -- Toán, Sinh học, Giáo dục công dân",
            "B05 -- Toán, Sinh học, Khoa học xã hội",
            "B08 -- Toán, Sinh học, Tiếng Anh",
            "C01 -- Văn, Toán, Vật lí",
            "C02 -- Văn, Toán, Hóa học",
            "C03 -- Văn, Toán, Lịch sử",
            "C04 -- Văn, Toán, Địa lí",
            "C05 -- Văn, Vật lí, Hóa học",
            "C06 -- Văn, Vật lí, Sinh học",
            "C07 -- Văn, Vật lí, Lịch sử",
            "C08 -- Văn, Hóa học, Sinh",
            "C09 -- Văn, Vật lí, Địa lí",
            "C10 -- Văn, Hóa học, Lịch sử",
            "C12 -- Văn, Sinh học, Lịch sử",
            "C13 -- Văn, Sinh học, Địa",
            "C14 -- Văn, Toán, Giáo dục công dân",
            "C15 -- Văn, Toán, Khoa học xã hội",
            "C16 -- Văn, Vật lí, Giáo dục công dân",
            "C17 -- Văn, Hóa học, Giáo dục công dân",
            "C19 -- Văn, Lịch sử, Giáo dục công dân",
            "C20 -- Văn, Địa lí, Giáo dục công dân",
            "D02 -- Văn, Toán, tiếng Nga",
            "D03 -- Văn, Toán, tiếng Pháp",
            "D04 -- Văn, Toán, tiếng Trung",
            "D05 -- Văn, Toán, Tiếng Đức",
            "D06 -- Văn, Toán, Tiếng Nhật",
            "D08 -- Toán, Sinh học, Tiếng Anh",
            "D09 -- Toán, Lịch sử, Tiếng Anh",
            "D10 -- Toán, Địa lí, Tiếng Anh",
            "D11 -- Văn, Vật lí, Tiếng Anh",
            "D12 -- Văn, Hóa học, Tiếng Anh",
            "D13 -- Văn, Sinh học, Tiếng Anh",
            "D14 -- Văn, Lịch sử, Tiếng Anh",
            "D15 -- Văn, Địa lí, Tiếng Anh",
            "D16 -- Toán, Địa lí, Tiếng Đức",
            "D17 -- Toán, Địa lí, Tiếng Nga",
            "D18 -- Toán, Địa lí, Tiếng Nhật",
            "D19 -- Toán, Địa lí, Tiếng Pháp",
            "D20 -- Toán, Địa lí, Tiếng Trung",
            "D21 -- Toán, Hóa học, Tiếng Đức",
            "D22 -- Toán, Hóa học, Tiếng Nga",
            "D23 -- Toán, Hóa học, Tiếng Nhật",
            "D24 -- Toán, Hóa học, Tiếng Pháp",
            "D25 -- Toán, Hóa học, Tiếng Trung",
            "D26 -- Toán, Vật lí, Tiếng Đức",
            "D27 -- Toán, Vật lí, Tiếng Nga",
            "D28 -- Toán, Vật lí, Tiếng Nhật",
            "D29 -- Toán, Vật lí, Tiếng Pháp",
            "D30 -- Toán, Vật lí, Tiếng Trung",
            "D31 -- Toán, Sinh học, Tiếng Đức",
            "D32 -- Toán, Sinh học, Tiếng Nga",
            "D33 -- Toán, Sinh học, Tiếng Nhật",
            "D34 -- Toán, Sinh học, Tiếng Pháp",
            "D35 -- Toán, Sinh học, Tiếng Trung",
            "D41 -- Văn, Địa lí, Tiếng Đức",
            "D42 -- Văn, Địa lí, Tiếng Nga",
            "D43 -- Văn, Địa lí, Tiếng Nhật",
            "D44 -- Văn, Địa lí, Tiếng Pháp",
            "D45 -- Văn, Địa lí, Tiếng Trung",
            "D52 -- Văn, Vật lí, Tiếng Nga",
            "D54 -- Văn, Vật lí, Tiếng Pháp",
            "D55 -- Văn, Vật lí, Tiếng Trung",
            "D61 -- Văn, Lịch sử, Tiếng Đức",
            "D62 -- Văn, Lịch sử, Tiếng Nga",
            "D63 -- Văn, Lịch sử, Tiếng Nhật",
            "D64 -- Văn, Lịch sử, Tiếng Pháp",
            "D65 -- Văn, Lịch sử, Tiếng Trung",
            "D66 -- Văn, Giáo dục công dân, Tiếng Anh",
            "D68 -- Văn, Giáo dục công dân, Tiếng Nga",
            "D69 -- Văn, Giáo dục công dân, Tiếng Nhật",
            "D70 -- Văn, Giáo dục công dân, Tiếng Pháp",
            "D72 -- Văn, Khoa học tự nhiên, Tiếng Anh",
            "D73 -- Văn, Khoa học tự nhiên, Tiếng Đức",
            "D74 -- Văn, Khoa học tự nhiên, Tiếng Nga",
            "D75 -- Văn, Khoa học tự nhiên, Tiếng Nhật",
            "D76 -- Văn, Khoa học tự nhiên, Tiếng Pháp",
            "D77 -- Văn, Khoa học tự nhiên, Tiếng Trung",
            "D78 -- Văn, Khoa học xã hội, Tiếng Anh",
            "D79 -- Văn, Khoa học xã hội, Tiếng Đức",
            "D80 -- Văn, Khoa học xã hội, Tiếng Nga",
            "D81 -- Văn, Khoa học xã hội, Tiếng Nhật",
            "D82 -- Văn, Khoa học xã hội, Tiếng Pháp",
            "D83 -- Văn, Khoa học xã hội, Tiếng Trung",
            "D84 -- Toán, Giáo dục công dân, Tiếng Anh",
            "D85 -- Toán, Giáo dục công dân, Tiếng Đức",
            "D86 -- Toán, Giáo dục công dân, Tiếng Nga",
            "D87 -- Toán, Giáo dục công dân, Tiếng Pháp",
            "D88 -- Toán, Giáo dục công dân, Tiếng Nhật",
            "D90 -- Toán, Khoa học tự nhiên, Tiếng Anh",
            "D91 -- Toán, Khoa học tự nhiên, Tiếng Pháp",
            "D92 -- Toán, Khoa học tự nhiên, Tiếng Đức",
            "D93 -- Toán, Khoa học tự nhiên, Tiếng Nga",
            "D94 -- Toán, Khoa học tự nhiên, Tiếng Nhật",
            "D95 -- Toán, Khoa học tự nhiên, Tiếng Trung",
            "D96 -- Toán, Khoa học xã hội, Anh",
            "D97 -- Toán, Khoa học xã hội, Tiếng Pháp",
            "D98 -- Toán, Khoa học xã hội, Tiếng Đức",
            "D99 -- Toán, Khoa học xã hội, Tiếng Nga",
            "H00 -- Văn, Năng khiếu vẽ 1, Năng khiếu vẽ 2",
            "H01 -- Toán, Văn, Vẽ",
            "H02 -- Toán, Vẽ Hình họa mỹ thuật, Vẽ trang trí màu",
            "H03 -- Toán, Khoa học tự nhiên, Vẽ Năng khiếu",
            "H04 -- Toán, Tiếng Anh, Vẽ Năng khiếu",
            "H05 -- Văn, Khoa học xã hội, Vẽ Năng khiếu",
            "H06 -- Văn, Tiếng Anh,Vẽ mỹ thuật",
            "H07 -- Toán, Hình họa, Trang trí",
            "H08 -- Văn, Lịch sử, Vẽ mỹ thuật",
            "V00 -- Toán, Vật lí, Vẽ Hình họa mỹ thuật",
            "V01 -- Toán, Văn, Vẽ Hình họa mỹ thuật",
            "V02 -- VẼ MT, Toán, Tiếng Anh",
            "V03 -- VẼ MT, Toán, Hóa",
            "V05 -- Văn, Vật lí, Vẽ mỹ thuật",
            "V06 -- Toán, Địa lí, Vẽ mỹ thuật",
            "V07 -- Toán, tiếng Đức, Vẽ mỹ thuật",
            "V08 -- Toán, tiếng Nga, Vẽ mỹ thuật",
            "V09 -- Toán, tiếng Nhật, Vẽ mỹ thuật",
            "V10 -- Toán, tiếng Pháp, Vẽ mỹ thuật",
            "V11 -- Toán, tiếng Trung, Vẽ mỹ thuật",
            "M00 -- Văn, Toán, Đọc diễn cảm, Hát",
            "M01 -- Văn, Lịch sử, Năng khiếu",
            "M02 -- Toán, Năng khiếu 1, Năng khiếu 2",
            "M03 -- Văn, Năng khiếu 1, Năng khiếu 2",
            "M04 -- Toán, KHTN, Năng khiếu",
            "M05 -- Văn, Sử, Năng khiếu",
            "M06 -- Văn, Toán, Năng khiếu",
            "M07 -- Văn, Địa, Đọc diễn cảm + Hát",
            "M08 -- Văn, NK 1, NK 2",
            "M09 -- Toán, Kể chuyện – Đọc diễn cảm, Hát",
            "M10 -- Toán, Tiếng Anh, Năng khiếu mầm non",
            "M11 -- Văn, Anh, Năng khiếu GDMN",
            "M13 -- Toán, Sinh, Năng khiếu",
            "M14 -- Toán, Địa, Đọc diễn cảm – Hát",
            "N00 -- Văn, Năng khiếu Âm nhạc 1, Năng khiếu Âm nhạc 2",
            "N01 -- Văn, Hát xướng âm, Biểu diễn nghệ thuật",
            "N02 -- Văn, Ký xướng âm, Hát hoặc biểu diễn nhạc cụ",
            "N03 -- Văn, Ghi âm- xướng âm, chuyên môn",
            "N04 -- Văn, Năng khiếu thuyết trình, Năng khiếu",
            "N05 -- Văn, Xây dựng kịch bản sự kiện, Năng khiếu",
            "N06 -- Văn, Ghi âm- xướng âm, chuyên môn",
            "N07 -- Văn, Ghi âm- xướng âm, chuyên môn",
            "N08 -- Văn, Hòa thanh, Phát triển chủ đề và phổ thơ",
            "N09 -- Văn, Hòa thanh, Chỉ huy tại chỗ",
            "R00 -- Văn, Sử, Năng khiếu nghệ thuật",
            "R01 -- Văn, Địa, Năng khiếu nghệ thuật",
            "R02 -- Văn, Toán, Năng khiếu nghệ thuật",
            "R03 -- Văn, Anh, Năng khiếu nghệ thuật",
            "R04 -- Văn, Biểu diễn nghệ thuật, Năng khiếu văn hóa nghệ thuật",
            "R05 -- Văn, Anh, Năng khiếu báo chí",
            "R06 -- Văn, KHTN, Năng khiếu báo chí",
            "R07 -- Văn, Toán, Năng khiếu ảnh báo chí",
            "R08 -- Văn, Anh, Năng khiếu ảnh báo chí",
            "R09 -- Văn, KHTN, Năng khiếu ảnh báo chí",
            "R11 -- Văn, Toán, Năng khiếu quay phim truyền hình",
            "R12 -- Văn, Anh, Năng khiếu quay phim truyền hình",
            "R13 -- Văn, KHTN, Năng khiếu quay phim truyền hình",
            "R15 -- Văn, Toán, Năng khiếu báo chí",
            "R16 -- Văn, KHXH, Năng khiếu báo chí",
            "R17 -- Văn, KHXH, Năng khiếu ảnh báo chí",
            "R18 -- Văn, KHXH, Năng khiếu quay phim truyền hình",
            " R19 --Văn, Điểm quy đổi chứng chỉ Tiếng Anhh, Năng khiếu báo chí",
            " R20 --Văn, Điểm quy đổi chứng chỉ Tiếng Anh, Năng khiếu ảnh báo chí",
            "R21 -- Văn, Điểm quy đổi chứng chỉ Tiếng Anh, NK quay phim truyền hình",
            "R22 -- Văn, Toán, Điểm quy đổi chứng chỉ Tiếng Anh",
            "R23 -- Văn, Sử, Điểm quy đổi chứng chỉ Tiếng Anh",
            "R24 -- Văn, Toán, Điểm quy đổi chứng chỉ Tiếng Anh",
            "R25 -- Văn, KHTN, Điểm quy đổi chứng chỉ Tiếng Anh",
            "R26 -- Văn, KHXH, Điểm quy đổi chứng chỉ Tiếng Anh",
            "T00 -- Toán, Sinh, Năng khiếu Thể dục thể thao",
            "T01 -- Toán, Văn, Năng khiếu TDTT",
            "T02 -- Văn, Sinh, Năng khiếu TDTT",
            "T03 -- Văn, Địa, Năng khiếu TDTT",
            "T04 -- Toán, Lý, Năng khiếu TDTT",
            "T05 -- Văn, GDCD, Năng khiếu TDTT",
            "T07 -- Văn, Địa, Năng khiếu TDTT",
            "T08 -- Toán, GDCD, Năng khiếu TDTT",
            "S00 -- Văn, Năng khiếu SKĐA 1, Năng khiếu SKĐA 2",
            "S01 -- Toán, Năng khiếu SKĐA 1, Năng khiếu SKĐA 2",
            ""});
            this.cbCombination.Location = new System.Drawing.Point(311, 116);
            this.cbCombination.MaxDropDownItems = 10;
            this.cbCombination.Name = "cbCombination";
            this.cbCombination.Size = new System.Drawing.Size(470, 35);
            this.cbCombination.TabIndex = 0;
            this.cbCombination.TabStop = false;
            this.cbCombination.Text = "Chọn tổ hợp xét tuyển";
            this.cbCombination.Enter += new System.EventHandler(this.cbCombination_Enter);
            this.cbCombination.Leave += new System.EventHandler(this.cbCombination_Leave);
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewResult.Location = new System.Drawing.Point(43, 254);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersWidth = 62;
            this.dataGridViewResult.RowTemplate.Height = 28;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.Size = new System.Drawing.Size(1001, 350);
            this.dataGridViewResult.TabIndex = 7;
            this.dataGridViewResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResult_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Moccasin;
            this.label1.Font = new System.Drawing.Font("Courier New", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::RoadToUni.Properties.Resources.icoTuVan__1_;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(265, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 74);
            this.label1.TabIndex = 9;
            this.label1.Text = "     CHÀO MỪNG CÁC BẠN ĐẾN VỚI TƯ VẤN CHỌN TRƯỜNG ĐẠI HỌC 2022";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbNameUni
            // 
            this.cbNameUni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNameUni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNameUni.DropDownHeight = 190;
            this.cbNameUni.DropDownWidth = 120;
            this.cbNameUni.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNameUni.ForeColor = System.Drawing.Color.DarkGray;
            this.cbNameUni.FormattingEnabled = true;
            this.cbNameUni.IntegralHeight = false;
            this.cbNameUni.ItemHeight = 27;
            this.cbNameUni.Items.AddRange(new object[] {
            "A00 -- Toán, Vật lý, Hóa học",
            "A01 -- Toán, Vật lý, Tiếng Anh",
            "B00 -- Toán, Hóa học, Sinh học",
            "C00 -- Văn, Sử, Địa",
            "D01 -- Văn, Toán, tiếng Anh",
            "D07 -- Toán, Hóa học, Tiếng Anh",
            "A02 -- Toán, Vật lí , Sinh học",
            "A03 -- Toán, Vật lý, Lịch sử",
            "A04 -- Toán, Vật lý, Địa lí",
            "A05 -- Toán, Hóa học, Lịch sử",
            "A06 -- Toán, Hóa học, Địa lí",
            "A07 -- Toán, Lịch sử, Địa lí",
            "A08 -- Toán, Lịch sử, Giáo dục công dân",
            "A09 -- Toán, Địa lí, Giáo dục công dân",
            "A10 -- Toán, Vật lý, Giáo dục công dân",
            "A11 -- Toán, Hóa học, Giáo dục công dân",
            "A12 -- Toán, Khoa học tự nhiên, Khoa học xã hội",
            "A14 -- Toán, Khoa học tự nhiên, Địa lí",
            "A15 -- Toán, Khoa học tự nhiên, Giáo dục công dân",
            "A16 -- Toán, Khoa học tự nhiên, Văn",
            "A17 -- Toán, Khoa học xã hội, Vật lý",
            "A18 -- Toán, Khoa học xã hội, Hóa học",
            "B01 -- Toán, Sinh học, Lịch sử",
            "B02 -- Toán, Sinh học, Địa lí",
            "B03 -- Toán, Sinh học, Văn",
            "B04 -- Toán, Sinh học, Giáo dục công dân",
            "B05 -- Toán, Sinh học, Khoa học xã hội",
            "B08 -- Toán, Sinh học, Tiếng Anh",
            "C01 -- Văn, Toán, Vật lí",
            "C02 -- Văn, Toán, Hóa học",
            "C03 -- Văn, Toán, Lịch sử",
            "C04 -- Văn, Toán, Địa lí",
            "C05 -- Văn, Vật lí, Hóa học",
            "C06 -- Văn, Vật lí, Sinh học",
            "C07 -- Văn, Vật lí, Lịch sử",
            "C08 -- Văn, Hóa học, Sinh",
            "C09 -- Văn, Vật lí, Địa lí",
            "C10 -- Văn, Hóa học, Lịch sử",
            "C12 -- Văn, Sinh học, Lịch sử",
            "C13 -- Văn, Sinh học, Địa",
            "C14 -- Văn, Toán, Giáo dục công dân",
            "C15 -- Văn, Toán, Khoa học xã hội",
            "C16 -- Văn, Vật lí, Giáo dục công dân",
            "C17 -- Văn, Hóa học, Giáo dục công dân",
            "C19 -- Văn, Lịch sử, Giáo dục công dân",
            "C20 -- Văn, Địa lí, Giáo dục công dân",
            "D02 -- Văn, Toán, tiếng Nga",
            "D03 -- Văn, Toán, tiếng Pháp",
            "D04 -- Văn, Toán, tiếng Trung",
            "D05 -- Văn, Toán, Tiếng Đức",
            "D06 -- Văn, Toán, Tiếng Nhật",
            "D08 -- Toán, Sinh học, Tiếng Anh",
            "D09 -- Toán, Lịch sử, Tiếng Anh",
            "D10 -- Toán, Địa lí, Tiếng Anh",
            "D11 -- Văn, Vật lí, Tiếng Anh",
            "D12 -- Văn, Hóa học, Tiếng Anh",
            "D13 -- Văn, Sinh học, Tiếng Anh",
            "D14 -- Văn, Lịch sử, Tiếng Anh",
            "D15 -- Văn, Địa lí, Tiếng Anh",
            "D16 -- Toán, Địa lí, Tiếng Đức",
            "D17 -- Toán, Địa lí, Tiếng Nga",
            "D18 -- Toán, Địa lí, Tiếng Nhật",
            "D19 -- Toán, Địa lí, Tiếng Pháp",
            "D20 -- Toán, Địa lí, Tiếng Trung",
            "D21 -- Toán, Hóa học, Tiếng Đức",
            "D22 -- Toán, Hóa học, Tiếng Nga",
            "D23 -- Toán, Hóa học, Tiếng Nhật",
            "D24 -- Toán, Hóa học, Tiếng Pháp",
            "D25 -- Toán, Hóa học, Tiếng Trung",
            "D26 -- Toán, Vật lí, Tiếng Đức",
            "D27 -- Toán, Vật lí, Tiếng Nga",
            "D28 -- Toán, Vật lí, Tiếng Nhật",
            "D29 -- Toán, Vật lí, Tiếng Pháp",
            "D30 -- Toán, Vật lí, Tiếng Trung",
            "D31 -- Toán, Sinh học, Tiếng Đức",
            "D32 -- Toán, Sinh học, Tiếng Nga",
            "D33 -- Toán, Sinh học, Tiếng Nhật",
            "D34 -- Toán, Sinh học, Tiếng Pháp",
            "D35 -- Toán, Sinh học, Tiếng Trung",
            "D41 -- Văn, Địa lí, Tiếng Đức",
            "D42 -- Văn, Địa lí, Tiếng Nga",
            "D43 -- Văn, Địa lí, Tiếng Nhật",
            "D44 -- Văn, Địa lí, Tiếng Pháp",
            "D45 -- Văn, Địa lí, Tiếng Trung",
            "D52 -- Văn, Vật lí, Tiếng Nga",
            "D54 -- Văn, Vật lí, Tiếng Pháp",
            "D55 -- Văn, Vật lí, Tiếng Trung",
            "D61 -- Văn, Lịch sử, Tiếng Đức",
            "D62 -- Văn, Lịch sử, Tiếng Nga",
            "D63 -- Văn, Lịch sử, Tiếng Nhật",
            "D64 -- Văn, Lịch sử, Tiếng Pháp",
            "D65 -- Văn, Lịch sử, Tiếng Trung",
            "D66 -- Văn, Giáo dục công dân, Tiếng Anh",
            "D68 -- Văn, Giáo dục công dân, Tiếng Nga",
            "D69 -- Văn, Giáo dục công dân, Tiếng Nhật",
            "D70 -- Văn, Giáo dục công dân, Tiếng Pháp",
            "D72 -- Văn, Khoa học tự nhiên, Tiếng Anh",
            "D73 -- Văn, Khoa học tự nhiên, Tiếng Đức",
            "D74 -- Văn, Khoa học tự nhiên, Tiếng Nga",
            "D75 -- Văn, Khoa học tự nhiên, Tiếng Nhật",
            "D76 -- Văn, Khoa học tự nhiên, Tiếng Pháp",
            "D77 -- Văn, Khoa học tự nhiên, Tiếng Trung",
            "D78 -- Văn, Khoa học xã hội, Tiếng Anh",
            "D79 -- Văn, Khoa học xã hội, Tiếng Đức",
            "D80 -- Văn, Khoa học xã hội, Tiếng Nga",
            "D81 -- Văn, Khoa học xã hội, Tiếng Nhật",
            "D82 -- Văn, Khoa học xã hội, Tiếng Pháp",
            "D83 -- Văn, Khoa học xã hội, Tiếng Trung",
            "D84 -- Toán, Giáo dục công dân, Tiếng Anh",
            "D85 -- Toán, Giáo dục công dân, Tiếng Đức",
            "D86 -- Toán, Giáo dục công dân, Tiếng Nga",
            "D87 -- Toán, Giáo dục công dân, Tiếng Pháp",
            "D88 -- Toán, Giáo dục công dân, Tiếng Nhật",
            "D90 -- Toán, Khoa học tự nhiên, Tiếng Anh",
            "D91 -- Toán, Khoa học tự nhiên, Tiếng Pháp",
            "D92 -- Toán, Khoa học tự nhiên, Tiếng Đức",
            "D93 -- Toán, Khoa học tự nhiên, Tiếng Nga",
            "D94 -- Toán, Khoa học tự nhiên, Tiếng Nhật",
            "D95 -- Toán, Khoa học tự nhiên, Tiếng Trung",
            "D96 -- Toán, Khoa học xã hội, Anh",
            "D97 -- Toán, Khoa học xã hội, Tiếng Pháp",
            "D98 -- Toán, Khoa học xã hội, Tiếng Đức",
            "D99 -- Toán, Khoa học xã hội, Tiếng Nga",
            "H00 -- Văn, Năng khiếu vẽ 1, Năng khiếu vẽ 2",
            "H01 -- Toán, Văn, Vẽ",
            "H02 -- Toán, Vẽ Hình họa mỹ thuật, Vẽ trang trí màu",
            "H03 -- Toán, Khoa học tự nhiên, Vẽ Năng khiếu",
            "H04 -- Toán, Tiếng Anh, Vẽ Năng khiếu",
            "H05 -- Văn, Khoa học xã hội, Vẽ Năng khiếu",
            "H06 -- Văn, Tiếng Anh,Vẽ mỹ thuật",
            "H07 -- Toán, Hình họa, Trang trí",
            "H08 -- Văn, Lịch sử, Vẽ mỹ thuật",
            "V00 -- Toán, Vật lí, Vẽ Hình họa mỹ thuật",
            "V01 -- Toán, Văn, Vẽ Hình họa mỹ thuật",
            "V02 -- VẼ MT, Toán, Tiếng Anh",
            "V03 -- VẼ MT, Toán, Hóa",
            "V05 -- Văn, Vật lí, Vẽ mỹ thuật",
            "V06 -- Toán, Địa lí, Vẽ mỹ thuật",
            "V07 -- Toán, tiếng Đức, Vẽ mỹ thuật",
            "V08 -- Toán, tiếng Nga, Vẽ mỹ thuật",
            "V09 -- Toán, tiếng Nhật, Vẽ mỹ thuật",
            "V10 -- Toán, tiếng Pháp, Vẽ mỹ thuật",
            "V11 -- Toán, tiếng Trung, Vẽ mỹ thuật",
            "M00 -- Văn, Toán, Đọc diễn cảm, Hát",
            "M01 -- Văn, Lịch sử, Năng khiếu",
            "M02 -- Toán, Năng khiếu 1, Năng khiếu 2",
            "M03 -- Văn, Năng khiếu 1, Năng khiếu 2",
            "M04 -- Toán, KHTN, Năng khiếu",
            "M05 -- Văn, Sử, Năng khiếu",
            "M06 -- Văn, Toán, Năng khiếu",
            "M07 -- Văn, Địa, Đọc diễn cảm + Hát",
            "M08 -- Văn, NK 1, NK 2",
            "M09 -- Toán, Kể chuyện – Đọc diễn cảm, Hát",
            "M10 -- Toán, Tiếng Anh, Năng khiếu mầm non",
            "M11 -- Văn, Anh, Năng khiếu GDMN",
            "M13 -- Toán, Sinh, Năng khiếu",
            "M14 -- Toán, Địa, Đọc diễn cảm – Hát",
            "N00 -- Văn, Năng khiếu Âm nhạc 1, Năng khiếu Âm nhạc 2",
            "N01 -- Văn, Hát xướng âm, Biểu diễn nghệ thuật",
            "N02 -- Văn, Ký xướng âm, Hát hoặc biểu diễn nhạc cụ",
            "N03 -- Văn, Ghi âm- xướng âm, chuyên môn",
            "N04 -- Văn, Năng khiếu thuyết trình, Năng khiếu",
            "N05 -- Văn, Xây dựng kịch bản sự kiện, Năng khiếu",
            "N06 -- Văn, Ghi âm- xướng âm, chuyên môn",
            "N07 -- Văn, Ghi âm- xướng âm, chuyên môn",
            "N08 -- Văn, Hòa thanh, Phát triển chủ đề và phổ thơ",
            "N09 -- Văn, Hòa thanh, Chỉ huy tại chỗ",
            "R00 -- Văn, Sử, Năng khiếu nghệ thuật",
            "R01 -- Văn, Địa, Năng khiếu nghệ thuật",
            "R02 -- Văn, Toán, Năng khiếu nghệ thuật",
            "R03 -- Văn, Anh, Năng khiếu nghệ thuật",
            "R04 -- Văn, Biểu diễn nghệ thuật, Năng khiếu văn hóa nghệ thuật",
            "R05 -- Văn, Anh, Năng khiếu báo chí",
            "R06 -- Văn, KHTN, Năng khiếu báo chí",
            "R07 -- Văn, Toán, Năng khiếu ảnh báo chí",
            "R08 -- Văn, Anh, Năng khiếu ảnh báo chí",
            "R09 -- Văn, KHTN, Năng khiếu ảnh báo chí",
            "R11 -- Văn, Toán, Năng khiếu quay phim truyền hình",
            "R12 -- Văn, Anh, Năng khiếu quay phim truyền hình",
            "R13 -- Văn, KHTN, Năng khiếu quay phim truyền hình",
            "R15 -- Văn, Toán, Năng khiếu báo chí",
            "R16 -- Văn, KHXH, Năng khiếu báo chí",
            "R17 -- Văn, KHXH, Năng khiếu ảnh báo chí",
            "R18 -- Văn, KHXH, Năng khiếu quay phim truyền hình",
            " R19 --Văn, Điểm quy đổi chứng chỉ Tiếng Anhh, Năng khiếu báo chí",
            " R20 --Văn, Điểm quy đổi chứng chỉ Tiếng Anh, Năng khiếu ảnh báo chí",
            "R21 -- Văn, Điểm quy đổi chứng chỉ Tiếng Anh, NK quay phim truyền hình",
            "R22 -- Văn, Toán, Điểm quy đổi chứng chỉ Tiếng Anh",
            "R23 -- Văn, Sử, Điểm quy đổi chứng chỉ Tiếng Anh",
            "R24 -- Văn, Toán, Điểm quy đổi chứng chỉ Tiếng Anh",
            "R25 -- Văn, KHTN, Điểm quy đổi chứng chỉ Tiếng Anh",
            "R26 -- Văn, KHXH, Điểm quy đổi chứng chỉ Tiếng Anh",
            "T00 -- Toán, Sinh, Năng khiếu Thể dục thể thao",
            "T01 -- Toán, Văn, Năng khiếu TDTT",
            "T02 -- Văn, Sinh, Năng khiếu TDTT",
            "T03 -- Văn, Địa, Năng khiếu TDTT",
            "T04 -- Toán, Lý, Năng khiếu TDTT",
            "T05 -- Văn, GDCD, Năng khiếu TDTT",
            "T07 -- Văn, Địa, Năng khiếu TDTT",
            "T08 -- Toán, GDCD, Năng khiếu TDTT",
            "S00 -- Văn, Năng khiếu SKĐA 1, Năng khiếu SKĐA 2",
            "S01 -- Toán, Năng khiếu SKĐA 1, Năng khiếu SKĐA 2",
            ""});
            this.cbNameUni.Location = new System.Drawing.Point(311, 10);
            this.cbNameUni.MaxDropDownItems = 10;
            this.cbNameUni.Name = "cbNameUni";
            this.cbNameUni.Size = new System.Drawing.Size(470, 35);
            this.cbNameUni.TabIndex = 20;
            this.cbNameUni.Text = "Chọn trường";
            this.cbNameUni.Enter += new System.EventHandler(this.cbNameUni_Enter);
            this.cbNameUni.Leave += new System.EventHandler(this.cbNameUni_Leave);
            // 
            // lbNote
            // 
            this.lbNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNote.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbNote.Font = new System.Drawing.Font("Courier New", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.ForeColor = System.Drawing.Color.White;
            this.lbNote.Location = new System.Drawing.Point(231, 90);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(687, 111);
            this.lbNote.TabIndex = 10;
            this.lbNote.Text = "LƯU Ý: Chúng tôi đang hỗ trợ tư vấn chọn trường, chọn ngành nghề và khối thi phù " +
    "hợp với điểm thi THPTQG 2021, điểm chuẩn năm gần nhất giúp thí sinh tăng khả năn" +
    "g trúng tuyển Đại học.";
            this.lbNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTHPT
            // 
            this.lbTHPT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTHPT.AutoSize = true;
            this.lbTHPT.BackColor = System.Drawing.Color.White;
            this.lbTHPT.Font = new System.Drawing.Font("Courier New", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTHPT.ForeColor = System.Drawing.Color.Red;
            this.lbTHPT.Location = new System.Drawing.Point(687, 149);
            this.lbTHPT.Name = "lbTHPT";
            this.lbTHPT.Size = new System.Drawing.Size(142, 23);
            this.lbTHPT.TabIndex = 12;
            this.lbTHPT.Text = "THPTQG 2021";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.customLabel3);
            this.panel1.Controls.Add(this.customLabel2);
            this.panel1.Controls.Add(this.customLabel1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.cbNameUni);
            this.panel1.Controls.Add(this.txbGrade);
            this.panel1.Controls.Add(this.cbCombination);
            this.panel1.Location = new System.Drawing.Point(43, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 157);
            this.panel1.TabIndex = 13;
            // 
            // customLabel3
            // 
            this.customLabel3.BackColor = System.Drawing.Color.MediumBlue;
            this.customLabel3.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.customLabel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customLabel3.BorderRadius = 20;
            this.customLabel3.BorderSize = 0;
            this.customLabel3.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.ForeColor = System.Drawing.Color.White;
            this.customLabel3.Location = new System.Drawing.Point(2, 112);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(227, 40);
            this.customLabel3.TabIndex = 21;
            this.customLabel3.Text = "Chọn tổ hợp";
            this.customLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customLabel3.TextColor = System.Drawing.Color.White;
            // 
            // customLabel2
            // 
            this.customLabel2.BackColor = System.Drawing.Color.MediumBlue;
            this.customLabel2.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.customLabel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customLabel2.BorderRadius = 20;
            this.customLabel2.BorderSize = 0;
            this.customLabel2.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.ForeColor = System.Drawing.Color.White;
            this.customLabel2.Location = new System.Drawing.Point(1, 59);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(304, 40);
            this.customLabel2.TabIndex = 15;
            this.customLabel2.Text = "Nhập tổng điểm dự kiến";
            this.customLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customLabel2.TextColor = System.Drawing.Color.White;
            // 
            // customLabel1
            // 
            this.customLabel1.BackColor = System.Drawing.Color.MediumBlue;
            this.customLabel1.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.customLabel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customLabel1.BorderRadius = 20;
            this.customLabel1.BorderSize = 0;
            this.customLabel1.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.ForeColor = System.Drawing.Color.White;
            this.customLabel1.Location = new System.Drawing.Point(2, 8);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(303, 40);
            this.customLabel1.TabIndex = 14;
            this.customLabel1.Text = "Chọn ngành/nhóm ngành";
            this.customLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customLabel1.TextColor = System.Drawing.Color.White;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Snow;
            this.btnSearch.BackgroundColor = System.Drawing.Color.Snow;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Tomato;
            this.btnSearch.Image = global::RoadToUni.Properties.Resources.btnSearch__1_;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(775, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(201, 70);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextColor = System.Drawing.Color.Tomato;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbTextNote
            // 
            this.lbTextNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTextNote.BackColor = System.Drawing.Color.White;
            this.lbTextNote.BackgroundColor = System.Drawing.Color.White;
            this.lbTextNote.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lbTextNote.BorderRadius = 20;
            this.lbTextNote.BorderSize = 0;
            this.lbTextNote.Font = new System.Drawing.Font("Courier New", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextNote.ForeColor = System.Drawing.Color.Red;
            this.lbTextNote.Location = new System.Drawing.Point(231, 86);
            this.lbTextNote.Name = "lbTextNote";
            this.lbTextNote.Size = new System.Drawing.Size(85, 36);
            this.lbTextNote.TabIndex = 14;
            this.lbTextNote.Text = "LƯU Ý: ";
            this.lbTextNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTextNote.TextColor = System.Drawing.Color.Red;
            // 
            // fsearch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackgroundImage = global::RoadToUni.Properties.Resources.bkgr_Researching;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1086, 555);
            this.Controls.Add(this.lbTextNote);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTHPT);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewResult);
            this.DoubleBuffered = true;
            this.Name = "fsearch";
            this.Text = "Tư vấn chọn trường";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbGrade;
        private System.Windows.Forms.ComboBox cbCombination;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNameUni;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label lbTHPT;
        private System.Windows.Forms.Panel panel1;
        private customButton btnSearch;
        private customLabel customLabel1;
        private customLabel customLabel2;
        private customLabel customLabel3;
        private customLabel lbTextNote;
    }
}

