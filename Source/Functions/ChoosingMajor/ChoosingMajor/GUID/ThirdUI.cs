using ChoosingMajor.DB.Interfaces;
using ChoosingMajor.Models;
using FX.Core;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChoosingMajor.GUID
{
    public partial class ThirdUI : Form
    {
        string MaNghanh = string.Empty;
        string TenNghanh = string.Empty;
        int[] array = new int[] { 2019, 2020, 2021 };
        public ThirdUI(string manghanh, string tennghanh)
        {
            InitializeComponent();
            MaNghanh = manghanh;
            TenNghanh = tennghanh;
        }

        private void ThirdUI_Load(object sender, System.EventArgs e)
        {
            ITongHopService srv = IoC.Resolve<ITongHopService>();
            var tonghops = srv.Query.Where(x => x.MaNghanh == MaNghanh).ToList();
            srv.UnbindSession();

            List<TongHopModel> datas = new List<TongHopModel>();

            var grbyTruong = tonghops.GroupBy(x => x.MaTruong).ToList();
            foreach (var gr in grbyTruong)
            {
                TongHopModel th = new TongHopModel();
                th.MaNghanh = MaNghanh;
                th.MaTruong = gr.Key;
                foreach (var item in gr.ToList())
                {
                    if(item.Nam == 2019)
                    {
                        th.D19 = item.DiemChuan;
                    }
                    else if (item.Nam == 2020)
                    {
                        th.D20 = item.DiemChuan;
                    }
                    else if (item.Nam == 2021)
                    {
                        th.D21 = item.DiemChuan;
                    }
                }

                datas.Add(th);
            }
            gridData.DataSource = datas;
            lbTenNghanh.Text = TenNghanh;
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
