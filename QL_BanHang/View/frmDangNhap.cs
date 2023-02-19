using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_BanHang.Control;
using QL_BanHang.Obiect;

namespace QL_BanHang.View
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DangNhapCtr dnCtr = new DangNhapCtr();
            dt = dnCtr.CheckData(textMaNV.Text, textMatKhau.Text);
            if(dt.Rows.Count > 0)
            {
                frmHoaDon frmMain = new frmHoaDon();
                this.Hide();
                frmMain.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại Mã Nhân Viên và Mật Khẩu của bạn", "Đăng nhập thất bại", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}
