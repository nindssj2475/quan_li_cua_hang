using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_BanHang.Obiect
{
    class KhachHangObj
    {
        string ma, ten, gioitinh, diachi, sdt, email, namsinh;
        int sotien_dm;

        public int SoTien_DM
        {
            get { return sotien_dm; }
            set { sotien_dm = value; }
        }

        public string DienThoai
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        public string TenKhachHang
        {
            get { return ten; }
            set { ten = value; }
        }

        public string MaKhachHang
        {
            get { return ma; }
            set { ma = value; }
        }

        public string NamSinh
        {
            get { return namsinh; }
            set { namsinh = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public KhachHangObj() { }
        public KhachHangObj(string ma, string ten, string gioitinh, string namsinh, string diachi, string sdt, string email, int sotien_dm)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.namsinh = namsinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.email = email;
            this.sotien_dm = sotien_dm;
        }
    }
}
