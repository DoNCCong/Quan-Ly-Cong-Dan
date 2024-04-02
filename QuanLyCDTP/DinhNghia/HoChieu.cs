using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLyCDTP
{
     public class HoChieu
    {
        private int id;
        private string sodoc;
        private DateTime ngaycap;
        private string noicap;
        private string hoten;
        private string gioitinh;
        private DateTime ngaysinh;
        private string diachi;
        private string sdt;
        

        public HoChieu(int id, string sodoc, DateTime ngaycap, string noicap, string hoten, string gioitinh
            , DateTime ngaysinh, string diachi, string sdt)
        {
            this.id = id;
            this.sodoc = sodoc.Trim();
            this.ngaycap = ngaycap;
            this.noicap = noicap.Trim();
            this.hoten = hoten.Trim();
            this.gioitinh = gioitinh.Trim();
            this.ngaysinh = ngaysinh;
            this.diachi = diachi.Trim();
            this.sdt = sdt.Trim();

        }
        public HoChieu(int id)
        {
            this.id = id;
        }
       
        public int Id { get => id; }
        public string Sodoc { get => sodoc; }
        public DateTime Ngaycap { get => ngaycap; }
        public string Noicap { get => noicap; }
        public string Hoten { get => hoten; }
        public string Gioitinh { get => gioitinh; }
        public DateTime Ngaysinh { get => ngaysinh; }
        public string Diachi { get => diachi; }
        public string Sdt { get => sdt; }
    }
}
