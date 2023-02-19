using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QL_BanHang.Model;
using QL_BanHang.Obiect;

namespace QL_BanHang.Control
{
    class DangNhapCtr
    {
        DangNhapMod dnMod = new DangNhapMod();
        public bool CheckQuyen()
        {
            bool quyen;
            DataTable dtq = new DataTable();
            dtq = dnMod.CheckQuyen("admin");
            if (dtq.Rows.Count > 0) { quyen = true; }
            else { quyen = false; }
            return quyen;
        }
        public DataTable CheckData(string MaNV, string MatKhau)
        {
            return dnMod.CheckData(MaNV, MatKhau);
        }
    }
}
