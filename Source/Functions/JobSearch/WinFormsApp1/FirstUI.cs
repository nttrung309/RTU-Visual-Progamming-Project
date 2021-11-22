using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FirstUI : Form
    {
        public FirstUI()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }
        /*
         * Đang fix lag flowlayoutpanel, thêm text vào ảnh.
         * Cần giúp: Liệu có thể truy vấn SQL, tìm số lượng ngành và tên, sau đó tương ứng với bao nhiêu ngành thì xuất ra bấy nhiêu Button đổ vào Flowlayoutpanel 2?
         */
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
