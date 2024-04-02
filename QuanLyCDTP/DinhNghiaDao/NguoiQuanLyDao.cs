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
            string sql = "select * from TaiKhoan where  TaiKhoan = '" + dn.Account + "' and MatKhau ='" + dn.Password + "'";
            return db.Practice(sql);
        }
        public DataRowCollection LoadTK()
        {
            return db.ThucThi("select* from TaiKhoan ").Rows;
        }
        public string TimKiemLoai(string dn)
        {
            return db.Practice($"select LoaiTK from TaiKhoan where LoaiTK=N'{dn}'");
        }
    }
}
