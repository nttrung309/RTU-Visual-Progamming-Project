using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuction4
{
    public partial class Truong : UserControl
    {
        public Truong()
        {
            InitializeComponent();
            //TenTruong.Text = TuaDe;
        }

        public string TuaDe { get; set; }
        public Image Icon { get; set; }

        private void Truong_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void Truong_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Silver;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Silver;
        }

        private void TenTruong_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Silver;
        }

        //public string[] schoolCode = { "QSB", "QSC", "QSK", "QST", "QSX" };
        //public string[] schoolName = { "Đại học Bách Khoa TP.HCM", "Đại học Công nghệ Thông tin ĐHQG TP.HCM", "Trường Đại Học Kinh tế - Luật - ĐHQG TPHCM", "Trường Đại học Khoa học Tự nhiên, ĐHQG-HCM", "Trường Đại học Khoa học Xã hội và Nhân văn, ĐHQG TPHCM" };
        //public string[] schoolSummary =
        //{
        //    "Trường Đại học Bách khoa (Ho Chi Minh City University of Technology) là trường đại học chuyên ngành kỹ thuật lớn của Việt Nam, thành viên của hệ thống Đại học Quốc gia, được xếp vào nhóm đại học trọng điểm quốc gia Việt Nam. Tiền thân là Trung tâm Kỹ thuật Quốc gia được thành lập từ năm 1957, đến ngày 27/10/1976, Thủ tướng Phạm Văn Đồng ký Quyết định số 426/TTg đổi tên trường Đại học Kỹ thuật Phú Thọ thành trường Đại học Bách Khoa TP. Hồ Chí Minh.",
        //    "Trường Đại học Công nghệ Thông tin (ĐH CNTT), Đại học Quốc gia Thành phố Hồ Chí Minh (ĐHQG-HCM) là trường đại học công lập đào tạo về công nghệ thông tin và truyền thông (CNTT&TT) được thành lập theo Quyết định số 134/2006/QĐ-TTg ngày 8/6/2006 của Thủ tướng Chính phủ. Là trường thành viên của ĐHQG-HCM, trường ĐH CNTT có nhiệm vụ đào tạo nguồn nhân lực công nghệ thông tin chất lượng cao, góp phần tích cực vào sự phát triển của nền công nghiệp công nghệ thông tin Việt Nam, đồng thời tiến hành nghiên cứu khoa học và chuyển giao công nghệ thông tin tiên tiến, đặc biệt là hướng vào các ứng dụng nhằm góp phần đẩy mạnh sự nghiệp công nghiệp hóa, hiện đại hóa đất nước.",
        //    "Trường Đại học Kinh tế – Luật, Đại học Quốc gia Thành phố Hồ Chí Minh (Tiếng Anh: University of Economics and Law - VNUHCM, viết tắt UEL) là trường đại học đào tạo và nghiên cứu khối ngành kinh tế, kinh doanh quản lý và luật tại Việt Nam nói chung và tại khu vực phía Nam nói riêng, nổi bật với thế mạnh về năng lực giảng viên, được xếp vào nhóm trường đại học trọng điểm quốc gia Việt Nam. Trường có tiền thân là Khoa Kinh tế thuộc Đại học Quốc gia Thành phố Hồ Chí Minh.",
        //    "Trường Đại học Khoa học Tự nhiên, Đại học Quốc gia Thành phố Hồ Chí Minh (tiếng Anh: VNUHCM-University Of Science, viết tắt: VNUHCM-US | HCMUS) là một trong những trường đại học đào tạo và nghiên cứu khoa học cơ bản & ứng dụng hàng đầu Việt Nam, trực thuộc Đại học Quốc gia Thành phố Hồ Chí Minh, được xếp vào nhóm trường đại học trọng điểm quốc gia Việt Nam. Ngày 30 tháng 3 năm 1996, trường tách ra từ Trường Đại học Tổng hợp Thành phố Hồ Chí Minh và chính thức mang tên Trường Đại học Khoa học Tự nhiên đến ngày nay. Trải qua 80 năm hình thành và phát triển, đến nay Trường Khoa học Tự nhiên đã khẳng định được vị trí của mình - trở thành đơn vị đào tạo các ngành khoa học cơ bản mạnh nhất phía nam và là một trong những trường hàng đầu về khoa học công nghệ, đặc biệt là các ngành công nghệ mũi nhọn như: công nghệ thông tin, công nghệ sinh học, điện tử-viễn thông, kỹ thuật hạt nhân...",
        //    "Trường Đại học Khoa học Xã hội và Nhân văn, Đại học Quốc gia Thành phố Hồ Chí Minh (tiếng Anh: VNUHCM-University of Social Sciences and Humanities; viết tắt: VNUHCM-USSH) là một thành viên của hệ thống Đại học Quốc gia Thành phố Hồ Chí Minh - hệ thống đại học xếp hạng 158 Châu Á(QS 2021), TOP 101-150 đại học dưới 50 tuổi(QS 2021), TOP 301 - 500 trong 786 cơ sở giáo dục đại học hàng đầu đến từ 78 quốc gia do QS GER 2022 xếp hạng, TOP 601 - 800 trường đại học trên thế giới trong lĩnh vực Khoa học Xã hội(THE 2022), TOP 193 thế giới về chất lượng đầu ra của cựu sinh viên(QS GER 2022). Trường có tiền thân là Đại học Văn khoa/ Văn khoa Đại học đường(thuộc Viện Đại học Sài Gòn), Đại học Tổng hợp TP.HCM.Hiện nay, Trường là trung tâm nghiên cứu, đào tạo trong lĩnh vực khoa học xã hội và nhân văn lớn nhất miền Nam Việt Nam."
        //};
        private void Truong_Click(object sender, EventArgs e)
        {
            //bool found = false;
            //int i = 0;
            //foreach (string item in schoolCode)
            //{
            //    if (this.Name == item)
            //    {
            //        found = true;
            //        break;
            //    }
            //    i++;
            //}
            //if (found)
            //{
            //    UI.infSchoolForm.schoolname = schoolName[i];
            //    //UI.infSchoolForm.Summary = schoolSummary[i];
            //    UI.infSchoolForm.Show();
            //}
        }

    }
}
