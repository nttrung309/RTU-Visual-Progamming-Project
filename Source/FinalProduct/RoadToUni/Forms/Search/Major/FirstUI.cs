using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RoadToUni.Forms.Search.Major.ChoosingMajor
{
    public partial class FirstUI : Form
    {
        public FirstUI()
        {
            InitializeComponent();
            var pos = this.PointToScreen(lblTitle.Location);
            pos = pbxTitle.PointToClient(pos);
            lblTitle.Parent = pbxTitle;
            lblTitle.Location = pos;
            
        }
        public static string[] major = { "Báo chí - Marketing - Quảng cáo - PR", "Công an - Quân đội", "Công nghệ chế biến thực phẩm", "Công nghệ thông tin - Tin học", "Công nghệ vật liệu", "Điện lạnh- Điện tử - Điện - Tự động hóa", "Du lịch-Khách sạn", "Hàng không - Vũ trụ- Hạt nhân", "Kế toán - Kiểm toán", "Kinh tế - Quản trị kinh doanh - Thương Mại", "Luật - Tòa án", "Mỹ thuật - Âm nhạc-Nghệ thuật", "Ngoại giao - Ngoại ngữ", "Sư phạm - Giáo dục", "Tài chính - Ngân hàng- Bảo hiểm", "Thể dục - Thể thao", "Toán học và thống kê", "Tài nguyên- Môi trường", "Thủy sản-Lâm Nghiệp-Nông nghiệp", "Văn hóa - Chính trị - Khoa học Xã hội", "Y - Dược" };

        private void FirstUI_Load(object sender, EventArgs e)
        {
            this.fpnlNhomNganh.Controls.Clear();
            int j = 50;
            for (int i = 0; i < 21; i++)
            {
                MajorTile tile = new MajorTile();
                tile.Icon= Bitmap.FromFile(Application.StartupPath + "\\Data\\Images\\MajorSearch\\" + j.ToString() + ".jpg");
                tile.Major = major[i];
                tile.Name = major[i];
                
                this.fpnlNhomNganh.Controls.Add(tile);
                j++;
            }
        }
        
        
        
        
    }
}
