using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCDTP
{
    public class NguoiQuanLy
    {
        private string manv;
        private string account;
        private string password;
        private string hoten;
        private string chinhanh;
        private string sdt;
        private string loaitk;
        public string Account { get => account; }
        public string Password { get => password; }
        public string Chinhanh { get => chinhanh; }
        public string Hoten { get => hoten; }
        public string Sdt { get => sdt; }
        public string Loaitk { get => loaitk; }
        public string Manv { get => manv; }

        public NguoiQuanLy(string account, string password)
        {
            this.account = account;
            this.password = password;
        }
        public NguoiQuanLy(string manv, string account, string password, string hoten, string chinhanh, string sdt, string loaitk)
        {
            this.manv = manv;
            this.account = account;
            this.password = password;
            this.hoten = hoten;
            this.chinhanh = chinhanh;
            this.sdt = sdt;
            this.loaitk = loaitk;
        }
    }
}
