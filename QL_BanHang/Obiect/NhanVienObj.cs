using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_BanHang.Obiect
{
    class NhanVienObj
    {
        string ma, ten, gioitinh, diachi, sdt, matkhau, namsinh, quyen;

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

        public string TenNhanVien
        {
            get { return ten; }
            set { ten = value; }
        }

        public string MaNhanVien
        {
            get { return ma; }
            set { ma = value; }
        }

        public string NamSinh
        {
            get { return namsinh; }
            set { namsinh = value; }
        }

        public string MatKhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public string Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }

        public NhanVienObj() { }
        public NhanVienObj(string ma, string ten, string gioitinh, string namsinh, string diachi, string sdt, string quyen)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.namsinh = namsinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.quyen = quyen;
        }

    }
}
