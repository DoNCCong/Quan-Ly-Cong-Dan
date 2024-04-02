using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyCDTP
{
    /// <summary>
    /// Interaction logic for FHoChieu.xaml
    /// </summary>
    public partial class FHoChieu : UserControl
    {
        public FHoChieu()
        {
            InitializeComponent();
        }
        HoChieuDao hcD = new HoChieuDao();
        NhatKyDao nkD=new NhatKyDao();
        Check ck=new Check();
        void CLear()
        {
            List<InfoCard> lifor = new List<InfoCard>()
            {
                maso,name,gioitinh,sodienthoai,noicap,diachi,sohochieu
            };
            foreach (InfoCard card in lifor)
            {
                card.textBox.Clear();
            }
            date.SelectedDate = null;
            ngaycap.SelectedDate = null;
        }
        void ClearAgaint()
        {
            List<InfoCard> lifor = new List<InfoCard>()
            {
                stt,id,noiden
            };
            foreach (InfoCard card in lifor)
            {
                card.textBox.Clear();
            }
            ngaydi.SelectedDate = null;
            ngayve.SelectedDate = null;
        }
        private void btnxoatext_Click(object sender, RoutedEventArgs e)
        {
            CLear();
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HoChieu hc = new HoChieu(Convert.ToInt32(maso.textBox.Text), sohochieu.textBox.Text,
                    ngaycap.SelectedDate.Value, noicap.textBox.Text
                   , name.textBox.Text, gioitinh.textBox.Text,date.SelectedDate.Value, diachi.textBox.Text, sodienthoai.textBox.Text);
                bool checkhc = ck.CheckNotNull(hc);
                if (checkhc == true)
                {
                    if (hcD.SuaHoChieu(hc) == true)
                    {

                        MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);

                    }
                    else
                    {
                        MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin không được bỏ trống", "Thông báo",
                              MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng năm, tháng ,ngày: YYYY-MM-DD !", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            }
        }

        private void btnDKHoChieu_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HoChieu hc = new HoChieu(Convert.ToInt32(maso.textBox.Text), sohochieu.textBox.Text, ngaycap.SelectedDate.Value, noicap.textBox.Text
                   , name.textBox.Text, gioitinh.textBox.Text, date.SelectedDate.Value, diachi.textBox.Text, sodienthoai.textBox.Text);
                bool checkhc = ck.CheckNotNull(hc);
                if (checkhc == true)
                {
                    if(hcD.ThemHoChieu(hc)==true)
                    {

                        MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);

                    }
                    else
                    {
                        MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                    }
                    MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Thông Tin Không Được Bỏ Trống", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng năm, tháng ,ngày: YYYY-MM-DD !", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {

            HoChieu hc = new HoChieu(Convert.ToInt32(maso.textBox.Text));
            if (hcD.XoaHC(hc) == null)
            {
                MessageBox.Show("Bạn Vui Lòng Xoá Lịch Trình Đi Lại Của 1 Người " +
                   "Trong Hộ Chiếu Trước Rồi Hãy Thực Hiện Lại Thao Tác Này !", "Thông Báo", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            }    

        }
        void ThongTin(HoChieu hc)
        {
            List<InfoCard> linfo = new List<InfoCard>()
            {
                maso,sohochieu,noicap,name, gioitinh,diachi,sodienthoai
            };
            Object[] hcproperties = new Object[] { hc.Id,hc.Sodoc
                ,hc.Noicap,hc.Hoten,hc.Gioitinh,hc.Diachi,hc.Sdt};
            for (int i = 0; i < linfo.Count; i++)
            {
                linfo[i].textBox.Text = hcproperties[i].ToString();
            }
            ngaycap.SelectedDate = hc.Ngaycap;
            date.SelectedDate = hc.Ngaysinh;
        }
        private void maso_KeyDown(object sender, KeyEventArgs e)
        {
            string etr = e.Key.ToString();
            if (etr == "Return")
            {
                DataRow cd;
                HoChieu hochieu = new HoChieu(Convert.ToInt32(maso.textBox.Text));
                try
                {
                    cd = hcD.TimKiemHoChieu(hochieu.Id)[0];
                }
                catch
                {
                    MessageBox.Show("Khong tim thay trong co so du lieu");
                    return;
                }
                ThongTin(new HoChieu(Convert.ToInt32(cd[0].ToString()), cd[1].ToString(), Convert.ToDateTime(cd[2].ToString()),
                    cd[3].ToString(), cd[4].ToString(),
                    cd[5].ToString(), Convert.ToDateTime(cd[6].ToString()), cd[7].ToString()
                    , cd[8].ToString()));
            }
        }

        private void btnthemlt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NhatKyDiLai hc = new NhatKyDiLai(Convert.ToInt32(stt.textBox.Text), Convert.ToInt32(id.textBox.Text), noiden.textBox.Text,
                    ngaydi.SelectedDate.Value,
                    ngayve.SelectedDate.Value);
                bool checkhc = ck.CheckNotNull(hc);
                if (checkhc == true)
                {
                    nkD.ThemLT(hc);
                    MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Thông Tin Không Được Bỏ Trống", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng năm, tháng ,ngày: YYYY-MM-DD !", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            }
        }

        private void btnXoate_Click(object sender, RoutedEventArgs e)
        {
            ClearAgaint();
        }

        private void btnsualt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NhatKyDiLai hc = new NhatKyDiLai(Convert.ToInt32(stt.textBox.Text), Convert.ToInt32(id.textBox.Text), noiden.textBox.Text,
                  ngaydi.SelectedDate.Value,
                  ngayve.SelectedDate.Value);
                bool checkhc = ck.CheckNotNull(hc);
                if (checkhc == true)
                {
                    nkD.SuaLT(hc);
                    MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Thông Tin Không Được Bỏ Trống", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng năm, tháng ,ngày: YYYY-MM-DD !", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            }
        }
        private void btnXoalt_Click(object sender, RoutedEventArgs e)
        {
            NhatKyDiLai hc = new NhatKyDiLai(Convert.ToInt32(stt.textBox.Text));
            if (nkD.XoaLT(hc) == null)
            {
                MessageBox.Show("Thất Bại");
            }
            else
            {
                MessageBox.Show("Thanh Cong", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            }
        }
        void ThongTinNhatKy(NhatKyDiLai nk)
        {
            List<InfoCard> linfo = new List<InfoCard>()
            {
                stt,id,noiden
            };
            Object[] hcproperties = new Object[] {nk.Stt,nk.Id,nk.Noiden};
            for (int i = 0; i < linfo.Count; i++)
            {
                linfo[i].textBox.Text = hcproperties[i].ToString();
            }
            ngaydi.SelectedDate = nk.Ngaydi;
            ngayve.SelectedDate = nk.Ngayden;

        }
        private void stt_KeyDown(object sender, KeyEventArgs e)
        {
            string etr = e.Key.ToString();
            if (etr == "Return")
            {
                DataRow cd;
                NhatKyDiLai nhatKy = new NhatKyDiLai(Convert.ToInt32(stt.textBox.Text));
                try
                {
                    cd = nkD.TimKiemLS(nhatKy)[0];
                }
                catch
                {
                    MessageBox.Show("Khong tim thay trong co so du lieu");
                    return;
                }
                ThongTinNhatKy  (new NhatKyDiLai(Convert.ToInt32(cd[0]),Convert.ToInt32(cd[1]),
                    cd[2].ToString(),Convert.ToDateTime(cd[3]), Convert.ToDateTime(cd[4])));
            }
        }
    }
}
