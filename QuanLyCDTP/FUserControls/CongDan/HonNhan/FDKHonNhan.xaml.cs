using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyCDTP
{
    /// <summary>
    /// Interaction logic for FHonNhan.xaml
    /// </summary>
    public partial class FDKHonNhan : UserControl
    {
        public FDKHonNhan()
        {
            InitializeComponent();
            
        }
        CongDanDAO cdd = new CongDanDAO();
        HonNhanDao hnd = new HonNhanDao();

        void ThongTinNam(CongDan cdnam)
        {
            List<InfoCard> linfor = new List<InfoCard>
            {
                nameNam,namefnam,cccdNam,quequanNam,namemnam,honnhanNam,namefcnam,namecmnam            };
            string namecha = "";
            string nameme = "";
            try
            {
                namecha = (cdd.TimKiem(null, cdnam.CccdCha, "", 1)[0][1]).ToString();
            }
            catch
            {
                namecha = "";
            }
            try
            {
                nameme = (cdd.TimKiem(null, cdnam.CccdMe, "", 1)[0][1]).ToString();
            }
            catch
            {
                nameme = "";
            }
            List<Object> properties = new List<Object>
            {
                cdnam.HoTen,namecha,cdnam.CCCD,cdnam.QueQuan,
                nameme, cdnam.HonNhan,cdnam.CccdCha,cdnam.CccdMe
            };
            for (int i = 0; i < properties.Count; i++)
            {
                try{

                    linfor[i].textBox.Text = properties[i].ToString();
                }
                catch
                {

                }
            }
        }
        void ThongTinNu(CongDan cdnu)
        {
            List<InfoCard> linfor = new List<InfoCard>
            {
                nameNu,namefNu,cccdNu,quequanNu,namemNu,honhanNu,namecfNu,namecmNu
            };
            string namecha = "";
            string nameme = "";
            try
            {
                namecha = (cdd.TimKiem(null, cdnu.CccdCha, "", 1)[0][1]).ToString();
            }
            catch
            {
                namecha = "";
            }
            try
            {
                nameme = (cdd.TimKiem(null, cdnu.CccdMe, "", 1)[0][1]).ToString();
            }
            catch
            {
                nameme = "";
            }
            List<Object> properties = new List<Object>
            {
                cdnu.HoTen,namecha.ToString(),cdnu.CCCD,cdnu.QueQuan,
               nameme, cdnu.HonNhan,cdnu.CccdCha,cdnu.CccdMe
            };
            for (int i = 0; i < properties.Count; i++)
            {
                try
                {

                    linfor[i].textBox.Text = properties[i].ToString();
                }
                catch
                {

                }
            }
        }
        void TimKiemCongDan(string cccdNam,string cccdNu,DateTime date,string NoiDangKy,string nguoidangky)
        {
            
            CongDan congdannam = new CongDan(cccdNam);
            CongDan congdannu = new CongDan(cccdNu);
            DataRow cd;

            try
            {
                try
                {
                    cd = cdd.TimKiem(congdannam, "", "", 2)[0];

                    ThongTinNam(new CongDan(cd[0].ToString(), cd[1].ToString(), cd[2].ToString(), cd[3].ToString(), cd[4].ToString(), cd[5].ToString(), cd[6].ToString(), cd[7].ToString()
                        , cd[8].ToString(), toString(cd, 9), toString(cd, 10), float.Parse(cd[11].ToString()), cd[12].ToString()));

                }
                catch
                {

                }
                try
                {

                    cd = cdd.TimKiem(congdannu, "", "", 2)[0];
                    ThongTinNu(new CongDan(toString(cd, 0), toString(cd, 1), toString(cd, 2), toString(cd, 3), toString(cd, 4), toString(cd, 5), toString(cd, 6), toString(cd, 7)
                           , toString(cd, 8), toString(cd, 9), toString(cd, 10), float.Parse(cd[11].ToString()), toString(cd, 12)));
                   
                }
                catch
                {

                }
                try
                {
                    FBoTro.Ngay.textBox.Text = date.Day.ToString();
                    FBoTro.Thang.textBox.Text = date.Month.ToString();
                    FBoTro.Nam.textBox.Text = date.Year.ToString();
                    FBoTro.CCCDCanBo.textBox.Text = nguoidangky;
                    FBoTro.TimKiem();
                }
                catch
                {

                }
                FBoTro.noidangky.textBox.Text = NoiDangKy;
            }
            catch
            {
                MessageBox.Show("Khong tim thay trong co so du lieu");
                return;
            }
        }
        private void btnLyHon_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HonNhan kethon = new HonNhan(honnhanNam.textBox.Text, cccdNam.textBox.Text, honhanNu.textBox.Text,
                cccdNu.textBox.Text, FBoTro.Date(), FBoTro.noidangky.textBox.Text,FBoTro.CCCDCanBo.textBox.Text);

                if (kethon.checkLH() == true)
                {
                    if (hnd.XoaHN(kethon))
                    {
                        MessageBox.Show("Thanh Cong");
                    }
                    else
                    {
                        MessageBox.Show("That Bai");
                    }
                }
                else
                {
                    MessageBox.Show("Hai người chưa đăng ký kết hôn!", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thực hiện việc đăng ký ly hôn", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            }
        }
        void Clear()
        {
            List<InfoCard> infos = new List<InfoCard>()
            {
                nameNam,namefnam,cccdNam,quequanNam,namemnam,honnhanNam,namefcnam, namecmnam, namecfNu, namecmNu
                ,nameNu,namefNu,cccdNu,quequanNu,nameNu,honhanNu,FBoTro.noidangky,FBoTro.Ngay,FBoTro.Thang,FBoTro.Nam,FBoTro.CCCDCanBo,FBoTro.TenCanBo,namemNu
            };
            foreach (InfoCard info in infos)
            {
                info.textBox.Clear();
            }
        }
        private void btnKetHon_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                HonNhan kethon = new HonNhan(honnhanNam.textBox.Text, cccdNam.textBox.Text, honhanNu.textBox.Text,
                    cccdNu.textBox.Text, FBoTro.Date(), FBoTro.noidangky.textBox.Text,FBoTro.CCCDCanBo.textBox.Text);
                if (kethon.checkKH() == true)
                {
                    if (hnd.ThemHN(kethon))
                        MessageBox.Show("Thành Công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    else
                        MessageBox.Show("That Bại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Người này đã kết hôn rồi !", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng năm, tháng ,ngày: YYYY-MM-DD !", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            }
        }
        public string toString(DataRow cd,int index)
        {
            try
            {
                string thongtin = cd[index].ToString();
                return thongtin;
            }
            catch
            {

            }
            return "";
        }
        
        private void EnterKey(object sender, KeyEventArgs e)
        {
            string etr = e.Key.ToString();
            if (etr == "Return")
            {
                DataRowCollection dbc = hnd.TimKiemThongTinKS(null, cccdNam.textBox.Text, cccdNu.textBox.Text, 2);
                if (dbc.Count != 0)
                {
                    try
                    {
                        TimKiemCongDan(dbc[0][0].ToString(), dbc[0][1].ToString(), Convert.ToDateTime(dbc[0][2].ToString()), dbc[0][3].ToString(), dbc[0][4].ToString());
                    }
                    catch
                    {

                    }
                }
                CongDan congdan = new CongDan(cccdNam.textBox.Text);
                DataRow cd;

                try
                {
                    cd = cdd.TimKiem(congdan, "", "", 2)[0];

                    ThongTinNam(new CongDan(cd[0].ToString(), cd[1].ToString(), cd[2].ToString(), cd[3].ToString(), cd[4].ToString(), cd[5].ToString(), cd[6].ToString(), cd[7].ToString()
                        , cd[8].ToString(), toString(cd, 9), toString(cd, 10), float.Parse(cd[11].ToString()), cd[12].ToString()));


                }
                catch
                {
                    MessageBox.Show("Khong tim thay cong dan trong co so du lieu");
                    return;
                }
            }
        }

        private void EnterKeyNu(object sender, KeyEventArgs e)
        {
            string etr = e.Key.ToString();
            if (etr == "Return")
            {
                DataRowCollection dbc = hnd.TimKiemThongTinKS(null, cccdNam.textBox.Text, cccdNu.textBox.Text, 2);
                if (dbc.Count != 0)
                {
                    try
                    {
                        TimKiemCongDan(dbc[0][0].ToString(), dbc[0][1].ToString(), Convert.ToDateTime(dbc[0][2].ToString()), dbc[0][3].ToString(), dbc[0][4].ToString());
                    }
                    catch
                    {

                    }
                }
                CongDan congdan = new CongDan(cccdNu.textBox.Text);
                DataRow cd;

                try
                {
                    cd = cdd.TimKiem(congdan, "", "", 2)[0];

                    ThongTinNu(new CongDan(toString(cd, 0), toString(cd, 1), toString(cd, 2), toString(cd, 3), toString(cd, 4), toString(cd, 5), toString(cd, 6), toString(cd, 7)
                       , toString(cd, 8), toString(cd, 9), toString(cd, 10), float.Parse(cd[11].ToString()), toString(cd, 12)));

                }
                catch
                {
                    MessageBox.Show("Khong tim thay trong co so du lieu");
                    return;
                }

            }
        }
        private void btnClearT_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

       
    }
}
