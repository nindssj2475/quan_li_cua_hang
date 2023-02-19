using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QL_BanHang.Obiect;

namespace QL_BanHang.Model
{
    class KhachHangMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select MaKH, TenKH, GioiTinh,NamSinh,DiaChi,SDT,Email,SoTien_DM from KhachHang";
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

        public bool AddData(KhachHangObj khObj)
        {
            cmd.CommandText = "Insert into KhachHang values ('" + khObj.MaKhachHang + "',N'" + khObj.TenKhachHang + "',N'" + khObj.GioiTinh + "',CONVERT(DATE,'" + khObj.NamSinh + "',103),N'" + khObj.DienThoai + "','" + khObj.DiaChi + "',0,'"+ khObj.Email + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool UpdData(KhachHangObj khObj)
        {
            cmd.CommandText = "Update KhachHang set TenKH =  N'" + khObj.TenKhachHang + "', GioiTinh = N'" + khObj.GioiTinh + "', NamSinh = CONVERT(DATE,'" + khObj.NamSinh + "',103),SDT = '" + khObj.DienThoai + "', DiaChi = N'" + khObj.DiaChi + "' ,Email = '" + khObj.Email + "' Where MaKH = '" + khObj.MaKhachHang + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool UpdSoTien_DM(KhachHangObj khObj)
        {
            cmd.CommandText = "Update KhachHang set SoTien_DM ='" + khObj.SoTien_DM + "' Where MaKH = '" + khObj.MaKhachHang + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete KhachHang Where MaKH = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}
