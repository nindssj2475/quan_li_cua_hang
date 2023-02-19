using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QL_BanHang.Obiect;

namespace QL_BanHang.Model
{
    class DangNhapMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable CheckQuyen(string Quyen)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from NhanVien where Quyen = '"+ Quyen +"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        public DataTable CheckData(string MaNV,string MatKhau)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from NhanVien where MaNV ='"+ MaNV +"' and MatKhau = '"+ MatKhau + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;

        }
    }
}
