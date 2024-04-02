using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyCDTP
{
    public class NguoiQuanLyDao
    {
        DBConnection db = new DBConnection();
        public string DangNhap(NguoiQuanLy dn)
        {
            string sql = "select * from TaiKhoan where  MaNV = '" + dn.Account + "' and MatKhau ='" + dn.Password + "'";
            return db.Practice(sql);
        }
        public DataRowCollection LoadTK(NguoiQuanLy nql)
        {
            string thucthi = string.Format("select* from TaiKhoan  where MaNV='{0}'",nql.Account);
            return db.ThucThi(thucthi).Rows;
        }
        public void UpdatePass(NguoiQuanLy nql)
        {
            string sql = string.Format("Update TaiKhoan Set MatKhau='{0}' " +
               "where MatKhau='{1}'", nql.Newpass,nql.Password);
             db.ThucThi(sql);
        }
        public string TimKiemLoai(string dn)
        {
            return db.Practice($"select LoaiTK from TaiKhoan where LoaiTK=N'{dn}'");
        }
        public DataTable SetThongTin(NguoiQuanLy dn)
        {
            string sql = string.Format("Update TaiKhoan Set Hoten=N'{0}',ChiNhanh=N'{1}',SoDT='{2}',LoaiTK=N'{3}' " +
                "where MaNV='{4}'",dn.Hoten,dn.Chinhanh,dn.Sdt,dn.Loaitk,dn.Manv);
             return db.ThucThi(sql);
        }
     
    }
}
