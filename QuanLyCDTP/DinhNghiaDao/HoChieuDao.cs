using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace QuanLyCDTP
{
    public  class HoChieuDao
    {
        DBConnection dB = new DBConnection();
        public DataRowCollection TimKiemHoChieu(int MaSo)
        {
            return dB.ThucThi($"select * from HoChieu where ID ='{MaSo}'").Rows;
        }
        public bool ThemHoChieu(HoChieu hc)
        {
            string hochieu = string.Format("insert into HoChieu(ID,SoDoc,NgayCap,NoiCap,HoTen,GioiTinh,NgaySinh,DiaChi,SoDienThoai) " +
                "Values('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')"
               , hc.Id, hc.Sodoc, hc.Ngaycap, hc.Noicap, hc.Hoten, hc.Gioitinh,
             hc.Ngaysinh, hc.Diachi, hc.Sdt);

            if (dB.ThucThi(hochieu) == null)
            {
                return false;
            }
            return true;
        }
        public bool SuaHoChieu(HoChieu hc)
        {
            string hochieu = string.Format("Update HoChieu set SoDoc=N'{0}',NgayCap=N'{1}',NoiCap=N'{2}',HoTen=N'{3}'" +
                ",GioiTinh=N'{4}',NgaySinh=N'{5}',DiaChi=N'{6}',SoDienThoai='{7}' where ID='{8}'"
              , hc.Sodoc, hc.Ngaycap, hc.Noicap, hc.Hoten, hc.Gioitinh,
             hc.Ngaysinh, hc.Diachi, hc.Sdt, hc.Id);
            dB.ThucThi(hochieu);
            if (dB.ThucThi(hochieu) == null)
            {
                return false;
            }
            return true;
        }
        
        public DataRowCollection LayDSHC()
        {
            return dB.ThucThi("Select*From HoChieu").Rows;
        }
        public DataTable XoaHC(HoChieu hc)
        {
            string fill = string.Format("Delete From HoChieu where ID='{0}'", hc.Id);
            return dB.ThucThi(fill);
        }
        public DataRowCollection TimKiem(string fillter, int select)
        {
            string truyvan = $"select hc.ID,hc.SoDoc,hc.NgayCap,hc.NoiCap,hc.hoten,hc.GioiTinh,hc.NgaySinh" +
                ",hc.diachi,hc.SoDienThoai,dk.noiden,dk.ngayden,dk.ngaydi from hochieu as hc,nhatky " +
                "as dk where hc.ID=dk.ID ";
            switch (select)
            {
                case 1:
                    {//LayDSlsdilai
                        break;
                    }
                case 2:
                    {//SortAZ 
                        truyvan += "order by hoten ";
                        break;
                    }
                case 3:
                    {//SortZA()
                        truyvan += "order by hoten desc";
                        break;
                    }
                case 4:
                    {//LocTamTru
                        truyvan += $"and  hc.NoiCap like '{fillter}'";
                        break;
                    }
            }
            try
            {
                return dB.ThucThi(truyvan).Rows;
            }
            catch
            {

            }
            return null;
        }
    }
}
